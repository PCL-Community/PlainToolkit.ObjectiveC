using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    #region Obtaining Class Definitions

    /// <summary>
    /// <c>int objc_getClassList(Class *buffer, int bufferCount);</c>
    /// <para>Obtains the list of registered class definitions.</para>
    /// </summary>
    /// <param name="buffer">An array of <c>Class</c> values. Pass <c>NULL</c> to obtain the number of classes without retrieving them.</param>
    /// <param name="bufferCount">The number of entries in <paramref name="buffer"/>.</param>
    /// <returns>The total number of registered classes, or the number of classes written to <paramref name="buffer"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_getclasslist(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int objc_getClassList(nint buffer, int bufferCount);

    /// <summary>
    /// <c>Class *objc_copyClassList(unsigned int *outCount);</c>
    /// <para>Creates and returns a list of pointers to all registered class definitions.</para>
    /// </summary>
    /// <param name="outCount">On return, contains the length of the returned array.</param>
    /// <returns>An array of <c>Class</c> pointers followed by a <c>NULL</c> terminator. Free it with <c>free()</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_copyclasslist(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint objc_copyClassList(out uint outCount);

    /// <summary>
    /// <c>Class objc_lookUpClass(const char *name);</c>
    /// <para>Returns the class definition of a specified class.</para>
    /// </summary>
    /// <param name="name">The name of the class to look up.</param>
    /// <returns>The class object for <paramref name="name"/>, or <c>Nil</c> if the class is not registered.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_lookupclass(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCClass objc_lookUpClass(nint name);

    /// <summary>
    /// <c>id objc_getClass(const char *name);</c>
    /// <para>Returns the class definition of a specified class.</para>
    /// </summary>
    /// <param name="name">The name of the class to look up.</param>
    /// <returns>The class object for <paramref name="name"/>, or <c>Nil</c> if the class is not registered.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_getclass(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCObject objc_getClass(nint name);

    /// <summary>
    /// <c>Class objc_getRequiredClass(const char *name);</c>
    /// <para>Returns the class definition of a specified class.</para>
    /// </summary>
    /// <param name="name">The name of the class to look up.</param>
    /// <returns>The class object for <paramref name="name"/>.</returns>
    /// <remarks>
    /// <para>If the class is not registered, the runtime aborts the process.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_getrequiredclass(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCClass objc_getRequiredClass(nint name);

    /// <summary>
    /// <c>id objc_getMetaClass(const char *name);</c>
    /// <para>Returns the metaclass definition of a specified class.</para>
    /// </summary>
    /// <param name="name">The name of the class whose metaclass you want to obtain.</param>
    /// <returns>The metaclass object for <paramref name="name"/>, or <c>Nil</c> if the class is not registered.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_getmetaclass(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCObject objc_getMetaClass(nint name);

    #endregion
}
