using System.Runtime.InteropServices;

namespace Dova.Internals.Types.Objects;

[StructLayout(LayoutKind.Explicit)]
internal readonly struct JObject
{
    [FieldOffset(0)] 
    private readonly IntPtr ptr;

    private JObject(IntPtr value)
    {
        this.ptr = value;
    }

    public override string ToString() => ptr.ToString();

    public static implicit operator JObject(IntPtr value) => new (value);

    public static implicit operator IntPtr(JObject value) => value.ptr;
}