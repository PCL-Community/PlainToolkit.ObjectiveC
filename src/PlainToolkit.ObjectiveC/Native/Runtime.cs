using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class Runtime
{
    [LibraryImport("libobjc.dylib")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial IntPtr objc_getClass(byte* name);
    
    [LibraryImport("libobjc.dylib")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* sel_getName(IntPtr name);
    
    [LibraryImport("libobjc.dylib")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial IntPtr sel_registerName(byte* name);
}
