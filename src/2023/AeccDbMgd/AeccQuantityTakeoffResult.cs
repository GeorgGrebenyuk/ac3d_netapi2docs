using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000B67 RID: 2919
[NativeCppClass]
[UnsafeValueType]
[StructLayout(LayoutKind.Sequential, Size = 72)]
internal struct AeccQuantityTakeoffResult
{
	// Token: 0x040014F7 RID: 5367
	private long <alignment\u0020member>;

	// Token: 0x02000B68 RID: 2920
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum ResultType
	{

	}

	// Token: 0x02000B69 RID: 2921
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum ResultStatus
	{

	}

	// Token: 0x02000B6A RID: 2922
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 80)]
	public struct QTO_AREA
	{
		// Token: 0x040014FA RID: 5370
		private double <alignment\u0020member>;
	}

	// Token: 0x02000B6B RID: 2923
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 48)]
	public struct QTO_VOLUME
	{
		// Token: 0x040014FB RID: 5371
		private double <alignment\u0020member>;
	}

	// Token: 0x02000B6C RID: 2924
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 136)]
	public struct SECTIONAL_RESULT
	{
		// Token: 0x040014FC RID: 5372
		private long <alignment\u0020member>;
	}
}
