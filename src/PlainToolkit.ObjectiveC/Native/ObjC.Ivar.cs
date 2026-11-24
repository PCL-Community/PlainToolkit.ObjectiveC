using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    #region Working with Instance Variables

    /// <summary>
    /// <c>const char *ivar_getName(Ivar v);</c>
    /// <para>Returns the name of an instance variable.</para>
    /// </summary>
    /// <param name="v">An instance variable.</param>
    /// <returns>The name of <paramref name="v"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/ivar_getname(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint ivar_getName(ObjCIvar v);

    /// <summary>
    /// <c>const char *ivar_getTypeEncoding(Ivar v);</c>
    /// <para>Returns the type string of an instance variable.</para>
    /// </summary>
    /// <param name="v">An instance variable.</param>
    /// <returns>The type encoding of <paramref name="v"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/ivar_gettypeencoding(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint ivar_getTypeEncoding(ObjCIvar v);

    /// <summary>
    /// <c>ptrdiff_t ivar_getOffset(Ivar v);</c>
    /// <para>Returns the offset of an instance variable.</para>
    /// </summary>
    /// <param name="v">An instance variable.</param>
    /// <returns>The offset of <paramref name="v"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/ivar_getoffset(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint ivar_getOffset(ObjCIvar v);

    #endregion
}
