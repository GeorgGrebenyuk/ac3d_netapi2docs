using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x0200006D RID: 109
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 8)]
internal struct AecRmCString
{
	// Token: 0x06000143 RID: 323
	public unsafe static extern void <MarshalCopy>(AecRmCString* A_0, AecRmCString* A_1);

	// Token: 0x06000144 RID: 324
	public unsafe static extern void <MarshalDestroy>(AecRmCString* A_0);

	// Token: 0x0400010B RID: 267
	private long <alignment\u0020member>;
}
