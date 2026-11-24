using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Native;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 Objective-C <c>Method</c> 句柄的只读包装。
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public readonly record struct ObjCMethod : IPointer
{
    public ObjCMethod(nint ptr) => Ptr = ptr;

    /// <inheritdoc />
    public IntPtr Ptr { get; init; }

    /// <inheritdoc />
    public bool IsNull => Ptr == nint.Zero;

    public static implicit operator nint(ObjCMethod method) => method.Ptr;

    public static explicit operator ObjCMethod(nint ptr) => new(ptr);

    /// <summary>
    /// 获取方法的 selector。
    /// </summary>
    public ObjCSel Name => Native.ObjC.method_getName(this);

    /// <summary>
    /// 获取方法的实现。
    /// </summary>
    public ObjCImp Implementation => Native.ObjC.method_getImplementation(this);

    /// <summary>
    /// 获取方法的参数个数。
    /// </summary>
    public uint NumberOfArguments => Native.ObjC.method_getNumberOfArguments(this);

    /// <summary>
    /// 获取描述方法参数和返回值类型的类型编码。
    /// </summary>
    public string TypeEncoding
    {
        get
        {
            var ptr = Native.ObjC.method_getTypeEncoding(this);
            return ptr == nint.Zero ? string.Empty : Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
        }
    }
}
