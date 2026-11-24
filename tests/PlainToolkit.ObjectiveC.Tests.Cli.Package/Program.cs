using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Tests.Cli.Package;

[StructLayout(LayoutKind.Sequential)]
internal struct NSPoint(double x, double y)
{
    public double X = x;
    public double Y = y;
}

[StructLayout(LayoutKind.Sequential)]
internal struct NSSize(double width, double height)
{
    public double Width = width;
    public double Height = height;
}

[StructLayout(LayoutKind.Sequential)]
internal struct NSRect(double x, double y, double width, double height)
{
    public NSPoint Origin = new(x, y);
    public NSSize Size = new(width, height);
}

internal static class Program
{
    private static ObjCSel Sel(string name) => ObjCSel.FromString(name);

    private static ObjCObject CreateNSString(string value)
    {
        var utf8 = Marshal.StringToCoTaskMemUTF8(value);

        try
        {
            return ObjCObject.GetClass("NSString")
                .SendMessage<ObjCObject>(Sel("alloc"))
                .SendMessage<nint, ObjCObject>(Sel("initWithUTF8String:"), utf8);
        }
        finally
        {
            Marshal.FreeCoTaskMem(utf8);
        }
    }

    private static void Main()
    {
        NativeLibrary.Load("/System/Library/Frameworks/AppKit.framework/AppKit");

        // NSApplication.sharedApplication
        var app = ObjCObject.GetClass("NSApplication")
            .SendMessage<ObjCObject>(Sel("sharedApplication"));

        // NSApplicationActivationPolicyRegular = 0
        app.SendMessage<nint>(Sel("setActivationPolicy:"), 0);

        // Create NSWindow.
        var window = ObjCObject.GetClass("NSWindow")
            .SendMessage<ObjCObject>(Sel("alloc"));

        // NSWindowStyleMask:
        // Titled         = 1
        // Closable       = 2
        // Miniaturizable = 4
        // Resizable      = 8
        //
        // NSBackingStoreBuffered = 2
        window = window.SendMessage<
            NSRect, nuint, nuint, bool, ObjCObject>(
            Sel("initWithContentRect:styleMask:backing:defer:"),
            new NSRect(0, 0, 600, 400),
            15,
            2,
            false);

        // Set white window background.
        var whiteColor = ObjCObject.GetClass("NSColor")
            .SendMessage<ObjCObject>(Sel("whiteColor"));

        window.SendMessage(Sel("setBackgroundColor:"), whiteColor);

        // Create HelloWorld label.
        var label = ObjCObject.GetClass("NSTextField")
            .SendMessage<ObjCObject, ObjCObject>(
                Sel("labelWithString:"),
                CreateNSString("HelloWorld"));

        // Horizontal alignment: NSTextAlignmentCenter = 1
        label.SendMessage<nint>(Sel("setAlignment:"), 1);

        label.SendMessage(Sel("setTranslatesAutoresizingMaskIntoConstraints:"), false);

        // Add label to window.
        var contentView = window.SendMessage<ObjCObject>(Sel("contentView"));
        contentView.SendMessage(Sel("addSubview:"), label);

        // Keep the label at its intrinsic size and centered when the window resizes.
        foreach (var anchorName in new[] { "centerXAnchor", "centerYAnchor" })
        {
            var labelAnchor = label.SendMessage<ObjCObject>(Sel(anchorName));
            var contentAnchor = contentView.SendMessage<ObjCObject>(Sel(anchorName));
            var constraint = labelAnchor.SendMessage<ObjCObject, ObjCObject>(
                Sel("constraintEqualToAnchor:"), contentAnchor);
            constraint.SendMessage(Sel("setActive:"), true);
        }

        // Center window using AppKit's standard positioning.
        window.SendMessage(Sel("center"));

        // Show window.
        window.SendMessage(Sel("makeKeyAndOrderFront:"), nint.Zero);

        // Activate application.
        app.SendMessage(Sel("activateIgnoringOtherApps:"), true);

        // Enter AppKit event loop.
        app.SendMessage(Sel("run"));
    }
}
