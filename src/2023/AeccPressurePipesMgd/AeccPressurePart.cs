using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020000F3 RID: 243
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 104)]
internal struct AeccPressurePart
{
	// Token: 0x04000184 RID: 388
	private long <alignment\u0020member>;

	// Token: 0x020000F4 RID: 244
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum State
	{

	}

	// Token: 0x020000F5 RID: 245
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct EqualTo
	{
		// Token: 0x04000186 RID: 390
		private long <alignment\u0020member>;
	}

	// Token: 0x020000F6 RID: 246
	[CLSCompliant(false)]
	[NativeCppClass]
	public struct LessThan
	{
	}
}
