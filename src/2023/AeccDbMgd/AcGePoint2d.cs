using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020001F8 RID: 504
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 16)]
internal struct AcGePoint2d
{
	// Token: 0x06000DD6 RID: 3542
	public unsafe static extern void <MarshalCopy>(AcGePoint2d* A_0, AcGePoint2d* A_1);

	// Token: 0x040006BF RID: 1727
	private double <alignment\u0020member>;
}
