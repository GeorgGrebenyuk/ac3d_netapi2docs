using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020001FB RID: 507
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 40)]
internal struct AcCmColor
{
	// Token: 0x06000DD9 RID: 3545
	public unsafe static extern void <MarshalCopy>(AcCmColor* A_0, AcCmColor* A_1);

	// Token: 0x06000DDA RID: 3546
	public unsafe static extern void <MarshalDestroy>(AcCmColor* A_0);

	// Token: 0x040006C2 RID: 1730
	private long <alignment\u0020member>;
}
