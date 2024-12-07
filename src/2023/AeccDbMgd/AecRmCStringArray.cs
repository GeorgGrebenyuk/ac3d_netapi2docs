using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x0200049F RID: 1183
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 24)]
internal struct AecRmCStringArray
{
	// Token: 0x06000DE3 RID: 3555
	public unsafe static extern void <MarshalCopy>(AecRmCStringArray* A_0, AecRmCStringArray* A_1);

	// Token: 0x06000DE4 RID: 3556
	public unsafe static extern void <MarshalDestroy>(AecRmCStringArray* A_0);

	// Token: 0x04000E9F RID: 3743
	private long <alignment\u0020member>;
}
