using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Native;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 <c>objc_property_t</c> 句柄的只读包装。
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public readonly record struct ObjCProperty : IPointer
{
    public ObjCProperty(nint ptr) => Ptr = ptr;

    /// <inheritdoc />
    public IntPtr Ptr { get; init; }

    /// <inheritdoc />
    public bool IsNull => Ptr == nint.Zero;

    public static implicit operator nint(ObjCProperty property) => property.Ptr;

    public static explicit operator ObjCProperty(nint ptr) => new(ptr);

    /// <summary>
    /// 获取属性的名称。
    /// </summary>
    public string Name
    {
        get
        {
            var ptr = Native.ObjC.property_getName(this);
            return ptr == nint.Zero ? string.Empty : Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
        }
    }

    /// <summary>
    /// 获取属性的特性字符串。
    /// </summary>
    public string Attributes
    {
        get
        {
            var ptr = Native.ObjC.property_getAttributes(this);
            return ptr == nint.Zero ? string.Empty : Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
        }
    }
}
