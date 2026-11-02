using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    private const string Library = "/usr/lib/libobjc.A.dylib";
    
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static  partial IntPtr sel_getName(IntPtr name);
    
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static  partial IntPtr sel_registerName(IntPtr name);
}