namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 对应 Objective-C 运行时的 <c>objc_AssociationPolicy</c>，用于指定关联对象的引用行为。
/// </summary>
/// <remarks>
/// 原生类型为 <c>uintptr_t</c>，因此使用 <see cref="ulong"/> 作为底层类型以保持指针宽度。
/// </remarks>
public enum ObjCAssociationPolicy : ulong
{
    /// <summary>
    /// 弱引用，不保留也不复制关联对象。
    /// </summary>
    Assign = 0,

    /// <summary>
    /// 强引用关联对象，非原子操作。
    /// </summary>
    RetainNonatomic = 1,

    /// <summary>
    /// 复制关联对象，非原子操作。
    /// </summary>
    CopyNonatomic = 3,

    /// <summary>
    /// 强引用关联对象，原子操作。
    /// </summary>
    Retain = 0x301,

    /// <summary>
    /// 复制关联对象，原子操作。
    /// </summary>
    Copy = 0x303
}
