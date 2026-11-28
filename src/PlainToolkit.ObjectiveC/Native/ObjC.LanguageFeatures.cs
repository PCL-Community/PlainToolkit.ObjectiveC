using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    #region Using Objective-C Language Features

    /// <summary>
    /// <c>void objc_enumerationMutation(id obj);</c>
    /// <para>Inserted by the compiler when a mutation is detected during a foreach iteration.</para>
    /// </summary>
    /// <param name="obj">The object being enumerated when the mutation occurred.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_enumerationmutation(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void objc_enumerationMutation(ObjCId obj);

    /// <summary>
    /// <c>void objc_setEnumerationMutationHandler(void (*handler)(id));</c>
    /// <para>Sets the current mutation handler.</para>
    /// </summary>
    /// <param name="handler">A function pointer to the new mutation handler, or <c>NULL</c> to restore the default handler.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_setenumerationmutationhandler(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void objc_setEnumerationMutationHandler(nint handler);

    /// <summary>
    /// <c>IMP imp_implementationWithBlock(id block);</c>
    /// <para>Creates a pointer to a function that calls the specified block when the method is called.</para>
    /// </summary>
    /// <param name="block">The block that implements the method.</param>
    /// <returns>An <c>IMP</c> that calls <paramref name="block"/> when invoked.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/imp_implementationwithblock(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCImp imp_implementationWithBlock(ObjCId block);

    /// <summary>
    /// <c>id imp_getBlock(IMP anImp);</c>
    /// <para>Returns the block associated with an <c>IMP</c> that was created using <c>imp_implementationWithBlock</c>.</para>
    /// </summary>
    /// <param name="anImp">An <c>IMP</c> created by <c>imp_implementationWithBlock</c>.</param>
    /// <returns>The block associated with <paramref name="anImp"/>, or <c>NULL</c> if it was not created by <c>imp_implementationWithBlock</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/imp_getblock(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCId imp_getBlock(ObjCImp anImp);

    /// <summary>
    /// <c>BOOL imp_removeBlock(IMP anImp);</c>
    /// <para>Disassociates a block from an <c>IMP</c> that was created using <c>imp_implementationWithBlock</c>, and releases the copy of the block that was created.</para>
    /// </summary>
    /// <param name="anImp">An <c>IMP</c> created by <c>imp_implementationWithBlock</c>.</param>
    /// <returns><see cref="ObjCBool.YES"/> if the block was removed; otherwise, <see cref="ObjCBool.NO"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/imp_removeblock(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCBool imp_removeBlock(ObjCImp anImp);

    /// <summary>
    /// <c>id objc_loadWeak(id *location);</c>
    /// <para>Loads the object referenced by a weak pointer and returns it.</para>
    /// </summary>
    /// <param name="location">The address of a <c>__weak</c> variable.</param>
    /// <returns>The object referenced by <paramref name="location"/>, or <c>nil</c> if the weak pointer is <c>nil</c>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_loadweak(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCId objc_loadWeak(nint location);

    /// <summary>
    /// <c>id objc_storeWeak(id *location, id obj);</c>
    /// <para>Stores a new value in a <c>__weak</c> variable.</para>
    /// </summary>
    /// <param name="location">The address of a <c>__weak</c> variable.</param>
    /// <param name="obj">The object to store.</param>
    /// <returns>The previous value of <paramref name="location"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_storeweak(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCId objc_storeWeak(nint location, ObjCId obj);

    #endregion
}
