using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Tests.Cli;

class Program
{
    static void Main(string[] args)
    {
        NativeLibrary.Load("/System/Library/Frameworks/AppKit.framework/AppKit");
        
        var app = ObjCObject.GetClass("NSApplication")
            .SendMessage(ObjCSel.FromString("sharedApplication"));
        
        app.SendMessage(ObjCSel.FromString("setActivationPolicy:"), 0);
        app.SendMessage(ObjCSel.FromString("activate"));
        
        var msg = ObjCString.FromString("测试");

        var alert = ObjCObject.GetClass("NSAlert")
            .SendMessage(Selectors.Alloc)
            .SendMessage(Selectors.Init); 
        
        alert.SendMessage(ObjCSel.FromString("setMessageText:"), msg);
        alert.SendMessage(ObjCSel.FromString("runModal"));
    }
}