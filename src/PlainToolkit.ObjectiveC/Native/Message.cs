using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class Message
{
    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3,
        IntPtr arg4);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12,
        IntPtr arg13);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12,
        IntPtr arg13, IntPtr arg14);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12,
        IntPtr arg13, IntPtr arg14, IntPtr arg15);

    [LibraryImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12,
        IntPtr arg13, IntPtr arg14, IntPtr arg15, IntPtr arg16);
}