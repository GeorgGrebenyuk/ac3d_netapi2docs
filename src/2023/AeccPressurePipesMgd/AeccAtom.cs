using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020000D4 RID: 212
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 4)]
internal struct AeccAtom
{
	// Token: 0x06000145 RID: 325
	public unsafe static extern void <MarshalCopy>(AeccAtom* A_0, AeccAtom* A_1);

	// Token: 0x06000146 RID: 326
	public unsafe static extern void <MarshalDestroy>(AeccAtom* A_0);

	// Token: 0x0400016A RID: 362
	private int <alignment\u0020member>;
}
