using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Tests.Cli;

class Program
{
    static void Main(string[] args)
    {
        NativeLibrary.Load("/System/Library/Frameworks/AppKit.framework/AppKit");
        
        var app = ObjCId.GetClass("NSApplication")
            .SendMessage<ObjCId>(ObjCSel.FromString("sharedApplication"));
        
        app.SendMessage<nint>(ObjCSel.FromString("setActivationPolicy:"), 0);
        app.SendMessage(ObjCSel.FromString("activate"));

        var appClass = app.SendMessage<ObjCClass>(ObjCSel.FromString("class"));
        Console.WriteLine(appClass.Name);
        
        var msg = CreateNSString("测试");

        var alert = ObjCId.GetClass("NSAlert")
            .SendMessage<ObjCId>(Selectors.Alloc)
            .SendMessage<ObjCId>(Selectors.Init); 
        
        alert.SendMessage<nint>(ObjCSel.FromString("setMessageText:"), msg);
        alert.SendMessage(ObjCSel.FromString("runModal"));
    }

    private static ObjCId CreateNSString(string value)
    {
        var utf8 = Marshal.StringToCoTaskMemUTF8(value);

        try
        {
            return ObjCId.GetClass("NSString")
                .SendMessage<ObjCId>(Selectors.Alloc)
                .SendMessage<nint, ObjCId>(Selectors.InitWithUtf8String, utf8);
        }
        finally
        {
            Marshal.FreeCoTaskMem(utf8);
        }
    }
}