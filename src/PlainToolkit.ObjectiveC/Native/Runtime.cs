using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class Runtime
{
    private const string Library = "/usr/lib/libobjc.A.dylib";
    
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial IntPtr objc_getClass(IntPtr name);
}
