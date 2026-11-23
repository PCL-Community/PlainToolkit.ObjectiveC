using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Native;

using size_t = UIntPtr;

public static partial class ObjC
{
    private const string Library = "/usr/lib/libobjc.A.dylib";
    
    #region Class
    
    /// <summary>
    /// const char *class_getName(Class cls);
    /// <br/>
    /// Returns the name of a class.
    /// </summary>
    /// <param name="cls">A class object.</param>
    /// <returns>The name of the class, or the empty string if cls is Nil.</returns>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint class_getName(nint cls);
    
    // Class class_getSuperclass(Class cls);
    // Returns the superclass of a class.
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint class_getSuperclass(nint cls);
    
    // Class class_setSuperclass(Class cls, Class newSuper);
    // Sets the superclass of a given class.
    [Obsolete("not recommended")]
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint class_setSuperClass(nint cls, nint newSuper);
    
    // extern BOOL class_isMetaClass(Class cls);
    // [LibraryImport(Library)]
    // [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    // public static partial bool class_isMetaClass(nint cls);

    // size_t class_getInstanceSize(Class cls);
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial size_t class_getInstanceSize(nint cls);
    #endregion
    
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint sel_getName(nint name);
    
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCSel sel_registerName(nint name);

    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial nint objc_msgSend(nint id, nint sel);
}