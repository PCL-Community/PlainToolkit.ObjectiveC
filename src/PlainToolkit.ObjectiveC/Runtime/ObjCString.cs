using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 Objective-C NSString 句柄的只读包装。
/// </summary>
/// <param name="Value">NSString 的底层指针句柄（<see cref="IntPtr"/>）。</param>
public readonly record struct ObjCString(IntPtr Value)
{
    public readonly IntPtr Value = Value;

    public bool IsNull => Value == IntPtr.Zero;

    public static implicit operator IntPtr(ObjCString h) => h.Value;
    public static explicit operator ObjCString(IntPtr ptr) => new(ptr);

    public static ObjCString FromString(string str)
    {
        var nsStringClass = ObjCObject.GetClass("NSString");

        var utf8 = Marshal.StringToCoTaskMemUTF8(str);

        try
        {
            var result = nsStringClass
                .SendMessage(Selectors.Alloc)
                .SendMessage(Selectors.InitWithUtf8String, utf8);

            return new ObjCString(result.Value);
        }
        finally
        {
            Marshal.FreeCoTaskMem(utf8);
        }
    }

    public string ToManagedString()
    {
        var ptr = ((ObjCObject)Value).SendMessage(Selectors.Utf8String);
        return Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
    }
}