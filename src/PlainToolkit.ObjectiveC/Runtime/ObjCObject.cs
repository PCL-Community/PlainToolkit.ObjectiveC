using System.Diagnostics;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Native;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 Objective-C 对象（<c>id</c>）句柄的只读包装。
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public readonly record struct ObjCObject : IPointer
{
    /// <summary>
    /// 使用底层指针初始化 <see cref="ObjCObject"/>。
    /// </summary>
    /// <param name="ptr">对象（<c>id</c>）的底层指针句柄。</param>
    public ObjCObject(nint ptr) => Ptr = ptr;

    /// <inheritdoc />
    public IntPtr Ptr { get; init; }

    /// <summary>
    /// 获取一个值，该值指示此句柄是否为 <c>Nil</c>。
    /// </summary>
    public bool IsNull => Ptr == nint.Zero;

    public static implicit operator nint(ObjCObject obj) => obj.Ptr;
    public static explicit operator ObjCObject(nint ptr) => new(ptr);

    /// <summary>
    /// 获取具有指定名称的类。
    /// </summary>
    /// <param name="name">类的名称。</param>
    /// <returns>具有指定名称的类；如果不存在，则返回 <c>Nil</c>。</returns>
    /// <remarks>
    /// 此方法返回对象形式的类句柄，便于直接发送类方法消息。如果需要强类型的 <see cref="ObjCClass"/> 句柄，
    /// 请使用 <see cref="ObjCClass.GetClass(string)"/>。
    /// </remarks>
    public static ObjCObject GetClass(string name) => ObjCClass.GetClass(name);

    /// <summary>
    /// 获取此对象所属的类。
    /// </summary>
    public ObjCClass Class => Native.ObjC.object_getClass(this);

    /// <summary>
    /// 获取此对象所属类的名称。
    /// </summary>
    public string ClassName
    {
        get
        {
            var ptr = Native.ObjC.object_getClassName(this);
            return ptr == nint.Zero ? string.Empty : Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
        }
    }

    /// <summary>
    /// 设置此对象的类。
    /// </summary>
    /// <param name="cls">新的类。</param>
    /// <returns>此对象原来的类。</returns>
    public ObjCClass SetClass(ObjCClass cls) => Native.ObjC.object_setClass(this, cls);

    /// <summary>
    /// 读取此对象中指定实例变量的值。
    /// </summary>
    /// <param name="ivar">实例变量。</param>
    /// <returns>实例变量的值。</returns>
    public ObjCObject GetIvar(ObjCIvar ivar) => Native.ObjC.object_getIvar(this, ivar);

    /// <summary>
    /// 设置此对象中指定实例变量的值。
    /// </summary>
    /// <param name="ivar">实例变量。</param>
    /// <param name="value">新的值。</param>
    public void SetIvar(ObjCIvar ivar, ObjCObject value) => Native.ObjC.object_setIvar(this, ivar, value);

    /// <summary>
    /// 获取随此对象一起分配的额外字节的指针。
    /// </summary>
    public nint GetIndexedIvars() => Native.ObjC.object_getIndexedIvars(this);

    #region SendMessage

    public TResult SendMessage<TResult>(ObjCSel msg)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T, TResult>(ObjCSel msg, T arg)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T1, T2, TResult>(ObjCSel msg, T1 arg1, T2 arg2)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T1, T2, T3, TResult>(ObjCSel msg, T1 arg1, T2 arg2, T3 arg3)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T1, T2, T3, T4, TResult>(ObjCSel msg, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T1, T2, T3, T4, T5, TResult>(ObjCSel msg, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
        T5 arg5)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T1, T2, T3, T4, T5, T6, TResult>(ObjCSel msg, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
        T5 arg5, T6 arg6)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T1, T2, T3, T4, T5, T6, T7, TResult>(ObjCSel msg, T1 arg1, T2 arg2, T3 arg3,
        T4 arg4, T5 arg5, T6 arg6, T7 arg7)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(ObjCSel msg, T1 arg1, T2 arg2, T3 arg3,
        T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(ObjCSel msg, T1 arg1, T2 arg2,
        T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(ObjCSel msg, T1 arg1, T2 arg2,
        T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(ObjCSel msg, T1 arg1,
        T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(ObjCSel msg, T1 arg1,
        T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(ObjCSel msg,
        T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11,
        T12 arg12, T13 arg13)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
        ObjCSel msg, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10,
        T11 arg11, T12 arg12, T13 arg13, T14 arg14)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
        ObjCSel msg, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10,
        T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public TResult SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
        ObjCSel msg, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10,
        T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public unsafe void SendMessage(ObjCSel msg)
    {
        ((delegate* unmanaged[Cdecl]<nint, nint, void>)Message.MsgSend)(Ptr, msg);
    }

    public void SendMessage<T>(ObjCSel msg, T arg)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public void SendMessage<T1, T2>(ObjCSel msg, T1 arg1, T2 arg2)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public void SendMessage<T1, T2, T3>(ObjCSel msg, T1 arg1, T2 arg2, T3 arg3)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public void SendMessage<T1, T2, T3, T4>(ObjCSel msg, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public void SendMessage<T1, T2, T3, T4, T5>(ObjCSel msg, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public void SendMessage<T1, T2, T3, T4, T5, T6>(ObjCSel msg, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
        T5 arg5, T6 arg6)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public void SendMessage<T1, T2, T3, T4, T5, T6, T7>(ObjCSel msg, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
        T5 arg5, T6 arg6, T7 arg7)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public void SendMessage<T1, T2, T3, T4, T5, T6, T7, T8>(ObjCSel msg, T1 arg1, T2 arg2, T3 arg3,
        T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public void SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ObjCSel msg, T1 arg1, T2 arg2, T3 arg3,
        T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public void SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ObjCSel msg, T1 arg1, T2 arg2,
        T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public void SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ObjCSel msg, T1 arg1, T2 arg2,
        T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public void SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ObjCSel msg, T1 arg1,
        T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public void SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ObjCSel msg, T1 arg1,
        T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12,
        T13 arg13)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public void SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ObjCSel msg,
        T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11,
        T12 arg12, T13 arg13, T14 arg14)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public void SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ObjCSel msg,
        T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10,
        T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    public void SendMessage<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        ObjCSel msg, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10,
        T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
    {
        throw new UnreachableException("This method should never be executed directly. It should be intercepted.");
    }

    #endregion
}