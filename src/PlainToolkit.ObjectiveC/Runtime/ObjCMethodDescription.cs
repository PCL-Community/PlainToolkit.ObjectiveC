using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 对应 Objective-C 运行时的 <c>struct objc_method_description</c>。
/// </summary>
/// <remarks>
/// 这是按值传递的结构体，包含 <c>SEL</c> 和类型编码两个指针，因此在 64 位平台上大小为
/// <c>2 * IntPtr.Size</c>，而不是单个指针的大小。
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public readonly struct ObjCMethodDescription
{
    /// <summary>
    /// 方法在运行时的名称。
    /// </summary>
    public readonly ObjCSel Name;

    /// <summary>
    /// 方法参数的类型编码。
    /// </summary>
    public readonly nint Types;

    public ObjCMethodDescription(ObjCSel name, nint types)
    {
        Name = name;
        Types = types;
    }

    /// <summary>
    /// 获取一个值，该值指示名称和类型编码是否都为空。
    /// </summary>
    public bool IsNull => Name.IsNull && Types == nint.Zero;

    /// <summary>
    /// 获取方法参数类型编码的托管字符串。
    /// </summary>
    public string TypesString =>
        Types == nint.Zero ? string.Empty : Marshal.PtrToStringUTF8(Types) ?? string.Empty;
}
