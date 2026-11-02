using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class Message
{
    private const string Library = "/usr/lib/libobjc.A.dylib";
    
    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3,
        IntPtr arg4);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12,
        IntPtr arg13);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12,
        IntPtr arg13, IntPtr arg14);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12,
        IntPtr arg13, IntPtr arg14, IntPtr arg15);

    [LibraryImport(Library, EntryPoint = "objc_msgSend")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_msgSend(IntPtr self, IntPtr op, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4,
        IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9, IntPtr arg10, IntPtr arg11, IntPtr arg12,
        IntPtr arg13, IntPtr arg14, IntPtr arg15, IntPtr arg16);
}