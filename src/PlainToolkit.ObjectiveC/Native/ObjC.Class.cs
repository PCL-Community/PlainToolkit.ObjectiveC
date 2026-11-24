using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    #region Working with Classes

    /// <summary>
    /// <c>const char *class_getName(Class cls);</c>
    /// <para>Returns the name of a class.</para>
    /// </summary>
    /// <param name="cls">A class object.</param>
    /// <returns>The name of the class, or the empty string if <paramref name="cls"/> is <c>Nil</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_getname(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint class_getName(ObjCClass cls);

    /// <summary>
    /// <c>Class class_getSuperclass(Class cls);</c>
    /// <para>Returns the superclass of a class.</para>
    /// </summary>
    /// <param name="cls">A class object.</param>
    /// <returns>
    /// The superclass of the class, or <c>Nil</c> if <paramref name="cls"/> is a root class,
    /// or <c>Nil</c> if <paramref name="cls"/> is <c>Nil</c>.
    /// </returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_getsuperclass(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCClass class_getSuperclass(ObjCClass cls);

    /// <summary>
    /// <c>Class class_setSuperclass(Class cls, Class newSuper);</c>
    /// <para>Sets the superclass of a given class.</para>
    /// </summary>
    /// <param name="cls">The class whose superclass you want to set.</param>
    /// <param name="newSuper">The new superclass for <paramref name="cls"/>.</param>
    /// <returns>The old superclass for <paramref name="cls"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_setsuperclass(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [Obsolete("class_setSuperclass is deprecated: not recommended.")]
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCClass class_setSuperclass(ObjCClass cls, ObjCClass newSuper);

    /// <summary>
    /// <c>BOOL class_isMetaClass(Class cls);</c>
    /// <para>Returns a Boolean value that indicates whether a class object is a metaclass.</para>
    /// </summary>
    /// <param name="cls">A class object.</param>
    /// <returns>
    /// <see cref="ObjCBool.YES"/> if <paramref name="cls"/> is a metaclass,
    /// <see cref="ObjCBool.NO"/> if <paramref name="cls"/> is a non-meta class or <c>Nil</c>.
    /// </returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_ismetaclass(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCBool class_isMetaClass(ObjCClass cls);

    /// <summary>
    /// <c>size_t class_getInstanceSize(Class cls);</c>
    /// <para>Returns the size of instances of a class.</para>
    /// </summary>
    /// <param name="cls">A class object.</param>
    /// <returns>The size in bytes of instances of the class <paramref name="cls"/>, or 0 if <paramref name="cls"/> is <c>Nil</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_getinstancesize(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nuint class_getInstanceSize(ObjCClass cls);

    /// <summary>
    /// <c>Ivar class_getInstanceVariable(Class cls, const char *name);</c>
    /// <para>Returns the <c>Ivar</c> for a specified instance variable of a given class.</para>
    /// </summary>
    /// <param name="cls">The class whose instance variable you wish to obtain.</param>
    /// <param name="name">The name of the instance variable definition to obtain.</param>
    /// <returns>A pointer to an <c>Ivar</c> data structure containing information about the instance variable specified by <paramref name="name"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_getinstancevariable(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint class_getInstanceVariable(ObjCClass cls, nint name);

    /// <summary>
    /// <c>Ivar class_getClassVariable(Class cls, const char *name);</c>
    /// <para>Returns the <c>Ivar</c> for a specified class variable of a given class.</para>
    /// </summary>
    /// <param name="cls">The class definition whose class variable you wish to obtain.</param>
    /// <param name="name">The name of the class variable definition to obtain.</param>
    /// <returns>A pointer to an <c>Ivar</c> data structure containing information about the class variable specified by <paramref name="name"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_getclassvariable(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint class_getClassVariable(ObjCClass cls, nint name);

    /// <summary>
    /// <c>BOOL class_addIvar(Class cls, const char *name, size_t size, uint8_t alignment, const char *types);</c>
    /// <para>Adds a new instance variable to a class.</para>
    /// </summary>
    /// <param name="cls">The class to which to add an instance variable.</param>
    /// <param name="name">The name of the instance variable.</param>
    /// <param name="size">The size of the instance variable.</param>
    /// <param name="alignment">The alignment of the instance variable, as a power of two.</param>
    /// <param name="types">The type encoding of the instance variable, or <c>NULL</c>.</param>
    /// <returns><see cref="ObjCBool.YES"/> if the instance variable was added successfully; otherwise, <see cref="ObjCBool.NO"/>.</returns>
    /// <remarks>
    /// <para>This function may only be called after <c>objc_allocateClassPair</c> and before <c>objc_registerClassPair</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_addivar(_:_:_:_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCBool class_addIvar(ObjCClass cls, nint name, nuint size, byte alignment, nint types);

    /// <summary>
    /// <c>Ivar *class_copyIvarList(Class cls, unsigned int *outCount);</c>
    /// <para>Describes the instance variables declared by a class.</para>
    /// </summary>
    /// <param name="cls">The class to inspect.</param>
    /// <param name="outCount">On return, contains the length of the returned array.</param>
    /// <returns>
    /// An array of <c>Ivar</c> pointers followed by a <c>NULL</c> terminator. You must free the array with <c>free()</c>.
    /// </returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_copyivarlist(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint class_copyIvarList(ObjCClass cls, out uint outCount);

    /// <summary>
    /// <c>const uint8_t *class_getIvarLayout(Class cls);</c>
    /// <para>Returns a description of the <c>Ivar</c> layout for a given class.</para>
    /// </summary>
    /// <param name="cls">The class to inspect.</param>
    /// <returns>A description of the <c>Ivar</c> layout for <paramref name="cls"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_getivarlayout(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint class_getIvarLayout(ObjCClass cls);

    /// <summary>
    /// <c>void class_setIvarLayout(Class cls, const uint8_t *layout);</c>
    /// <para>Sets the <c>Ivar</c> layout for a given class.</para>
    /// </summary>
    /// <param name="cls">The class to modify.</param>
    /// <param name="layout">The layout of the <c>Ivar</c>s for <paramref name="cls"/>.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_setivarlayout(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void class_setIvarLayout(ObjCClass cls, nint layout);

    /// <summary>
    /// <c>const uint8_t *class_getWeakIvarLayout(Class cls);</c>
    /// <para>Returns a description of the layout of weak <c>Ivar</c>s for a given class.</para>
    /// </summary>
    /// <param name="cls">The class to inspect.</param>
    /// <returns>A description of the layout of the weak <c>Ivar</c>s for <paramref name="cls"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_getweakivarlayout(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint class_getWeakIvarLayout(ObjCClass cls);

    /// <summary>
    /// <c>void class_setWeakIvarLayout(Class cls, const uint8_t *layout);</c>
    /// <para>Sets the layout for weak <c>Ivar</c>s for a given class.</para>
    /// </summary>
    /// <param name="cls">The class to modify.</param>
    /// <param name="layout">The layout of the weak <c>Ivar</c>s for <paramref name="cls"/>.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_setweakivarlayout(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void class_setWeakIvarLayout(ObjCClass cls, nint layout);

    /// <summary>
    /// <c>objc_property_t class_getProperty(Class cls, const char *name);</c>
    /// <para>Returns a property with a given name of a given class.</para>
    /// </summary>
    /// <param name="cls">The class you want to inspect.</param>
    /// <param name="name">The name of the property you want to obtain.</param>
    /// <returns>A pointer of type <c>objc_property_t</c>, or <c>NULL</c> if not found.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_getproperty(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint class_getProperty(ObjCClass cls, nint name);

    /// <summary>
    /// <c>objc_property_t *class_copyPropertyList(Class cls, unsigned int *outCount);</c>
    /// <para>Describes the properties declared by a class.</para>
    /// </summary>
    /// <param name="cls">The class you want to inspect.</param>
    /// <param name="outCount">On return, contains the length of the returned array.</param>
    /// <returns>An array of <c>objc_property_t</c> pointers followed by a <c>NULL</c> terminator. Free it with <c>free()</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_copypropertylist(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint class_copyPropertyList(ObjCClass cls, out uint outCount);

    /// <summary>
    /// <c>BOOL class_addMethod(Class cls, SEL name, IMP imp, const char *types);</c>
    /// <para>Adds a new method to a class with a given name and implementation.</para>
    /// </summary>
    /// <param name="cls">The class to which to add a method.</param>
    /// <param name="name">A selector that specifies the name of the method being added.</param>
    /// <param name="imp">The implementation of the new method.</param>
    /// <param name="types">The type encoding of the method, or <c>NULL</c>.</param>
    /// <returns><see cref="ObjCBool.YES"/> if the method was added successfully; otherwise, <see cref="ObjCBool.NO"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_addmethod(_:_:_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCBool class_addMethod(ObjCClass cls, ObjCSel name, ObjCImp imp, nint types);

    /// <summary>
    /// <c>Method class_getInstanceMethod(Class cls, SEL name);</c>
    /// <para>Returns a specified instance method for a given class.</para>
    /// </summary>
    /// <param name="cls">The class you want to inspect.</param>
    /// <param name="name">The selector of the method you want to retrieve.</param>
    /// <returns>The method that corresponds to the implementation of the selector specified by <paramref name="name"/> for the class specified by <paramref name="cls"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_getinstancemethod(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCMethod class_getInstanceMethod(ObjCClass cls, ObjCSel name);

    /// <summary>
    /// <c>Method class_getClassMethod(Class cls, SEL name);</c>
    /// <para>Returns a pointer to the data structure describing a given class method for a given class.</para>
    /// </summary>
    /// <param name="cls">A pointer to a class definition.</param>
    /// <param name="name">The selector of the class method you want to retrieve.</param>
    /// <returns>The method that corresponds to the implementation of the selector specified by <paramref name="name"/> for the class specified by <paramref name="cls"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_getclassmethod(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCMethod class_getClassMethod(ObjCClass cls, ObjCSel name);

    /// <summary>
    /// <c>Method *class_copyMethodList(Class cls, unsigned int *outCount);</c>
    /// <para>Describes the instance methods implemented by a class.</para>
    /// </summary>
    /// <param name="cls">The class you want to inspect.</param>
    /// <param name="outCount">On return, contains the length of the returned array.</param>
    /// <returns>An array of <c>Method</c> pointers followed by a <c>NULL</c> terminator. Free it with <c>free()</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_copymethodlist(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint class_copyMethodList(ObjCClass cls, out uint outCount);

    /// <summary>
    /// <c>IMP class_replaceMethod(Class cls, SEL name, IMP imp, const char *types);</c>
    /// <para>Replaces the implementation of a method for a given class.</para>
    /// </summary>
    /// <param name="cls">The class you want to modify.</param>
    /// <param name="name">A selector that identifies the method whose implementation you want to replace.</param>
    /// <param name="imp">The new implementation for the method.</param>
    /// <param name="types">The type encoding of the method, or <c>NULL</c>.</param>
    /// <returns>The previous implementation of the method, or <c>NULL</c> if the method did not exist.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_replacemethod(_:_:_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCImp class_replaceMethod(ObjCClass cls, ObjCSel name, ObjCImp imp, nint types);

    /// <summary>
    /// <c>IMP class_getMethodImplementation(Class cls, SEL name);</c>
    /// <para>Returns the function pointer that would be called if a particular message were sent to an instance of a class.</para>
    /// </summary>
    /// <param name="cls">The class you want to inspect.</param>
    /// <param name="name">A selector.</param>
    /// <returns>The function pointer that would be called if a message with the selector <paramref name="name"/> were sent to an instance of <paramref name="cls"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_getmethodimplementation(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCImp class_getMethodImplementation(ObjCClass cls, ObjCSel name);

    /// <summary>
    /// <c>IMP class_getMethodImplementation_stret(Class cls, SEL name);</c>
    /// <para>Returns the function pointer that would be called if a particular message were sent to an instance of a class.</para>
    /// </summary>
    /// <param name="cls">The class you want to inspect.</param>
    /// <param name="name">A selector.</param>
    /// <returns>The function pointer used for methods that return structures.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_getmethodimplementation_stret(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCImp class_getMethodImplementation_stret(ObjCClass cls, ObjCSel name);

    /// <summary>
    /// <c>BOOL class_respondsToSelector(Class cls, SEL sel);</c>
    /// <para>Returns a Boolean value that indicates whether instances of a class respond to a particular selector.</para>
    /// </summary>
    /// <param name="cls">The class you want to inspect.</param>
    /// <param name="sel">A selector.</param>
    /// <returns><see cref="ObjCBool.YES"/> if instances of <paramref name="cls"/> respond to <paramref name="sel"/>; otherwise, <see cref="ObjCBool.NO"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_respondstoselector(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCBool class_respondsToSelector(ObjCClass cls, ObjCSel sel);

    /// <summary>
    /// <c>BOOL class_addProtocol(Class cls, Protocol *protocol);</c>
    /// <para>Adds a protocol to a class.</para>
    /// </summary>
    /// <param name="cls">The class to modify.</param>
    /// <param name="protocol">The protocol to add.</param>
    /// <returns><see cref="ObjCBool.YES"/> if the protocol was added successfully; otherwise, <see cref="ObjCBool.NO"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_addprotocol(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCBool class_addProtocol(ObjCClass cls, ObjCProtocol protocol);

    /// <summary>
    /// <c>BOOL class_addProperty(Class cls, const char *name, const objc_property_attribute_t *attributes, unsigned int attributeCount);</c>
    /// <para>Adds a property to a class.</para>
    /// </summary>
    /// <param name="cls">The class to modify.</param>
    /// <param name="name">The name of the property.</param>
    /// <param name="attributes">An array of property attributes.</param>
    /// <param name="attributeCount">The number of attributes in <paramref name="attributes"/>.</param>
    /// <returns><see cref="ObjCBool.YES"/> if the property was added successfully; otherwise, <see cref="ObjCBool.NO"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_addproperty(_:_:_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCBool class_addProperty(ObjCClass cls, nint name, nint attributes, uint attributeCount);

    /// <summary>
    /// <c>void class_replaceProperty(Class cls, const char *name, const objc_property_attribute_t *attributes, unsigned int attributeCount);</c>
    /// <para>Replace a property of a class.</para>
    /// </summary>
    /// <param name="cls">The class to modify.</param>
    /// <param name="name">The name of the property.</param>
    /// <param name="attributes">An array of property attributes.</param>
    /// <param name="attributeCount">The number of attributes in <paramref name="attributes"/>.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_replaceproperty(_:_:_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void class_replaceProperty(ObjCClass cls, nint name, nint attributes, uint attributeCount);

    /// <summary>
    /// <c>BOOL class_conformsToProtocol(Class cls, Protocol *protocol);</c>
    /// <para>Returns a Boolean value that indicates whether a class conforms to a given protocol.</para>
    /// </summary>
    /// <param name="cls">The class you want to inspect.</param>
    /// <param name="protocol">A protocol.</param>
    /// <returns><see cref="ObjCBool.YES"/> if <paramref name="cls"/> conforms to <paramref name="protocol"/>; otherwise, <see cref="ObjCBool.NO"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_conformstoprotocol(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCBool class_conformsToProtocol(ObjCClass cls, ObjCProtocol protocol);

    /// <summary>
    /// <c>Protocol **class_copyProtocolList(Class cls, unsigned int *outCount);</c>
    /// <para>Describes the protocols adopted by a class.</para>
    /// </summary>
    /// <param name="cls">The class you want to inspect.</param>
    /// <param name="outCount">On return, contains the length of the returned array.</param>
    /// <returns>An array of <c>Protocol</c> pointers followed by a <c>NULL</c> terminator. Free it with <c>free()</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_copyprotocollist(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint class_copyProtocolList(ObjCClass cls, out uint outCount);

    /// <summary>
    /// <c>int class_getVersion(Class cls);</c>
    /// <para>Returns the version number of a class definition.</para>
    /// </summary>
    /// <param name="cls">A pointer to a class definition.</param>
    /// <returns>The version number of the class definition <paramref name="cls"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_getversion(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int class_getVersion(ObjCClass cls);

    /// <summary>
    /// <c>void class_setVersion(Class cls, int version);</c>
    /// <para>Sets the version number of a class definition.</para>
    /// </summary>
    /// <param name="cls">A pointer to a class definition.</param>
    /// <param name="version">The version number to set.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/class_setversion(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void class_setVersion(ObjCClass cls, int version);

    /// <summary>
    /// <c>void objc_setFutureClass(Class cls, const char *name);</c>
    /// <para>Used by CoreFoundation's toll-free bridging.</para>
    /// </summary>
    /// <param name="cls">The class to set.</param>
    /// <param name="name">The name of the class.</param>
    /// <remarks>
    /// <para>Do not call this function yourself.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/1808430-objc_setfutureclass?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void objc_setFutureClass(ObjCClass cls, nint name);

    #endregion
}
