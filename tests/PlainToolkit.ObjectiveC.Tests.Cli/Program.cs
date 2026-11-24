using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Tests.Cli;

class Program
{
    static void Main(string[] args)
    {
        NativeLibrary.Load("/System/Library/Frameworks/AppKit.framework/AppKit");
        
        var app = ObjCObject.GetClass("NSApplication")
            .SendMessage<ObjCObject>(ObjCSel.FromString("sharedApplication"));
        
        app.SendMessage<nint>(ObjCSel.FromString("setActivationPolicy:"), 0);
        app.SendMessage(ObjCSel.FromString("activate"));

        var appClass = app.SendMessage<ObjCClass>(ObjCSel.FromString("class"));
        Console.WriteLine(appClass.Name);
        
        var msg = CreateNSString("测试");

        var alert = ObjCObject.GetClass("NSAlert")
            .SendMessage<ObjCObject>(Selectors.Alloc)
            .SendMessage<ObjCObject>(Selectors.Init); 
        
        alert.SendMessage<nint>(ObjCSel.FromString("setMessageText:"), msg);
        alert.SendMessage(ObjCSel.FromString("runModal"));
    }

    private static ObjCObject CreateNSString(string value)
    {
        var utf8 = Marshal.StringToCoTaskMemUTF8(value);

        try
        {
            return ObjCObject.GetClass("NSString")
                .SendMessage<ObjCObject>(Selectors.Alloc)
                .SendMessage<nint, ObjCObject>(Selectors.InitWithUtf8String, utf8);
        }
        finally
        {
            Marshal.FreeCoTaskMem(utf8);
        }
    }
}