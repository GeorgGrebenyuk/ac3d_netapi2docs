using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020001F9 RID: 505
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 24)]
internal struct AcGePoint3d
{
	// Token: 0x06000DD7 RID: 3543
	public unsafe static extern void <MarshalCopy>(AcGePoint3d* A_0, AcGePoint3d* A_1);

	// Token: 0x040006C0 RID: 1728
	private double <alignment\u0020member>;
}
