using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct PTMaterial
{
    [FieldOffset(0)]
    public Vector3 Albedo;
    [FieldOffset(12)]
    public float metallic;
    [FieldOffset(16)]
    public float smoothness;
    [FieldOffset(20)]
    public int isLight;
}