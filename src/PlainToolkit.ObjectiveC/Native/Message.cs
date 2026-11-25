using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Native;

public static class Message
{
    private const string Library = "/usr/lib/libobjc.A.dylib";
    public static readonly nint MsgSend;
    public static readonly nint MsgSendStret;
    static Message()
    {
        var libraryHandle = NativeLibrary.Load(Library);
        MsgSend = NativeLibrary.GetExport(libraryHandle, "objc_msgSend");
        if (RuntimeInformation.OSArchitecture == Architecture.X64)
        {
            MsgSendStret = NativeLibrary.GetExport(libraryHandle, "objc_msgSend_stret");
        }
        
        AppDomain.CurrentDomain.ProcessExit += (_, _) => NativeLibrary.Free(libraryHandle);
    }
}