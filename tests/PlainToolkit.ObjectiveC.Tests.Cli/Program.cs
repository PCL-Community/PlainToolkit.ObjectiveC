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
        app.SendMessage<nint>(ObjCSel.FromString("setMessageText:"), 0);
        
        var msg = ObjCString.FromString("测试");

        var alert = ObjCObject.GetClass("NSAlert")
            .SendMessage<ObjCObject>(Selectors.Alloc)
            .SendMessage<ObjCObject>(Selectors.Init); 
        
        alert.SendMessage<nint>(ObjCSel.FromString("setMessageText:"), msg);
        alert.SendMessage(ObjCSel.FromString("runModal"));
    }
}