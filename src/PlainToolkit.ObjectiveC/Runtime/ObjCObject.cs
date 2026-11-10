using System.Diagnostics;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Native;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 Objective-C Class 句柄的只读包装。
/// </summary>
/// <param name="Value">Class 的底层指针句柄（<see cref="nint"/>）。</param>
public readonly partial record struct ObjCObject(nint Value)
{
    public readonly nint Value = Value;

    public bool IsNull => Value == nint.Zero;

    public static implicit operator nint(ObjCObject h) => h.Value;
    public static explicit operator ObjCObject(nint ptr) => new(ptr);

    public static ObjCObject GetClass(string name)
    {
        var ptr = Marshal.StringToCoTaskMemUTF8(name);

        try
        {
            return new ObjCObject(Native.Runtime.objc_getClass(ptr));
        }
        finally
        {
            Marshal.FreeCoTaskMem(ptr);
        }
    }

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
        ((delegate* unmanaged[Cdecl]<nint, nint, void>)Message.MsgSend)(Value, msg);
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