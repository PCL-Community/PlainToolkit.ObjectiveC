using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Tests;

public class ObjCObjectTest
{
    [Fact]
    public void AlertTest()
    {
        NativeLibrary.Load("/System/Library/Frameworks/AppKit.framework/AppKit");
        
        var app = ObjCId.GetClass("NSApplication")
            .SendMessage<ObjCId>(ObjCSel.FromString("sharedApplication"));
        
        Assert.False(app.IsNull);
    }
}