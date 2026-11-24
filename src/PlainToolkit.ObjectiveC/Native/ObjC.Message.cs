using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    #region Sending Messages

    /// <summary>
    /// <c>id objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a simple return value to an instance of a class.</para>
    /// </summary>
    /// <param name="id">The receiver of the message.</param>
    /// <param name="sel">The selector of the method that handles the message.</param>
    /// <returns>The return value of the method.</returns>
    /// <remarks>
    /// <para>
    /// This declaration only describes the two fixed arguments. The function is variadic and its real
    /// signature depends on the selector; use a typed function pointer to call it.
    /// </para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint objc_msgSend(nint id, nint sel);

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>
    /// This function is used on the i386 platform. The declared return type is <c>void</c> because the
    /// function is variadic; cast it to a function pointer with the actual return type before calling it.
    /// </para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void objc_msgSend_fpret(ObjCObject self, ObjCSel op);

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void objc_msgSend_stret(nint stretAddr, ObjCObject self, ObjCSel op);

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a simple return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the two fixed arguments; the function is variadic.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void objc_msgSendSuper(nint super, ObjCSel op);

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void objc_msgSendSuper_stret(nint stretAddr, nint super, ObjCSel op);

    #endregion
}
