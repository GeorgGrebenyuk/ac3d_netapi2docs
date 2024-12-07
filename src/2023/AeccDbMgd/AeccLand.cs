using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020002BF RID: 703
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 8)]
internal struct AeccLand
{
	// Token: 0x040009A4 RID: 2468
	private long <alignment\u0020member>;

	// Token: 0x020002C0 RID: 704
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum SurfaceType
	{

	}

	// Token: 0x020002C1 RID: 705
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 120)]
	public struct AeccSurfaceCreationData
	{
		// Token: 0x040009A6 RID: 2470
		private long <alignment\u0020member>;
	}

	// Token: 0x020002C2 RID: 706
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum DwgObjectType
	{

	}

	// Token: 0x020002C3 RID: 707
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 256)]
	public struct AeccSurfaceStatistics
	{
		// Token: 0x040009A8 RID: 2472
		private long <alignment\u0020member>;
	}

	// Token: 0x020002C4 RID: 708
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 200)]
	public struct AeccOffsetHACreationData
	{
		// Token: 0x040009A9 RID: 2473
		private long <alignment\u0020member>;
	}

	// Token: 0x020002C5 RID: 709
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 112)]
	public struct AeccOffsetVACreationData
	{
		// Token: 0x040009AA RID: 2474
		private long <alignment\u0020member>;
	}

	// Token: 0x020002C6 RID: 710
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum RegionType
	{

	}

	// Token: 0x020002C7 RID: 711
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum eMaskCreationStatus
	{

	}

	// Token: 0x020002C8 RID: 712
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 80)]
	public struct AeccSurfaceMaskCreationData
	{
		// Token: 0x040009AD RID: 2477
		private long <alignment\u0020member>;
	}
}
