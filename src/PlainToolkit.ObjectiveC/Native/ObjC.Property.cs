using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    #region Working with Properties

    /// <summary>
    /// <c>const char *property_getName(objc_property_t property);</c>
    /// <para>Returns the name of a property.</para>
    /// </summary>
    /// <param name="property">A property.</param>
    /// <returns>The name of <paramref name="property"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/property_getname(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint property_getName(ObjCProperty property);

    /// <summary>
    /// <c>const char *property_getAttributes(objc_property_t property);</c>
    /// <para>Returns the attribute string of a property.</para>
    /// </summary>
    /// <param name="property">A property.</param>
    /// <returns>The attribute string of <paramref name="property"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/property_getattributes(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint property_getAttributes(ObjCProperty property);

    /// <summary>
    /// <c>char *property_copyAttributeValue(objc_property_t property, const char *attributeName);</c>
    /// <para>Returns the value of a property attribute given the attribute name.</para>
    /// </summary>
    /// <param name="property">A property.</param>
    /// <param name="attributeName">The name of the attribute whose value you want to obtain.</param>
    /// <returns>The value of the attribute, or <c>NULL</c> if the attribute is not present. Free it with <c>free()</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/property_copyattributevalue(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint property_copyAttributeValue(ObjCProperty property, nint attributeName);

    /// <summary>
    /// <c>objc_property_attribute_t *property_copyAttributeList(objc_property_t property, unsigned int *outCount);</c>
    /// <para>Returns an array of property attributes for a given property.</para>
    /// </summary>
    /// <param name="property">A property.</param>
    /// <param name="outCount">On return, contains the number of attributes in the returned array.</param>
    /// <returns>An array of <c>objc_property_attribute_t</c> structures followed by a <c>NULL</c> terminator. Free it with <c>free()</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/property_copyattributelist(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint property_copyAttributeList(ObjCProperty property, out uint outCount);

    #endregion
}
