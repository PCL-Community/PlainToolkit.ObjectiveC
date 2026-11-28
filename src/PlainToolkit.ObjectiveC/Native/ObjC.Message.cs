using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;
// ReSharper disable InconsistentNaming
// ReSharper disable InvalidXmlDocComment

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    #region Sending Messages
    
    private static readonly Lazy<nint> _objcLibrary = new(() =>
    {
        var libraryHandle = NativeLibrary.Load(Library);
        AppDomain.CurrentDomain.ProcessExit += (_, _) => NativeLibrary.Free(libraryHandle);
        return libraryHandle;
    });

    private static nint GetObjCExport(string name) => NativeLibrary.GetExport(_objcLibrary.Value, name);

    private static readonly Lazy<nint> _objc_msgSend = new(() => GetObjCExport("objc_msgSend"));
    private static readonly Lazy<nint> _objc_msgSend_fpret = new(() => GetObjCExport("objc_msgSend_fpret"));
    private static readonly Lazy<nint> _objc_msgSend_stret = new(() => GetObjCExport("objc_msgSend_stret"));
    private static readonly Lazy<nint> _objc_msgSendSuper = new(() => GetObjCExport("objc_msgSendSuper"));
    private static readonly Lazy<nint> _objc_msgSendSuper_stret = new(() => GetObjCExport("objc_msgSendSuper_stret"));

    #region objc_msgSend

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend(
        ObjCId self, ObjCSel op)
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, void>) _objc_msgSend.Value;
        func(self, op);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<TResult>(
        ObjCId self, ObjCSel op)
        where TResult : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, TResult>) _objc_msgSend.Value;
        return func(self, op);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1>(
        ObjCId self, ObjCSel op, T1 arg1)
        where T1 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, void>) _objc_msgSend.Value;
        func(self, op, arg1);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, TResult>(
        ObjCId self, ObjCSel op, T1 arg1)
        where TResult : unmanaged
        where T1 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, TResult>) _objc_msgSend.Value;
        return func(self, op, arg1);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1, T2>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2)
        where T1 : unmanaged
        where T2 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, void>) _objc_msgSend.Value;
        func(self, op, arg1, arg2);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, T2, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, TResult>) _objc_msgSend.Value;
        return func(self, op, arg1, arg2);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1, T2, T3>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, void>) _objc_msgSend.Value;
        func(self, op, arg1, arg2, arg3);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, T2, T3, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, TResult>) _objc_msgSend.Value;
        return func(self, op, arg1, arg2, arg3);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1, T2, T3, T4>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, void>) _objc_msgSend.Value;
        func(self, op, arg1, arg2, arg3, arg4);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, T2, T3, T4, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, TResult>) _objc_msgSend.Value;
        return func(self, op, arg1, arg2, arg3, arg4);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1, T2, T3, T4, T5>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, void>) _objc_msgSend.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, T2, T3, T4, T5, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, TResult>) _objc_msgSend.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1, T2, T3, T4, T5, T6>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, void>) _objc_msgSend.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, T2, T3, T4, T5, T6, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, TResult>) _objc_msgSend.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1, T2, T3, T4, T5, T6, T7>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, void>) _objc_msgSend.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, T2, T3, T4, T5, T6, T7, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, TResult>) _objc_msgSend.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, void>) _objc_msgSend.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, TResult>) _objc_msgSend.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>) _objc_msgSend.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>) _objc_msgSend.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>) _objc_msgSend.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>) _objc_msgSend.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>) _objc_msgSend.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>) _objc_msgSend.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            void>) _objc_msgSend.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            TResult>) _objc_msgSend.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, void>) _objc_msgSend.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, TResult>) _objc_msgSend.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, T14, void>) _objc_msgSend.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, T14, TResult>) _objc_msgSend.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, T14, T15, void>) _objc_msgSend.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,
        TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, T14, T15, TResult>) _objc_msgSend.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14,
            arg15);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, T14, T15, T16, void>) _objc_msgSend.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15,
            arg16);
    }

    /// <summary>
    /// <c>void objc_msgSend(id self, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/>.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16,
        TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, T14, T15, T16, TResult>) _objc_msgSend.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14,
            arg15, arg16);
    }

    #endregion

    #region objc_msgSend_fpret

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret(
        ObjCId self, ObjCSel op)
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, void>) _objc_msgSend_fpret.Value;
        func(self, op);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<TResult>(
        ObjCId self, ObjCSel op)
        where TResult : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1>(
        ObjCId self, ObjCSel op, T1 arg1)
        where T1 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, TResult>(
        ObjCId self, ObjCSel op, T1 arg1)
        where TResult : unmanaged
        where T1 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1, T2>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2)
        where T1 : unmanaged
        where T2 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1, arg2);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, T2, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1, arg2);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1, T2, T3>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1, arg2, arg3);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, T2, T3, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1, arg2, arg3);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1, T2, T3, T4>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1, arg2, arg3, arg4);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, T2, T3, T4, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1, arg2, arg3, arg4);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1, T2, T3, T4, T5>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, T2, T3, T4, T5, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1, T2, T3, T4, T5, T6>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, T14, void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,
        TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, T14, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, T14, T15, void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,
        TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, T14, T15, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14,
            arg15);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, T14, T15, T16, void>) _objc_msgSend_fpret.Value;
        func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15,
            arg16);
    }

    /// <summary>
    /// <c>void objc_msgSend_fpret(id self, SEL op, ...);</c>
    /// <para>Sends a message with a floating-point return value to an instance of a class.</para>
    /// </summary>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) floating-point results are returned through <c>objc_msgSend</c>, so prefer the portable <c>TResult</c> overloads of <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_fpret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_fpret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,
        T16, TResult>(
        ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, T14, T15, T16, TResult>) _objc_msgSend_fpret.Value;
        return func(self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14,
            arg15, arg16);
    }

    #endregion

    #region objc_msgSend_stret

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret(
        nint stretAddr, ObjCId self, ObjCSel op)
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<TResult>(
        nint stretAddr, ObjCId self, ObjCSel op)
        where TResult : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1)
        where T1 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1)
        where TResult : unmanaged
        where T1 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1, T2>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2)
        where T1 : unmanaged
        where T2 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1, arg2);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, T2, TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1, arg2);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1, T2, T3>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1, arg2, arg3);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, T2, T3, TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1, arg2, arg3);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1, T2, T3, T4>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1, arg2, arg3, arg4);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, T2, T3, T4, TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1, arg2, arg3, arg4);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1, T2, T3, T4, T5>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, T2, T3, T4, T5, TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1, T2, T3, T4, T5, T6>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, T2, T3, T4, T5, T6, TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,
            TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12,
            arg13);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, T14, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13,
            arg14);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,
        TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, T14, TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12,
            arg13, arg14);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, T14, T15, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13,
            arg14, arg15);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,
        TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, T14, T15, TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12,
            arg13, arg14, arg15);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, T14, T15, T16, void>) _objc_msgSend_stret.Value;
        func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13,
            arg14, arg15, arg16);
    }

    /// <summary>
    /// <c>void objc_msgSend_stret(void *stretAddr, id self, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="self">The receiver of the message.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSend</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsend_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSend_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,
        T16, TResult>(
        nint stretAddr, ObjCId self, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCId, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, T14, T15, T16, TResult>) _objc_msgSend_stret.Value;
        return func(stretAddr, self, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12,
            arg13, arg14, arg15, arg16);
    }

    #endregion

    #region objc_msgSendSuper

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper(
        nint super, ObjCSel op)
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, void>) _objc_msgSendSuper.Value;
        func(super, op);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<TResult>(
        nint super, ObjCSel op)
        where TResult : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, TResult>) _objc_msgSendSuper.Value;
        return func(super, op);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1>(
        nint super, ObjCSel op, T1 arg1)
        where T1 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, void>) _objc_msgSendSuper.Value;
        func(super, op, arg1);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, TResult>(
        nint super, ObjCSel op, T1 arg1)
        where TResult : unmanaged
        where T1 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1, T2>(
        nint super, ObjCSel op, T1 arg1, T2 arg2)
        where T1 : unmanaged
        where T2 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, void>) _objc_msgSendSuper.Value;
        func(super, op, arg1, arg2);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, T2, TResult>(
        nint super, ObjCSel op, T1 arg1, T2 arg2)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1, arg2);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1, T2, T3>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, void>) _objc_msgSendSuper.Value;
        func(super, op, arg1, arg2, arg3);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, T2, T3, TResult>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1, arg2, arg3);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1, T2, T3, T4>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, void>) _objc_msgSendSuper.Value;
        func(super, op, arg1, arg2, arg3, arg4);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, T2, T3, T4, TResult>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1, arg2, arg3, arg4);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1, T2, T3, T4, T5>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, void>) _objc_msgSendSuper.Value;
        func(super, op, arg1, arg2, arg3, arg4, arg5);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, T2, T3, T4, T5, TResult>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1, arg2, arg3, arg4, arg5);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1, T2, T3, T4, T5, T6>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, void>) _objc_msgSendSuper.Value;
        func(super, op, arg1, arg2, arg3, arg4, arg5, arg6);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, T2, T3, T4, T5, T6, TResult>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1, arg2, arg3, arg4, arg5, arg6);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, void>) _objc_msgSendSuper.Value;
        func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, TResult>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, void>) _objc_msgSendSuper.Value;
        func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>) _objc_msgSendSuper.Value;
        func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>) _objc_msgSendSuper.Value;
        func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>) _objc_msgSendSuper.Value;
        func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>) _objc_msgSendSuper.Value;
        func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,
            void>) _objc_msgSendSuper.Value;
        func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,
            TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,
            T14, void>) _objc_msgSendSuper.Value;
        func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,
        TResult>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,
            T14, TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,
            T14, T15, void>) _objc_msgSendSuper.Value;
        func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,
        TResult>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,
            T14, T15, TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13,
            arg14, arg15);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a void return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,
            T14, T15, T16, void>) _objc_msgSendSuper.Value;
        func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14,
            arg15, arg16);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper(struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message and interprets the returned value as <typeparamref name="TResult"/> from the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para><paramref name="super"/> must reference an initialized <c>struct objc_super</c> whose <c>receiver</c> and <c>super_class</c> fields describe the dispatch context.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,
        T16, TResult>(
        nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
        T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,
            T14, T15, T16, TResult>) _objc_msgSendSuper.Value;
        return func(super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13,
            arg14, arg15, arg16);
    }

    #endregion

    #region objc_msgSendSuper_stret

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret(
        nint stretAddr, nint super, ObjCSel op)
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<TResult>(
        nint stretAddr, nint super, ObjCSel op)
        where TResult : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1)
        where T1 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1)
        where TResult : unmanaged
        where T1 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1, T2>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2)
        where T1 : unmanaged
        where T2 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1, arg2);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, T2, TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1, arg2);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1, T2, T3>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1, arg2, arg3);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, T2, T3, TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1, arg2, arg3);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1, T2, T3, T4>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1, arg2, arg3, arg4);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, T2, T3, T4, TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1, arg2, arg3, arg4);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1, T2, T3, T4, T5>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, T2, T3, T4, T5, TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,
        TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12,
            arg13);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, T14, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13,
            arg14);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,
        TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, T14, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12,
            arg13, arg14);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, T14, T15, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13,
            arg14, arg15);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,
        T15, TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, T14, T15, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12,
            arg13, arg14, arg15);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe void objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,
        T15, T16>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, T14, T15, T16, void>) _objc_msgSendSuper_stret.Value;
        func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13,
            arg14, arg15, arg16);
    }

    /// <summary>
    /// <c>void objc_msgSendSuper_stret(void *stretAddr, struct objc_super *super, SEL op, ...);</c>
    /// <para>Sends a message with a data-structure return value to the superclass of an instance of a class.</para>
    /// </summary>
    /// <param name="stretAddr">The address at which to store the returned structure.</param>
    /// <param name="super">A pointer to an <c>objc_super</c> structure that identifies the receiver and its superclass.</param>
    /// <param name="op">The selector of the method that handles the message.</param>
    /// <returns>The value produced by the message, interpreted as <typeparamref name="TResult"/>.</returns>
    /// <remarks>
    /// <para>This declaration only describes the fixed arguments; the function is variadic, so every generic argument must match the ABI signature that <paramref name="op"/> selects.</para>
    /// <para>The result is written to <paramref name="stretAddr"/>; the function itself returns <c>void</c>.</para>
    /// <para>This symbol is only provided on i386 and x86_64. On arm64 (including Apple silicon) structure results are returned through <c>objc_msgSendSuper</c>.</para>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_msgsendsuper_stret?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    public static unsafe TResult objc_msgSendSuper_stret<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,
        T15, T16, TResult>(
        nint stretAddr, nint super, ObjCSel op, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
        T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        where TResult : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
    {
        var func = (delegate *unmanaged[Cdecl] <nint, nint, ObjCSel, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
            T12, T13, T14, T15, T16, TResult>) _objc_msgSendSuper_stret.Value;
        return func(stretAddr, super, op, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12,
            arg13, arg14, arg15, arg16);
    }

    #endregion

    #endregion
}
