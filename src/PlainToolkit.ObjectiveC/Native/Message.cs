using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Native;

public static class Message
{
    private const string Library = "/usr/lib/libobjc.A.dylib";
    internal static readonly nint MsgSend;
    static Message()
    {
        var libraryHandle = NativeLibrary.Load(Library);
        MsgSend = NativeLibrary.GetExport(libraryHandle, "objc_msgSend");
        
        AppDomain.CurrentDomain.ProcessExit += (_, _) => NativeLibrary.Free(libraryHandle);
    }
}