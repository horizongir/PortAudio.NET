// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Runtime.InteropServices;

namespace PortAudioNet
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct PaHostErrorInfo
    {
        [FieldOffset(0)] public PaHostApiTypeId hostApiType;

        [FieldOffset(4)] public int errorCode;

        [FieldOffset(8)] public byte* errorText;
    }
}