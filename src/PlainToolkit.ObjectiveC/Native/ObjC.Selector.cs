using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Native;

public static partial class ObjC
{
    #region Working with Selectors

    /// <summary>
    /// <c>BOOL sel_isEqual(SEL lhs, SEL rhs);</c>
    /// <para>Returns a Boolean value that indicates whether two selectors are equal.</para>
    /// </summary>
    /// <param name="lhs">The selector to compare with <paramref name="rhs"/>.</param>
    /// <param name="rhs">The selector to compare with <paramref name="lhs"/>.</param>
    /// <returns><see cref="ObjCBool.YES"/> if <paramref name="lhs"/> and <paramref name="rhs"/> are equal; otherwise, <see cref="ObjCBool.NO"/>.</returns>
    /// <remarks>
    /// <see href="https://developer.apple.com/documentation/objectivec/sel_isequal(_:_:)?language=objc">Apple Developer Documentation</see>
    /// </remarks>
    [LibraryImport(Library)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial ObjCBool sel_isEqual(ObjCSel lhs, ObjCSel rhs);

    #endregion
}
