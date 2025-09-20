using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Native;

public static class Runtime
{
    [DllImport("libobjc.dylib", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    public static extern IntPtr objc_getClass(string name);
    
}