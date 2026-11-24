using System.Runtime.InteropServices;

namespace PlainToolkit.ObjectiveC.Runtime;

/// <summary>
/// 对应 Objective-C 运行时的 <c>BOOL</c>。
/// </summary>
/// <remarks>
/// <para>
/// <c>BOOL</c> 在 64 位 Apple 平台上占 1 个字节，因此底层使用一个 <see cref="byte"/> 字段。
/// </para>
/// <para>
/// Apple 将 <c>YES</c> 定义为 <c>1</c>、<c>NO</c> 定义为 <c>0</c>。某些原生代码可能返回其他非零值
/// （例如 x86_64 上 <c>signed char</c> 的 <c>-1</c>，按无符号字节读作 255）；它们是“真”，
/// 但不是规范的 <c>YES</c>，因此判断 BOOL 时应使用 <c>!= NO</c>，而不是只与 <c>YES</c> 比较。
/// </para>
/// <para>
/// C# 的 <see langword="enum"/> 不能声明 <c>implicit operator</c>，因此这里使用 1 字节的
/// <see langword="readonly struct"/> 来提供与 <see cref="bool"/> 的隐式转换，同时保持与原生
/// <c>BOOL</c> 相同的内存布局。
/// </para>
/// </remarks>
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

    /// <inheritdoc />
    public bool Equals(ObjCBool other) => Value == other.Value;

    /// <inheritdoc />
    public override bool Equals(object? obj) => obj is ObjCBool other && Equals(other);

    /// <inheritdoc />
    public override int GetHashCode() => Value;

    public static bool operator ==(ObjCBool left, ObjCBool right) => left.Value == right.Value;

    public static bool operator !=(ObjCBool left, ObjCBool right) => left.Value != right.Value;

    /// <inheritdoc />
    public override string ToString() => Value switch
    {
        0 => nameof(NO),
        1 => nameof(YES),
        _ => Value.ToString()
    };
}
