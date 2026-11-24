namespace PlainToolkit.ObjectiveC.Native;

public interface IPointer
{
    public nint Ptr { get; init; }

    public bool IsNull { get; }
}
