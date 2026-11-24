using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Native;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 Objective-C <c>Protocol</c> 句柄的只读包装。
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public readonly record struct ObjCProtocol : IPointer
{
    public ObjCProtocol(nint ptr) => Ptr = ptr;

    /// <inheritdoc />
    public IntPtr Ptr { get; init; }

    /// <inheritdoc />
    public bool IsNull => Ptr == nint.Zero;

    public static implicit operator nint(ObjCProtocol protocol) => protocol.Ptr;

    public static explicit operator ObjCProtocol(nint ptr) => new(ptr);

    /// <summary>
    /// 获取协议的名称。
    /// </summary>
    public string Name
    {
        get
        {
            var ptr = Native.ObjC.protocol_getName(this);
            return ptr == nint.Zero ? string.Empty : Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
        }
    }

    /// <summary>
    /// 判断两个协议是否相等。
    /// </summary>
    public bool IsEqual(ObjCProtocol other) => Native.ObjC.protocol_isEqual(this, other) != ObjCBool.NO;

    /// <summary>
    /// 判断此协议是否遵循另一个协议。
    /// </summary>
    public bool ConformsToProtocol(ObjCProtocol other) =>
        Native.ObjC.protocol_conformsToProtocol(this, other) != ObjCBool.NO;
}
