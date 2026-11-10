using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 Objective-C NSString 句柄的只读包装。
/// </summary>
/// <param name="Value">NSString 的底层指针句柄（<see cref="nint"/>）。</param>
public readonly record struct ObjCString(nint Value)
{
    public readonly nint Value = Value;

    public bool IsNull => Value == nint.Zero;

    public static implicit operator nint(ObjCString h) => h.Value;
    public static explicit operator ObjCString(nint ptr) => new(ptr);

    public static ObjCString FromString(string str)
    {
        var nsStringClass = ObjCObject.GetClass("NSString");

        var utf8 = Marshal.StringToCoTaskMemUTF8(str);

        try
        {
            var result = nsStringClass
                .SendMessage<ObjCObject>(Selectors.Alloc)
                .SendMessage<nint, ObjCObject>(Selectors.InitWithUtf8String, utf8);

            return new ObjCString(result.Value);
        }
        finally
        {
            Marshal.FreeCoTaskMem(utf8);
        }
    }

    public string ToManagedString()
    {
        var ptr = ((ObjCObject)Value).SendMessage<nint>(Selectors.Utf8String);
        return Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
    }
}