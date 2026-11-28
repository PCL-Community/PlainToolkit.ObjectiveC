using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    private const string Library = "/usr/lib/libobjc.A.dylib";
    
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
    /// <c>const char *object_getClassName(id obj);</c>
    /// <para>Returns the class name of a given object.</para>
    /// </summary>
    /// <param name="obj">An object.</param>
    /// <returns>The name of the class of <paramref name="obj"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/object_getclassname(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint object_getClassName(ObjCObject obj);
    
    /// <summary>
    /// <c>void *object_getIndexedIvars(id obj);</c>
    /// <para>Returns a pointer to any extra bytes allocated with an instance given object.</para>
    /// </summary>
    /// <param name="obj">An object.</param>
    /// <returns>A pointer to any extra bytes allocated with <paramref name="obj"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/object_getindexedivars(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint object_getIndexedIvars(ObjCObject obj);
    
    /// <summary>
    /// <c>BOOL sel_isMapped(SEL sel);</c>
    /// <para>Identifies a selector as being valid or invalid.</para>
    /// </summary>
    /// <param name="sel">The selector you want to identify.</param>
    /// <returns>YES if selector is valid and has a function implementation, NO otherwise.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/sel_ismapped(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCBool sel_isMapped(ObjCSel sel);
    
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
}
