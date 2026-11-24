using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    #region Working with Selectors

    /// <summary>
    /// <c>const char *sel_getName(SEL sel);</c>
    /// <para>Returns the name of the method specified by a given selector.</para>
    /// </summary>
    /// <param name="sel">The selector to query.</param>
    /// <returns>The name of <paramref name="sel"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/sel_getname(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint sel_getName(ObjCSel sel);

    /// <summary>
    /// <c>SEL sel_registerName(const char *str);</c>
    /// <para>Registers a method with the Objective-C runtime system, maps the method name to a selector, and returns the selector value.</para>
    /// </summary>
    /// <param name="str">A pointer to a C string.</param>
    /// <returns>A selector representing the method name passed in <paramref name="str"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/sel_registername(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCSel sel_registerName(nint str);

    /// <summary>
    /// <c>SEL sel_getUid(const char *str);</c>
    /// <para>Registers a method name with the Objective-C runtime system.</para>
    /// </summary>
    /// <param name="str">A pointer to a C string.</param>
    /// <returns>A selector representing the method name passed in <paramref name="str"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/sel_getuid(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCSel sel_getUid(nint str);

    /// <summary>
    /// <c>BOOL sel_isEqual(SEL lhs, SEL rhs);</c>
    /// <para>Returns a Boolean value that indicates whether two selectors are equal.</para>
    /// </summary>
    /// <param name="lhs">The selector to compare with <paramref name="rhs"/>.</param>
    /// <param name="rhs">The selector to compare with <paramref name="lhs"/>.</param>
    /// <returns><see cref="ObjCBool.YES"/> if <paramref name="lhs"/> and <paramref name="rhs"/> are equal; otherwise, <see cref="ObjCBool.NO"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/sel_isequal(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCBool sel_isEqual(ObjCSel lhs, ObjCSel rhs);

    #endregion
}
