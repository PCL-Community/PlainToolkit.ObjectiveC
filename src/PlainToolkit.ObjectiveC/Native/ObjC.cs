using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    private const string Library = "/usr/lib/libobjc.A.dylib";
    
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static  partial nint sel_getName(nint name);
    
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static  partial nint sel_registerName(nint name);
}