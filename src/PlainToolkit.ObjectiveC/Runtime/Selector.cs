using System.Buffers;
using System.Text;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 Objective-C SEL 句柄的只读包装。
/// </summary>
/// <param name="Value">SEL 的底层指针句柄（<see cref="IntPtr"/>）。</param>
public readonly record struct Selector(IntPtr Value)
{
    private const int StackAllocThreshold = 256;
    
    public readonly IntPtr Value = Value;
    
    public bool IsNull => Value == IntPtr.Zero;
    
    public static implicit operator IntPtr(Selector h) => h.Value;
    public static explicit operator Selector(IntPtr ptr) => new(ptr);
    
    public static unsafe Selector FromString(string name)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);

        if (name.Contains('\0'))
        {
            throw new ArgumentException("Selector 名字不能含有字符串终止符。", nameof(name));
        }
        
        var byteCount = Encoding.UTF8.GetByteCount(name);
        var bufferSize = byteCount + 1;
        
        byte[]? rented = null;

        var buffer = bufferSize <= StackAllocThreshold 
            ? stackalloc byte[bufferSize]
            : (rented = ArrayPool<byte>.Shared.Rent(bufferSize))
            .AsSpan(0, bufferSize);
        
        try
        {
            var written = Encoding.UTF8.GetBytes(name.AsSpan(), buffer);
            buffer[written] = 0;

            fixed (byte* pName = buffer)
            {
                return new Selector(Native.Runtime.sel_registerName(pName));
            }
        }
        finally
        {
            if (rented is not null)
            {
                ArrayPool<byte>.Shared.Return(rented);
            }
        }
    }
    
    public static unsafe string ToManagedString(Selector selector)
    {
        if (selector.IsNull)
            return string.Empty;

        var pName = Native.Runtime.sel_getName(selector.Value);

        if (pName is null)
            return string.Empty;

        var end = pName;
        while (*end != 0)
            end++;

        var length = checked((int)(end - pName));

        return Encoding.UTF8.GetString(new ReadOnlySpan<byte>(pName, length));
    }
}