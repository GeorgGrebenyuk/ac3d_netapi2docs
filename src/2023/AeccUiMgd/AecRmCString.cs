using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000061 RID: 97
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 8)]
internal struct AecRmCString
{
	// Token: 0x06000014 RID: 20
	public unsafe static extern void <MarshalCopy>(AecRmCString* A_0, AecRmCString* A_1);

	// Token: 0x06000015 RID: 21
	public unsafe static extern void <MarshalDestroy>(AecRmCString* A_0);

	// Token: 0x0400008A RID: 138
	private long <alignment\u0020member>;
}
