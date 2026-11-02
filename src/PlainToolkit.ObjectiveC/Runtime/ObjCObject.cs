using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 表示一个 Objective-C Class 句柄的只读包装。
/// </summary>
/// <param name="Value">Class 的底层指针句柄（<see cref="IntPtr"/>）。</param>
public readonly record struct ObjCObject(IntPtr Value)
{
    public readonly IntPtr Value = Value;

    public bool IsNull => Value == IntPtr.Zero;

    public static implicit operator IntPtr(ObjCObject h) => h.Value;
    public static explicit operator ObjCObject(IntPtr ptr) => new(ptr);

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

    public ObjCObject SendMessage(ObjCSel msg)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1, IntPtr arg2)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1, arg2));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1, IntPtr arg2, IntPtr arg3)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1, arg2, arg3));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1, arg2, arg3, arg4));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1, arg2, arg3, arg4, arg5));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5,
        IntPtr arg6)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1, arg2, arg3, arg4, arg5, arg6));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5,
        IntPtr arg6, IntPtr arg7)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5,
        IntPtr arg6, IntPtr arg7, IntPtr arg8)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5,
        IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
            arg9));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5,
        IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
            arg9, arg10));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5,
        IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
            arg9, arg10, arg11));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5,
        IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
            arg9, arg10, arg11, arg12));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5,
        IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12, IntPtr arg13)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
            arg9, arg10, arg11, arg12, arg13));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5,
        IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12, IntPtr arg13,
        IntPtr arg14)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
            arg9, arg10, arg11, arg12, arg13, arg14));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5,
        IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12, IntPtr arg13,
        IntPtr arg14, IntPtr arg15)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
            arg9, arg10, arg11, arg12, arg13, arg14, arg15));
    }

    public ObjCObject SendMessage(ObjCSel msg, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5,
        IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12, IntPtr arg13,
        IntPtr arg14, IntPtr arg15, IntPtr arg16)
    {
        return new ObjCObject(Native.Message.objc_msgSend(Value, msg, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
            arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
    }

    #endregion
}