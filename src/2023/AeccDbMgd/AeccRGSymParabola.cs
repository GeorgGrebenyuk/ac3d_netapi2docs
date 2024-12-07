using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000C6F RID: 3183
[NativeCppClass]
[UnsafeValueType]
[StructLayout(LayoutKind.Sequential, Size = 344)]
internal struct AeccRGSymParabola
{
	// Token: 0x040015E9 RID: 5609
	private long <alignment\u0020member>;

	// Token: 0x02000C70 RID: 3184
	[CLSCompliant(false)]
	[UnsafeValueType]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 128)]
	public struct _constraintDataSymParabola
	{
		// Token: 0x06001733 RID: 5939
		public unsafe static extern void <MarshalCopy>(AeccRGSymParabola._constraintDataSymParabola* A_0, AeccRGSymParabola._constraintDataSymParabola* A_1);

		// Token: 0x040015EA RID: 5610
		private long <alignment\u0020member>;
	}
}
