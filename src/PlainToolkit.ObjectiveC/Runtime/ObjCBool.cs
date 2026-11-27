using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 对应 Objective-C 运行时的 <c>BOOL</c>。
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public readonly struct ObjCBool : IEquatable<ObjCBool>
{
    /// <summary>
    /// 底层字节值。
    /// </summary>
    public readonly byte Value;

    public ObjCBool(byte value) => Value = value;

    /// <summary>
    /// <c>NO</c>，即 <see langword="false"/>。
    /// </summary>
    public static readonly ObjCBool NO = new(0);

    /// <summary>
    /// <c>YES</c>，即 <see langword="true"/>。
    /// </summary>
    public static readonly ObjCBool YES = new(1);

    public static implicit operator ObjCBool(bool value) => value ? YES : NO;

    public static implicit operator bool(ObjCBool value) => value.Value != 0;

    public static explicit operator byte(ObjCBool value) => value.Value;

    public static explicit operator ObjCBool(byte value) => new(value);
    
    public bool Equals(ObjCBool other) => Value == other.Value;
    
    public override bool Equals(object? obj) => obj is ObjCBool other && Equals(other);
    
    public override int GetHashCode() => Value;

    public static bool operator ==(ObjCBool left, ObjCBool right) => left.Value == right.Value;

    public static bool operator !=(ObjCBool left, ObjCBool right) => left.Value != right.Value;
    
    public override string ToString() => Value switch
    {
        0 => nameof(NO),
        1 => nameof(YES),
        _ => Value.ToString()
    };
}
