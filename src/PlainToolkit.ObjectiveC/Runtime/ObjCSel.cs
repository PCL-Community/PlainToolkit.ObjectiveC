using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 Objective-C SEL 句柄的只读包装。
/// </summary>
/// <param name="Value">SEL 的底层指针句柄（<see cref="IntPtr"/>）。</param>
public readonly record struct ObjCSel(IntPtr Value)
{
    public readonly IntPtr Value = Value;

    public bool IsNull => Value == IntPtr.Zero;

    public static implicit operator IntPtr(ObjCSel h) => h.Value;
    public static explicit operator ObjCSel(IntPtr ptr) => new(ptr);

    public static unsafe ObjCSel FromString(string name)
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

    public static string ToManagedString(ObjCSel objCSel)
    {
        return objCSel.IsNull ? string.Empty : Marshal.PtrToStringUTF8(Native.ObjC.sel_getName(objCSel.Value))!;
    }
}