using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Native;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 Objective-C SEL 句柄的只读包装。
/// </summary>
/// <param name="Value">SEL 的底层指针句柄（<see cref="nint"/>）。</param>
[StructLayout(LayoutKind.Sequential)]
public readonly record struct ObjCSel : Pointer
{
    public ObjCSel(nint ptr)
    {
        Ptr = ptr;
    }
    
    public IntPtr Ptr { get; init; }

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
            return new ObjCSel(Native.ObjC.sel_registerName(ptr));
        }
        finally
        {
            Marshal.FreeCoTaskMem(ptr);
        }
    }

    public string ToManagedString()
    {
        return Marshal.PtrToStringUTF8(Native.ObjC.sel_getName(Ptr))!;
    }
}