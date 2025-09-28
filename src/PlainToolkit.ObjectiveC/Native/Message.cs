using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Native;

public static class Message
{
    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3,
        IntPtr arg4);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12,
        IntPtr arg13);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12,
        IntPtr arg13, IntPtr arg14);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12,
        IntPtr arg13, IntPtr arg14, IntPtr arg15);

    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12,
        IntPtr arg13, IntPtr arg14, IntPtr arg15, IntPtr arg16);
}