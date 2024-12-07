using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020001EF RID: 495
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 8)]
internal struct AecRmCString
{
	// Token: 0x06000DD2 RID: 3538
	public unsafe static extern void <MarshalCopy>(AecRmCString* A_0, AecRmCString* A_1);

	// Token: 0x06000DD3 RID: 3539
	public unsafe static extern void <MarshalDestroy>(AecRmCString* A_0);

	// Token: 0x040006B6 RID: 1718
	private long <alignment\u0020member>;
}
