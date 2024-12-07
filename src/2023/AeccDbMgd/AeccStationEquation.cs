using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000C20 RID: 3104
[UnsafeValueType]
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 64)]
internal struct AeccStationEquation
{
	// Token: 0x06001731 RID: 5937
	public unsafe static extern void <MarshalCopy>(AeccStationEquation* A_0, AeccStationEquation* A_1);

	// Token: 0x06001732 RID: 5938
	public unsafe static extern void <MarshalDestroy>(AeccStationEquation* A_0);

	// Token: 0x040015A2 RID: 5538
	private long <alignment\u0020member>;
}
