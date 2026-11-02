namespace PlainToolkit.ObjectiveC.Runtime;

public static class Selectors
{
    // NSObject
    public static readonly ObjCSel Alloc = ObjCSel.FromString("alloc");
    public static readonly ObjCSel Init = ObjCSel.FromString("init");
    public static readonly ObjCSel New = ObjCSel.FromString("new");
    
    // NSString
    public static readonly ObjCSel InitWithUtf8String = ObjCSel.FromString("initWithUTF8String:");
    public static readonly ObjCSel Utf8String = ObjCSel.FromString("UTF8String");
}