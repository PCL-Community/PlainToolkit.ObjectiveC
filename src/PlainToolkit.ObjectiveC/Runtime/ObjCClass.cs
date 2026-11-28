using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Native;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 Objective-C <c>Class</c> 句柄的只读包装。
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public readonly record struct ObjCClass : IPointer
{
    /// <summary>
    /// 使用底层指针初始化 <see cref="ObjCClass"/>。
    /// </summary>
    /// <param name="ptr">Class 的底层指针句柄。</param>
    public ObjCClass(nint ptr) => Ptr = ptr;

    /// <inheritdoc />
    public IntPtr Ptr { get; init; }

    /// <summary>
    /// 获取一个值，该值指示此句柄是否为 <c>Nil</c>。
    /// </summary>
    public bool IsNull => Ptr == nint.Zero;

    public static implicit operator nint(ObjCClass cls) => cls.Ptr;

    public static implicit operator ObjCId(ObjCClass cls) => new(cls.Ptr);

    public static explicit operator ObjCClass(nint ptr) => new(ptr);

    /// <summary>
    /// 获取一个可以接收 Objective-C 消息的对象句柄。
    /// </summary>
    /// <remarks>
    /// <c>Class</c> 本身也是 <c>id</c>，因此可以通过此属性向类发送类方法消息。
    /// </remarks>
    public ObjCId AsObject => new(Ptr);

    /// <summary>
    /// 获取具有指定名称的类。
    /// </summary>
    /// <param name="name">类的名称。</param>
    /// <returns>具有指定名称的类；如果不存在，则返回 <c>Nil</c>。</returns>
    /// <exception cref="ArgumentException"><paramref name="name"/> 为 <see langword="null"/>、空字符串或含有字符串终止符。</exception>
    public static ObjCClass GetClass(string name)
    {
        ValidateName(name);

        var ptr = Marshal.StringToCoTaskMemUTF8(name);

        try
        {
            return new ObjCClass((nint)Native.ObjC.objc_getClass(ptr));
        }
        finally
        {
            Marshal.FreeCoTaskMem(ptr);
        }
    }

    /// <summary>
    /// 获取类名。
    /// </summary>
    /// <returns>类名；如果此句柄为 <c>Nil</c>，则返回空字符串。</returns>
    public string Name
    {
        get
        {
            if (IsNull)
            {
                return string.Empty;
            }

            var name = Native.ObjC.class_getName(this);
            return name == nint.Zero ? string.Empty : Marshal.PtrToStringUTF8(name) ?? string.Empty;
        }
    }

    /// <summary>
    /// 获取此类的父类。
    /// </summary>
    /// <returns>父类；如果此类是根类或为 <c>Nil</c>，则返回 <c>Nil</c>。</returns>
    public ObjCClass Superclass => Native.ObjC.class_getSuperclass(this);

    /// <summary>
    /// 获取一个值，该值指示此类是否为元类。
    /// </summary>
    public bool IsMetaClass => Native.ObjC.class_isMetaClass(this) != ObjCBool.NO;

    /// <summary>
    /// 获取此类实例的大小（以字节为单位）。
    /// </summary>
    public nuint InstanceSize => Native.ObjC.class_getInstanceSize(this);

    /// <summary>
    /// 获取指定名称的实例变量。
    /// </summary>
    /// <param name="name">实例变量的名称。</param>
    /// <returns>描述该实例变量的 <see cref="ObjCIvar"/> 句柄；如果未找到，则返回 <c>NULL</c>。</returns>
    /// <exception cref="ArgumentException"><paramref name="name"/> 为 <see langword="null"/>、空字符串或含有字符串终止符。</exception>
    public ObjCIvar GetInstanceVariable(string name)
    {
        ValidateName(name);

        var namePtr = Marshal.StringToCoTaskMemUTF8(name);

        try
        {
            return (ObjCIvar)Native.ObjC.class_getInstanceVariable(this, namePtr);
        }
        finally
        {
            Marshal.FreeCoTaskMem(namePtr);
        }
    }

    /// <summary>
    /// 获取指定名称的类变量。
    /// </summary>
    /// <param name="name">类变量的名称。</param>
    /// <returns>描述该类变量的 <see cref="ObjCIvar"/> 句柄；如果未找到，则返回 <c>NULL</c>。</returns>
    /// <exception cref="ArgumentException"><paramref name="name"/> 为 <see langword="null"/>、空字符串或含有字符串终止符。</exception>
    public ObjCIvar GetClassVariable(string name)
    {
        ValidateName(name);

        var namePtr = Marshal.StringToCoTaskMemUTF8(name);

        try
        {
            return (ObjCIvar)Native.ObjC.class_getClassVariable(this, namePtr);
        }
        finally
        {
            Marshal.FreeCoTaskMem(namePtr);
        }
    }

    /// <summary>
    /// 获取指定名称的属性。
    /// </summary>
    /// <param name="name">属性的名称。</param>
    /// <returns>描述该属性的 <see cref="ObjCProperty"/> 句柄；如果未找到，则返回 <c>NULL</c>。</returns>
    /// <exception cref="ArgumentException"><paramref name="name"/> 为 <see langword="null"/>、空字符串或含有字符串终止符。</exception>
    public ObjCProperty GetProperty(string name)
    {
        ValidateName(name);

        var namePtr = Marshal.StringToCoTaskMemUTF8(name);

        try
        {
            return (ObjCProperty)Native.ObjC.class_getProperty(this, namePtr);
        }
        finally
        {
            Marshal.FreeCoTaskMem(namePtr);
        }
    }

    /// <summary>
    /// 向此类添加一个新的实例变量。
    /// </summary>
    /// <param name="name">实例变量的名称。</param>
    /// <param name="size">实例变量的大小（以字节为单位）。</param>
    /// <param name="alignment">实例变量的对齐方式，以 2 为底的对数表示。</param>
    /// <param name="types">实例变量的类型编码，或 <see langword="null"/>。</param>
    /// <returns>如果添加成功，则为 <see langword="true"/>；否则为 <see langword="false"/>。</returns>
    /// <remarks>
    /// 此方法只能在 <c>objc_allocateClassPair</c> 之后、<c>objc_registerClassPair</c> 之前调用，
    /// 且不能用于元类。
    /// </remarks>
    /// <exception cref="ArgumentException"><paramref name="name"/> 为 <see langword="null"/>、空字符串或含有字符串终止符。</exception>
    public bool AddIvar(string name, nuint size, byte alignment, string? types)
    {
        ValidateName(name);

        var namePtr = Marshal.StringToCoTaskMemUTF8(name);
        var typesPtr = types is null ? nint.Zero : Marshal.StringToCoTaskMemUTF8(types);

        try
        {
            return Native.ObjC.class_addIvar(this, namePtr, size, alignment, typesPtr) != ObjCBool.NO;
        }
        finally
        {
            Marshal.FreeCoTaskMem(namePtr);

            if (typesPtr != nint.Zero)
            {
                Marshal.FreeCoTaskMem(typesPtr);
            }
        }
    }

    /// <summary>
    /// 向此类添加一个新的方法。
    /// </summary>
    /// <param name="name">方法的 selector。</param>
    /// <param name="imp">方法实现的函数指针，该函数至少接受 <c>self</c> 和 <c>_cmd</c> 两个参数。</param>
    /// <param name="types">方法的类型编码，或 <see langword="null"/>。</param>
    /// <returns>如果添加成功，则为 <see langword="true"/>；否则为 <see langword="false"/>。</returns>
    /// <remarks>
    /// 此方法会添加对父类实现的覆盖，但不会替换此类中已有的实现。
    /// </remarks>
    public bool AddMethod(ObjCSel name, ObjCImp imp, string? types)
    {
        var typesPtr = types is null ? nint.Zero : Marshal.StringToCoTaskMemUTF8(types);

        try
        {
            return Native.ObjC.class_addMethod(this, name, imp, typesPtr) != ObjCBool.NO;
        }
        finally
        {
            if (typesPtr != nint.Zero)
            {
                Marshal.FreeCoTaskMem(typesPtr);
            }
        }
    }

    /// <summary>
    /// 获取此类的实例变量布局描述。
    /// </summary>
    public nint IvarLayout => Native.ObjC.class_getIvarLayout(this);

    /// <summary>
    /// 设置此类的实例变量布局。
    /// </summary>
    /// <param name="layout">实例变量布局的指针。</param>
    public void SetIvarLayout(nint layout) => Native.ObjC.class_setIvarLayout(this, layout);

    /// <summary>
    /// 获取此类的弱引用实例变量布局描述。
    /// </summary>
    public nint WeakIvarLayout => Native.ObjC.class_getWeakIvarLayout(this);

    /// <summary>
    /// 设置此类的弱引用实例变量布局。
    /// </summary>
    /// <param name="layout">弱引用实例变量布局的指针。</param>
    public void SetWeakIvarLayout(nint layout) => Native.ObjC.class_setWeakIvarLayout(this, layout);

    /// <summary>
    /// 获取指定 selector 对应的实例方法。
    /// </summary>
    /// <param name="name">方法的 selector。</param>
    /// <returns>对应的方法；如果未找到，则返回 <c>NULL</c>。</returns>
    public ObjCMethod GetInstanceMethod(ObjCSel name) => Native.ObjC.class_getInstanceMethod(this, name);

    /// <summary>
    /// 获取指定 selector 对应的类方法。
    /// </summary>
    /// <param name="name">方法的 selector。</param>
    /// <returns>对应的方法；如果未找到，则返回 <c>NULL</c>。</returns>
    public ObjCMethod GetClassMethod(ObjCSel name) => Native.ObjC.class_getClassMethod(this, name);

    /// <summary>
    /// 获取指定 selector 对应的函数指针。
    /// </summary>
    /// <param name="name">方法的 selector。</param>
    /// <returns>对应的方法实现。</returns>
    public ObjCImp GetMethodImplementation(ObjCSel name) =>
        Native.ObjC.class_getMethodImplementation(this, name);

    /// <summary>
    /// 判断此类的实例是否响应指定的 selector。
    /// </summary>
    /// <param name="sel">要检查的 selector。</param>
    /// <returns>如果此类的实例响应 <paramref name="sel"/>，则为 <see langword="true"/>；否则为 <see langword="false"/>。</returns>
    public bool RespondsToSelector(ObjCSel sel) => Native.ObjC.class_respondsToSelector(this, sel) != ObjCBool.NO;

    /// <summary>
    /// 向此类添加一个协议。
    /// </summary>
    /// <param name="protocol">要添加的协议。</param>
    /// <returns>如果添加成功，则为 <see langword="true"/>；否则为 <see langword="false"/>。</returns>
    public bool AddProtocol(ObjCProtocol protocol) => Native.ObjC.class_addProtocol(this, protocol) != ObjCBool.NO;

    /// <summary>
    /// 判断此类是否遵循指定的协议。
    /// </summary>
    /// <param name="protocol">要检查的协议。</param>
    /// <returns>如果此类遵循 <paramref name="protocol"/>，则为 <see langword="true"/>；否则为 <see langword="false"/>。</returns>
    public bool ConformsToProtocol(ObjCProtocol protocol) =>
        Native.ObjC.class_conformsToProtocol(this, protocol) != ObjCBool.NO;

    /// <summary>
    /// 获取类定义的版本号。
    /// </summary>
    public int Version => Native.ObjC.class_getVersion(this);

    /// <summary>
    /// 设置类定义的版本号。
    /// </summary>
    /// <param name="version">要设置的版本号。</param>
    public void SetVersion(int version) => Native.ObjC.class_setVersion(this, version);

    /// <summary>
    /// 获取此类来源的动态库名称。
    /// </summary>
    /// <returns>动态库名称；如果无法确定，则返回空字符串。</returns>
    public string ImageName
    {
        get
        {
            var ptr = Native.ObjC.class_getImageName(this);
            return ptr == nint.Zero ? string.Empty : Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
        }
    }

    /// <summary>
    /// 创建此类的一个实例。
    /// </summary>
    /// <param name="extraBytes">在实例变量之后额外分配的字节数。</param>
    /// <returns>新创建的实例。</returns>
    public ObjCId CreateInstance(nuint extraBytes = 0) =>
        Native.ObjC.class_createInstance(this, extraBytes);

    /// <summary>
    /// 设置此类的父类。
    /// </summary>
    /// <param name="newSuper">新的父类。</param>
    /// <returns>原来的父类。</returns>
    [Obsolete("class_setSuperclass is deprecated: not recommended.")]
    public ObjCClass SetSuperclass(ObjCClass newSuper) => Native.ObjC.class_setSuperclass(this, newSuper);

    private static void ValidateName(string name)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);

        if (name.Contains('\0'))
        {
            throw new ArgumentException("名称不能含有字符串终止符。", nameof(name));
        }
    }
}
