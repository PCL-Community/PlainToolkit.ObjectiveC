using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Tests;

public class PointerLayoutTest
{
    [Fact]
    public void HandleWrappersAreSinglePointerSizedStructs()
    {
        Assert.Equal(IntPtr.Size, Marshal.SizeOf<ObjCSel>());
        Assert.Equal(IntPtr.Size, Marshal.SizeOf<ObjCObject>());
        Assert.Equal(IntPtr.Size, Marshal.SizeOf<ObjCClass>());
        Assert.Equal(IntPtr.Size, Marshal.SizeOf<ObjCMethod>());
        Assert.Equal(IntPtr.Size, Marshal.SizeOf<ObjCIvar>());
        Assert.Equal(IntPtr.Size, Marshal.SizeOf<ObjCCategory>());
        Assert.Equal(IntPtr.Size, Marshal.SizeOf<ObjCProperty>());
        Assert.Equal(IntPtr.Size, Marshal.SizeOf<ObjCImp>());
        Assert.Equal(IntPtr.Size, Marshal.SizeOf<ObjCProtocol>());
        Assert.Equal(IntPtr.Size, Marshal.SizeOf<ObjCCache>());
    }

    [Fact]
    public void ValueStructsMatchTheirTwoPointerNativeLayout()
    {
        Assert.Equal(IntPtr.Size * 2, Marshal.SizeOf<ObjCMethodDescription>());
        Assert.Equal(IntPtr.Size * 2, Marshal.SizeOf<ObjCPropertyAttribute>());
        Assert.Equal(sizeof(ulong), Unsafe.SizeOf<ObjCAssociationPolicy>());
        Assert.Equal(1, Unsafe.SizeOf<ObjCBool>());
        Assert.Equal((byte)0, (byte)ObjCBool.NO);
        Assert.Equal((byte)1, (byte)ObjCBool.YES);

        Assert.Equal(0, (int)Marshal.OffsetOf<ObjCMethodDescription>(nameof(ObjCMethodDescription.Name)));
        Assert.Equal(IntPtr.Size, (int)Marshal.OffsetOf<ObjCMethodDescription>(nameof(ObjCMethodDescription.Types)));
        Assert.Equal(0, (int)Marshal.OffsetOf<ObjCPropertyAttribute>(nameof(ObjCPropertyAttribute.Name)));
        Assert.Equal(IntPtr.Size, (int)Marshal.OffsetOf<ObjCPropertyAttribute>(nameof(ObjCPropertyAttribute.Value)));
    }

    [Fact]
    public void HandleWrappersRoundTripTheirPointer()
    {
        nint ptr = 0x1234;

        Assert.Equal(ptr, (nint)new ObjCSel(ptr));
        Assert.Equal(ptr, (nint)new ObjCObject(ptr));
        Assert.Equal(ptr, (nint)new ObjCClass(ptr));
        Assert.Equal(ptr, (nint)new ObjCMethod(ptr));
        Assert.Equal(ptr, (nint)new ObjCIvar(ptr));
        Assert.Equal(ptr, (nint)new ObjCCategory(ptr));
        Assert.Equal(ptr, (nint)new ObjCProperty(ptr));
        Assert.Equal(ptr, (nint)new ObjCImp(ptr));
        Assert.Equal(ptr, (nint)new ObjCProtocol(ptr));
        Assert.Equal(ptr, (nint)new ObjCCache(ptr));

        var cls = new ObjCClass(ptr);
        var obj = (ObjCObject)cls;

        Assert.False(obj.IsNull);
        Assert.Equal(ptr, (nint)obj);
    }

    [Fact]
    public void HandleWrappersReportNull()
    {
        Assert.True(default(ObjCSel).IsNull);
        Assert.True(default(ObjCObject).IsNull);
        Assert.True(default(ObjCClass).IsNull);
        Assert.True(default(ObjCMethod).IsNull);
        Assert.True(default(ObjCIvar).IsNull);
        Assert.True(default(ObjCCategory).IsNull);
        Assert.True(default(ObjCProperty).IsNull);
        Assert.True(default(ObjCImp).IsNull);
        Assert.True(default(ObjCProtocol).IsNull);
        Assert.True(default(ObjCCache).IsNull);

        Assert.False(new ObjCMethod(1).IsNull);
    }
}
