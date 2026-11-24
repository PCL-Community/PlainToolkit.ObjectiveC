using PlainToolkit.ObjectiveC.Runtime;

namespace PlainToolkit.ObjectiveC.Tests;

public class ObjCClassTest
{
    [Fact]
    public void ReadsClassMetadata()
    {
        var nsObject = ObjCClass.GetClass("NSObject");

        Assert.False(nsObject.IsNull);
        Assert.Equal("NSObject", nsObject.Name);
        Assert.True(nsObject.Superclass.IsNull);
        Assert.False(nsObject.IsMetaClass);
        Assert.True(nsObject.InstanceSize > 0);
    }

    [Fact]
    public void ObjectAndClassHandlesShareTheSamePointer()
    {
        var cls = ObjCClass.GetClass("NSObject");
        var obj = (ObjCObject)cls;

        Assert.Equal((nint)cls, (nint)obj);
        Assert.True(cls.IsMetaClass == false);
    }
}
