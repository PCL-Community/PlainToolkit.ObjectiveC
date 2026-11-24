using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    #region Working with Protocols

    /// <summary>
    /// <c>Protocol *objc_getProtocol(const char *name);</c>
    /// <para>Returns a specified protocol.</para>
    /// </summary>
    /// <param name="name">The name of a protocol.</param>
    /// <returns>The protocol named <paramref name="name"/>, or <c>NULL</c> if no protocol by that name is currently registered.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_getprotocol(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCProtocol objc_getProtocol(nint name);

    /// <summary>
    /// <c>Protocol **objc_copyProtocolList(unsigned int *outCount);</c>
    /// <para>Returns an array of all the protocols known to the runtime.</para>
    /// </summary>
    /// <param name="outCount">On return, contains the number of protocols in the returned array.</param>
    /// <returns>An array of <c>Protocol</c> pointers followed by a <c>NULL</c> terminator. Free it with <c>free()</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_copyprotocollist(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint objc_copyProtocolList(out uint outCount);

    /// <summary>
    /// <c>Protocol *objc_allocateProtocol(const char *name);</c>
    /// <para>Creates a new protocol instance.</para>
    /// </summary>
    /// <param name="name">The name of the protocol to create.</param>
    /// <returns>A new protocol, or <c>NULL</c> if a protocol with that name already exists.</returns>
    /// <remarks>
    /// <para>You must call <c>objc_registerProtocol</c> before using the protocol.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_allocateprotocol(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCProtocol objc_allocateProtocol(nint name);

    /// <summary>
    /// <c>void objc_registerProtocol(Protocol *proto);</c>
    /// <para>Registers a newly created protocol with the Objective-C runtime.</para>
    /// </summary>
    /// <param name="proto">The protocol to register.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_registerprotocol(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void objc_registerProtocol(ObjCProtocol proto);

    /// <summary>
    /// <c>void protocol_addMethodDescription(Protocol *proto, SEL name, const char *types, BOOL isRequiredMethod, BOOL isInstanceMethod);</c>
    /// <para>Adds a method to a protocol.</para>
    /// </summary>
    /// <param name="proto">The protocol to modify.</param>
    /// <param name="name">The selector of the method to add.</param>
    /// <param name="types">The type encoding of the method.</param>
    /// <param name="isRequiredMethod"><see cref="ObjCBool.YES"/> if the method is required; <see cref="ObjCBool.NO"/> if it is optional.</param>
    /// <param name="isInstanceMethod"><see cref="ObjCBool.YES"/> if the method is an instance method; <see cref="ObjCBool.NO"/> if it is a class method.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/protocol_addmethoddescription(_:_:_:_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void protocol_addMethodDescription(
        ObjCProtocol proto, ObjCSel name, nint types, ObjCBool isRequiredMethod, ObjCBool isInstanceMethod);

    /// <summary>
    /// <c>void protocol_addProtocol(Protocol *proto, Protocol *addition);</c>
    /// <para>Adds a registered protocol to another protocol that is under construction.</para>
    /// </summary>
    /// <param name="proto">The protocol under construction.</param>
    /// <param name="addition">The protocol to add.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/protocol_addprotocol(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void protocol_addProtocol(ObjCProtocol proto, ObjCProtocol addition);

    /// <summary>
    /// <c>void protocol_addProperty(Protocol *proto, const char *name, const objc_property_attribute_t *attributes, unsigned int attributeCount, BOOL isRequiredProperty, BOOL isInstanceProperty);</c>
    /// <para>Adds a property to a protocol that is under construction.</para>
    /// </summary>
    /// <param name="proto">The protocol under construction.</param>
    /// <param name="name">The name of the property.</param>
    /// <param name="attributes">An array of property attributes.</param>
    /// <param name="attributeCount">The number of attributes in <paramref name="attributes"/>.</param>
    /// <param name="isRequiredProperty"><see cref="ObjCBool.YES"/> if the property is required; <see cref="ObjCBool.NO"/> if it is optional.</param>
    /// <param name="isInstanceProperty"><see cref="ObjCBool.YES"/> if the property is an instance property; <see cref="ObjCBool.NO"/> if it is a class property.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/protocol_addproperty(_:_:_:_:_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void protocol_addProperty(
        ObjCProtocol proto, nint name, nint attributes, uint attributeCount,
        ObjCBool isRequiredProperty, ObjCBool isInstanceProperty);

    /// <summary>
    /// <c>const char *protocol_getName(Protocol *proto);</c>
    /// <para>Returns the name of a protocol.</para>
    /// </summary>
    /// <param name="proto">A protocol.</param>
    /// <returns>The name of <paramref name="proto"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/protocol_getname(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint protocol_getName(ObjCProtocol proto);

    /// <summary>
    /// <c>BOOL protocol_isEqual(Protocol *proto, Protocol *other);</c>
    /// <para>Returns a Boolean value that indicates whether two protocols are equal.</para>
    /// </summary>
    /// <param name="proto">A protocol.</param>
    /// <param name="other">Another protocol.</param>
    /// <returns><see cref="ObjCBool.YES"/> if <paramref name="proto"/> and <paramref name="other"/> are equal; otherwise, <see cref="ObjCBool.NO"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/protocol_isequal(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCBool protocol_isEqual(ObjCProtocol proto, ObjCProtocol other);

    /// <summary>
    /// <c>struct objc_method_description *protocol_copyMethodDescriptionList(Protocol *proto, BOOL isRequiredMethod, BOOL isInstanceMethod, unsigned int *outCount);</c>
    /// <para>Returns an array of method descriptions of methods meeting a given specification for a given protocol.</para>
    /// </summary>
    /// <param name="proto">A protocol.</param>
    /// <param name="isRequiredMethod"><see cref="ObjCBool.YES"/> to include required methods; <see cref="ObjCBool.NO"/> to include optional methods.</param>
    /// <param name="isInstanceMethod"><see cref="ObjCBool.YES"/> to include instance methods; <see cref="ObjCBool.NO"/> to include class methods.</param>
    /// <param name="outCount">On return, contains the number of method descriptions in the returned array.</param>
    /// <returns>An array of method descriptions followed by a <c>NULL</c> terminator. Free it with <c>free()</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/protocol_copymethoddescriptionlist(_:_:_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint protocol_copyMethodDescriptionList(
        ObjCProtocol proto, ObjCBool isRequiredMethod, ObjCBool isInstanceMethod, out uint outCount);

    /// <summary>
    /// <c>struct objc_method_description protocol_getMethodDescription(Protocol *proto, SEL aSel, BOOL isRequiredMethod, BOOL isInstanceMethod);</c>
    /// <para>Returns a method description structure for a specified method of a given protocol.</para>
    /// </summary>
    /// <param name="proto">A protocol.</param>
    /// <param name="aSel">A selector.</param>
    /// <param name="isRequiredMethod"><see cref="ObjCBool.YES"/> to search required methods; <see cref="ObjCBool.NO"/> to search optional methods.</param>
    /// <param name="isInstanceMethod"><see cref="ObjCBool.YES"/> to search instance methods; <see cref="ObjCBool.NO"/> to search class methods.</param>
    /// <returns>An <c>objc_method_description</c> structure that describes the method, or a structure with <c>NULL</c> fields if not found.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/protocol_getmethoddescription(_:_:_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCMethodDescription protocol_getMethodDescription(
        ObjCProtocol proto, ObjCSel aSel, ObjCBool isRequiredMethod, ObjCBool isInstanceMethod);

    /// <summary>
    /// <c>objc_property_t *protocol_copyPropertyList(Protocol *proto, unsigned int *outCount);</c>
    /// <para>Returns an array of the properties declared by a protocol.</para>
    /// </summary>
    /// <param name="proto">A protocol.</param>
    /// <param name="outCount">On return, contains the number of properties in the returned array.</param>
    /// <returns>An array of <c>objc_property_t</c> pointers followed by a <c>NULL</c> terminator. Free it with <c>free()</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/protocol_copypropertylist(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint protocol_copyPropertyList(ObjCProtocol proto, out uint outCount);

    /// <summary>
    /// <c>objc_property_t protocol_getProperty(Protocol *proto, const char *name, BOOL isRequiredProperty, BOOL isInstanceProperty);</c>
    /// <para>Returns the specified property of a given protocol.</para>
    /// </summary>
    /// <param name="proto">A protocol.</param>
    /// <param name="name">The name of the property to obtain.</param>
    /// <param name="isRequiredProperty"><see cref="ObjCBool.YES"/> to search required properties; <see cref="ObjCBool.NO"/> to search optional properties.</param>
    /// <param name="isInstanceProperty"><see cref="ObjCBool.YES"/> to search instance properties; <see cref="ObjCBool.NO"/> to search class properties.</param>
    /// <returns>The property, or <c>NULL</c> if not found.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/protocol_getproperty(_:_:_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCProperty protocol_getProperty(
        ObjCProtocol proto, nint name, ObjCBool isRequiredProperty, ObjCBool isInstanceProperty);

    /// <summary>
    /// <c>Protocol **protocol_copyProtocolList(Protocol *proto, unsigned int *outCount);</c>
    /// <para>Returns an array of the protocols adopted by a protocol.</para>
    /// </summary>
    /// <param name="proto">A protocol.</param>
    /// <param name="outCount">On return, contains the number of protocols in the returned array.</param>
    /// <returns>An array of <c>Protocol</c> pointers followed by a <c>NULL</c> terminator. Free it with <c>free()</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/protocol_copyprotocollist(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint protocol_copyProtocolList(ObjCProtocol proto, out uint outCount);

    /// <summary>
    /// <c>BOOL protocol_conformsToProtocol(Protocol *proto, Protocol *other);</c>
    /// <para>Returns a Boolean value that indicates whether one protocol conforms to another protocol.</para>
    /// </summary>
    /// <param name="proto">A protocol.</param>
    /// <param name="other">Another protocol.</param>
    /// <returns><see cref="ObjCBool.YES"/> if <paramref name="proto"/> conforms to <paramref name="other"/>; otherwise, <see cref="ObjCBool.NO"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/protocol_conformstoprotocol(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCBool protocol_conformsToProtocol(ObjCProtocol proto, ObjCProtocol other);

    #endregion
}
