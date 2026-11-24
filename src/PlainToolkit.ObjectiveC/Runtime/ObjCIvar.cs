using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Native;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 Objective-C <c>Ivar</c> 句柄的只读包装。
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public readonly record struct ObjCIvar : IPointer
{
    public ObjCIvar(nint ptr) => Ptr = ptr;

    /// <inheritdoc />
    public IntPtr Ptr { get; init; }

    /// <inheritdoc />
    public bool IsNull => Ptr == nint.Zero;

    public static implicit operator nint(ObjCIvar ivar) => ivar.Ptr;

    public static explicit operator ObjCIvar(nint ptr) => new(ptr);

    /// <summary>
    /// 获取实例变量的名称。
    /// </summary>
    public string Name
    {
        get
        {
            var ptr = Native.ObjC.ivar_getName(this);
            return ptr == nint.Zero ? string.Empty : Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
        }
    }

    /// <summary>
    /// 获取实例变量的类型编码。
    /// </summary>
    public string TypeEncoding
    {
        get
        {
            var ptr = Native.ObjC.ivar_getTypeEncoding(this);
            return ptr == nint.Zero ? string.Empty : Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
        }
    }

    /// <summary>
    /// 获取实例变量的偏移量。
    /// </summary>
    public nint Offset => Native.ObjC.ivar_getOffset(this);
}
