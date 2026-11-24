using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Native;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 <c>objc_cache</c> 句柄的只读包装。
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public readonly record struct ObjCCache : IPointer
{
    public ObjCCache(nint ptr) => Ptr = ptr;

    /// <inheritdoc />
    public IntPtr Ptr { get; init; }

    /// <inheritdoc />
    public bool IsNull => Ptr == nint.Zero;

    public static implicit operator nint(ObjCCache cache) => cache.Ptr;

    public static explicit operator ObjCCache(nint ptr) => new(ptr);
}
