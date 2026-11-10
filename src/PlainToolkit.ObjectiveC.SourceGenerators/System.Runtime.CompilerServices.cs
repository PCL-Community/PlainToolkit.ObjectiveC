using System.ComponentModel;

// ReSharper disable once CheckNamespace
namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class InterceptsLocationAttribute(int version, string data) : Attribute;

[EditorBrowsable(EditorBrowsableState.Never)]
internal static class IsExternalInit;