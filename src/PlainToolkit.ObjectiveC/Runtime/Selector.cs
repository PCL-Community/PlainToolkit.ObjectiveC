using System.Text;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 Objective-C SEL 句柄的只读包装。
/// </summary>
/// <param name="Value">SEL 的底层指针句柄（<see cref="IntPtr"/>）。</param>
public readonly record struct Selector(IntPtr Value)
{
    public readonly IntPtr Value = Value;
    
    public bool IsNull => Value == IntPtr.Zero;
    
    public static implicit operator IntPtr(Selector h) => h.Value;
    
    public static explicit operator Selector(IntPtr ptr) => new(ptr);
    
    public static unsafe Selector FromString(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        var byteCount = Encoding.UTF8.GetByteCount(name);
        var utf8 = new byte[byteCount + 1]; // 为了 C-Style 的 string 末尾的 null terminator 多分配一个字节
        Encoding.UTF8.GetBytes(name, 0, name.Length, utf8, 0);
        utf8[byteCount] = 0; // null terminator
        
        fixed (byte* pName = utf8)
        {
            return new Selector(Native.Runtime.sel_registerName(pName));
        }
    }
    
    public static unsafe string ToManagedString(Selector selector)
    {
        if (selector.IsNull)
        {
            return string.Empty;
        }

        var p = Native.Runtime.sel_getName(selector.Value);
        if (p == null)
            return string.Empty;

        // 找到 '\0'
        var start = p;
        while (*p != 0) p++;
        var length = (int)(p - start);

        return Encoding.UTF8.GetString(start, length);
    }
}