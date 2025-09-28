using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Native;

public static class Runtime
{
    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe IntPtr objc_getClass(byte* name);
    
    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe byte* sel_getName(IntPtr name);
    
    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern unsafe IntPtr sel_registerName(byte* name);
}