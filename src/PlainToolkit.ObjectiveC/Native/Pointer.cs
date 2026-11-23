using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Native;

public interface IPointer
{
    public nint Ptr { get; init; }
}