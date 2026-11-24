using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 对应 Objective-C 运行时的 <c>struct objc_property_attribute_t</c>。
/// </summary>
/// <remarks>
/// 这是按值传递的结构体，包含名称和值两个指针，因此在 64 位平台上大小为
/// <c>2 * IntPtr.Size</c>，而不是单个指针的大小。
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public readonly struct ObjCPropertyAttribute
{
    /// <summary>
    /// 特性的名称。
    /// </summary>
    public readonly nint Name;

    /// <summary>
    /// 特性的值（通常为空）。
    /// </summary>
    public readonly nint Value;

    public ObjCPropertyAttribute(nint name, nint value)
    {
        Name = name;
        Value = value;
    }

    /// <summary>
    /// 获取一个值，该值指示名称和值是否都为空。
    /// </summary>
    public bool IsNull => Name == nint.Zero && Value == nint.Zero;

    /// <summary>
    /// 获取特性名称的托管字符串。
    /// </summary>
    public string NameString =>
        Name == nint.Zero ? string.Empty : Marshal.PtrToStringUTF8(Name) ?? string.Empty;

    /// <summary>
    /// 获取特性值的托管字符串。
    /// </summary>
    public string ValueString =>
        Value == nint.Zero ? string.Empty : Marshal.PtrToStringUTF8(Value) ?? string.Empty;
}
