using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    #region Working with Libraries

    /// <summary>
    /// <c>const char **objc_copyImageNames(unsigned int *outCount);</c>
    /// <para>Returns the names of all the loaded Objective-C frameworks and dynamic libraries.</para>
    /// </summary>
    /// <param name="outCount">On return, contains the number of names in the returned array.</param>
    /// <returns>An array of C strings followed by a <c>NULL</c> terminator. Free it with <c>free()</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_copyimagenames(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint objc_copyImageNames(out uint outCount);

    /// <summary>
    /// <c>const char *class_getImageName(Class cls);</c>
    /// <para>Returns the name of the dynamic library a class originated from.</para>
    /// </summary>
    /// <param name="cls">The class you want to inspect.</param>
    /// <returns>A C string containing the name of the library, or <c>NULL</c> if the class is not in a dynamic library.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_getimagename(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint class_getImageName(ObjCClass cls);

    /// <summary>
    /// <c>const char **objc_copyClassNamesForImage(const char *image, unsigned int *outCount);</c>
    /// <para>Returns the names of all the classes within a specified library or framework.</para>
    /// </summary>
    /// <param name="image">The library or framework to inspect.</param>
    /// <param name="outCount">On return, contains the number of names in the returned array.</param>
    /// <returns>An array of C strings followed by a <c>NULL</c> terminator. Free it with <c>free()</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_copyclassnamesforimage(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint objc_copyClassNamesForImage(nint image, out uint outCount);

    #endregion
}
