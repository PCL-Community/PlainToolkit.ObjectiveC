using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    #region Associative References

    /// <summary>
    /// <c>void objc_setAssociatedObject(id object, const void *key, id value, objc_AssociationPolicy policy);</c>
    /// <para>Sets an associated value for a given object using a given key and association policy.</para>
    /// </summary>
    /// <param name="object">The source object for the association.</param>
    /// <param name="key">The key for the association.</param>
    /// <param name="value">The value to associate with the key <paramref name="key"/> for <paramref name="object"/>.</param>
    /// <param name="policy">The policy for the association.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_setassociatedobject(_:_:_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void objc_setAssociatedObject(
        ObjCId @object, nint key, ObjCId value, ObjCAssociationPolicy policy);

    /// <summary>
    /// <c>id objc_getAssociatedObject(id object, const void *key);</c>
    /// <para>Returns the value associated with a given object for a given key.</para>
    /// </summary>
    /// <param name="object">The source object for the association.</param>
    /// <param name="key">The key for the association.</param>
    /// <returns>The value associated with <paramref name="key"/> for <paramref name="object"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_getassociatedobject(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCId objc_getAssociatedObject(ObjCId @object, nint key);

    /// <summary>
    /// <c>void objc_removeAssociatedObjects(id object);</c>
    /// <para>Removes all associations for a given object.</para>
    /// </summary>
    /// <param name="object">An object that has associations.</param>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/objc_removeassociatedobjects(_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void objc_removeAssociatedObjects(ObjCId @object);

    #endregion
}
