using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    #region Working with Methods

    /// <summary>
    /// <c>SEL method_getName(Method m);</c>
    /// <para>Returns the name of a method.</para>
    /// </summary>
    /// <param name="m">A method.</param>
    /// <returns>The selector that represents the name of <paramref name="m"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/method_getname(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCSel method_getName(ObjCMethod m);

    /// <summary>
    /// <c>IMP method_getImplementation(Method m);</c>
    /// <para>Returns the implementation of a method.</para>
    /// </summary>
    /// <param name="m">A method.</param>
    /// <returns>The implementation of <paramref name="m"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/method_getimplementation(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCImp method_getImplementation(ObjCMethod m);

    /// <summary>
    /// <c>const char *method_getTypeEncoding(Method m);</c>
    /// <para>Returns a string describing a method's parameter and return types.</para>
    /// </summary>
    /// <param name="m">A method.</param>
    /// <returns>The type encoding of <paramref name="m"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/method_gettypeencoding(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint method_getTypeEncoding(ObjCMethod m);

    /// <summary>
    /// <c>char *method_copyReturnType(Method m);</c>
    /// <para>Returns a string describing a method's return type.</para>
    /// </summary>
    /// <param name="m">A method.</param>
    /// <returns>A C string describing the return type of <paramref name="m"/>. Free it with <c>free()</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/method_copyreturntype(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint method_copyReturnType(ObjCMethod m);

    /// <summary>
    /// <c>char *method_copyArgumentType(Method m, unsigned int index);</c>
    /// <para>Returns a string describing a single parameter type of a method.</para>
    /// </summary>
    /// <param name="m">A method.</param>
    /// <param name="index">The index of the parameter to inspect.</param>
    /// <returns>A C string describing the parameter type. Free it with <c>free()</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/method_copyargumenttype(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint method_copyArgumentType(ObjCMethod m, uint index);

    /// <summary>
    /// <c>void method_getReturnType(Method m, char *dst, size_t dst_len);</c>
    /// <para>Returns by reference a string describing a method's return type.</para>
    /// </summary>
    /// <param name="m">A method.</param>
    /// <param name="dst">A buffer to receive the return type string.</param>
    /// <param name="dstLen">The length of <paramref name="dst"/>.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/method_getreturntype(_:_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void method_getReturnType(ObjCMethod m, nint dst, nuint dstLen);

    /// <summary>
    /// <c>unsigned int method_getNumberOfArguments(Method m);</c>
    /// <para>Returns the number of arguments accepted by a method.</para>
    /// </summary>
    /// <param name="m">A method.</param>
    /// <returns>The number of arguments accepted by <paramref name="m"/>, including <c>self</c> and <c>_cmd</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/method_getnumberofarguments(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint method_getNumberOfArguments(ObjCMethod m);

    /// <summary>
    /// <c>void method_getArgumentType(Method m, unsigned int index, char *dst, size_t dst_len);</c>
    /// <para>Returns by reference a string describing a single parameter type of a method.</para>
    /// </summary>
    /// <param name="m">A method.</param>
    /// <param name="index">The index of the parameter to inspect.</param>
    /// <param name="dst">A buffer to receive the argument type string.</param>
    /// <param name="dstLen">The length of <paramref name="dst"/>.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/method_getargumenttype(_:_:_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void method_getArgumentType(ObjCMethod m, uint index, nint dst, nuint dstLen);

    /// <summary>
    /// <c>struct objc_method_description *method_getDescription(Method m);</c>
    /// <para>Returns a method description structure for a specified method.</para>
    /// </summary>
    /// <param name="m">A method.</param>
    /// <returns>A pointer to a method description structure for <paramref name="m"/>.</returns>
    /// <remarks>
    /// <para>Deprecated: use <c>method_getName</c> and <c>method_getTypeEncoding</c> instead.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/method_getdescription(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [Obsolete("Use method_getName and method_getTypeEncoding.")]
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint method_getDescription(ObjCMethod m);

    /// <summary>
    /// <c>IMP method_setImplementation(Method m, IMP imp);</c>
    /// <para>Sets the implementation of a method.</para>
    /// </summary>
    /// <param name="m">The method for which to set an implementation.</param>
    /// <param name="imp">The implementation to set.</param>
    /// <returns>The previous implementation of <paramref name="m"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/method_setimplementation(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCImp method_setImplementation(ObjCMethod m, ObjCImp imp);

    /// <summary>
    /// <c>void method_exchangeImplementations(Method m1, Method m2);</c>
    /// <para>Exchanges the implementations of two methods.</para>
    /// </summary>
    /// <param name="m1">A method.</param>
    /// <param name="m2">Another method.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/method_exchangeimplementations(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void method_exchangeImplementations(ObjCMethod m1, ObjCMethod m2);

    #endregion
}
