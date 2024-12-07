using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020001F6 RID: 502
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 4)]
internal struct AeccAtom
{
	// Token: 0x06000DD4 RID: 3540
	public unsafe static extern void <MarshalCopy>(AeccAtom* A_0, AeccAtom* A_1);

	// Token: 0x06000DD5 RID: 3541
	public unsafe static extern void <MarshalDestroy>(AeccAtom* A_0);

	// Token: 0x040006BD RID: 1725
	private int <alignment\u0020member>;

	// Token: 0x020001F7 RID: 503
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 24)]
	public struct AtomInfo
	{
		// Token: 0x040006BE RID: 1726
		private long <alignment\u0020member>;
	}
}
