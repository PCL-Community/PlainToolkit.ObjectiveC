using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Native;

public interface Pointer
{
    public nint Ptr { get; init; }
}