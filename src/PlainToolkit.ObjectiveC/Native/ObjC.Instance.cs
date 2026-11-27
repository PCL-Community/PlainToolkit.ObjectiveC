using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    #region Instantiating Classes

    /// <summary>
    /// <c>id class_createInstance(Class cls, size_t extraBytes);</c>
    /// <para>Creates an instance of a class, allocating memory for the class in the default malloc memory zone.</para>
    /// </summary>
    /// <param name="cls">The class that you want to allocate an instance of.</param>
    /// <param name="extraBytes">The number of extra bytes to allocate, in addition to the instance variables of the class.</param>
    /// <returns>An instance of the class <paramref name="cls"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_createinstance(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCObject class_createInstance(ObjCClass cls, nuint extraBytes);

    #endregion

    #region Working with Instances

    /// <summary>
    /// <c>id object_getIvar(id obj, Ivar ivar);</c>
    /// <para>Reads the value of an instance variable in an object.</para>
    /// </summary>
    /// <param name="obj">The object containing the instance variable whose value you want to read.</param>
    /// <param name="ivar">The Ivar structure describing the instance variable whose value you want to read.</param>
    /// <returns>The value of the instance variable specified by <paramref name="ivar"/>, or <c>nil</c> if <paramref name="obj"/> is <c>nil</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/object_getivar(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCObject object_getIvar(ObjCObject obj, ObjCIvar ivar);

    /// <summary>
    /// <c>void object_setIvar(id obj, Ivar ivar, id value);</c>
    /// <para>Sets the value of an instance variable in an object.</para>
    /// </summary>
    /// <param name="obj">The object containing the instance variable whose value you want to set.</param>
    /// <param name="ivar">The Ivar structure describing the instance variable whose value you want to set.</param>
    /// <param name="value">The new value for the instance variable.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/object_setivar(_:_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void object_setIvar(ObjCObject obj, ObjCIvar ivar, ObjCObject value);

    /// <summary>
    /// <c>Class object_getClass(id obj);</c>
    /// <para>Returns the class of an object.</para>
    /// </summary>
    /// <param name="obj">The object you want to inspect.</param>
    /// <returns>The class of <paramref name="obj"/>, or <c>Nil</c> if <paramref name="obj"/> is <c>nil</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/object_getclass(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCClass object_getClass(ObjCObject obj);

    /// <summary>
    /// <c>Class object_setClass(id obj, Class cls);</c>
    /// <para>Sets the class of an object.</para>
    /// </summary>
    /// <param name="obj">The object to modify.</param>
    /// <param name="cls">The new class for <paramref name="obj"/>.</param>
    /// <returns>The previous class of <paramref name="obj"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/object_setclass(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCClass object_setClass(ObjCObject obj, ObjCClass cls);

    #endregion
}
