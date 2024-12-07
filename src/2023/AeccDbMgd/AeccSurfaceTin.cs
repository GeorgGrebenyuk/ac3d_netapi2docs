using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020002EE RID: 750
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 48)]
internal struct AeccSurfaceTin
{
	// Token: 0x040009D3 RID: 2515
	private long <alignment\u0020member>;

	// Token: 0x020002EF RID: 751
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum AeccSurfaceTinGeneralOptions
	{

	}

	// Token: 0x020002F0 RID: 752
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum AeccSurfaceTinTrianglePoint
	{

	}

	// Token: 0x020002F1 RID: 753
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum AeccSurfaceTinTriangleEdge
	{

	}

	// Token: 0x020002F2 RID: 754
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum ClockwiseType
	{

	}

	// Token: 0x020002F3 RID: 755
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum AeccSurfaceTinTriangulatePhase
	{

	}

	// Token: 0x020002F4 RID: 756
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum SimplifyType
	{

	}

	// Token: 0x020002F5 RID: 757
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum QuantityType
	{

	}

	// Token: 0x020002F6 RID: 758
	[NativeCppClass]
	[CLSCompliant(false)]
	[UnsafeValueType]
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public struct SimplifyQuantityValues
	{
		// Token: 0x040009DB RID: 2523
		private double <alignment\u0020member>;
	}

	// Token: 0x020002F7 RID: 759
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum SimplifyRegionOpts
	{

	}

	// Token: 0x020002F8 RID: 760
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public struct AeccSurfaceTinEdge
	{
		// Token: 0x040009DD RID: 2525
		private int <alignment\u0020member>;
	}

	// Token: 0x020002F9 RID: 761
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 64)]
	public struct AeccSurfaceTinTriangulateCallbacks
	{
		// Token: 0x040009DE RID: 2526
		private long <alignment\u0020member>;
	}

	// Token: 0x020002FA RID: 762
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum ElevationMethod
	{

	}

	// Token: 0x020002FB RID: 763
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 88)]
	public struct RefineOption
	{
		// Token: 0x040009E0 RID: 2528
		private long <alignment\u0020member>;
	}

	// Token: 0x020002FC RID: 764
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 40)]
	public struct CoherencyData
	{
		// Token: 0x040009E1 RID: 2529
		private double <alignment\u0020member>;
	}
}
