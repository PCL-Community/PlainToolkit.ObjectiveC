using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Native;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 Objective-C SEL 句柄的只读包装。
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public readonly record struct ObjCSel : IPointer
{
    public ObjCSel(nint ptr) => Ptr = ptr;

    public IntPtr Ptr { get; init; }

    /// <summary>
    /// 获取一个值，该值指示此句柄是否为 <c>NULL</c>。
    /// </summary>
    public bool IsNull => Ptr == nint.Zero;

    public static implicit operator nint(ObjCSel h) => h.Ptr;
    public static explicit operator ObjCSel(nint ptr) => new(ptr);

    public static ObjCSel FromString(string name)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);

        if (name.Contains('\0'))
        {
            throw new ArgumentException("Selector 名字不能含有字符串终止符。", nameof(name));
        }

        var ptr = Marshal.StringToCoTaskMemUTF8(name);

        try
        {
            return Native.ObjC.sel_registerName(ptr);
        }
        finally
        {
            Marshal.FreeCoTaskMem(ptr);
        }
    }

    public string ToManagedString()
    {
        var name = Native.ObjC.sel_getName(this);
        return name == nint.Zero ? string.Empty : Marshal.PtrToStringUTF8(name) ?? string.Empty;
    }
}