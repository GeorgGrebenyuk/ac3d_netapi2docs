using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x0200029D RID: 669
[UnsafeValueType]
[NativeCppClass]
[StructLayout(LayoutKind.Sequential, Size = 328)]
internal struct AeccDbSurfaceStyle
{
	// Token: 0x04000980 RID: 2432
	private long <alignment\u0020member>;

	// Token: 0x0200029E RID: 670
	[NativeCppClass]
	[CLSCompliant(false)]
	[StructLayout(LayoutKind.Sequential, Size = 144)]
	public struct DefaultContourValues
	{
		// Token: 0x04000981 RID: 2433
		private long <alignment\u0020member>;
	}

	// Token: 0x0200029F RID: 671
	[CLSCompliant(false)]
	[NativeCppClass]
	[StructLayout(LayoutKind.Sequential, Size = 48)]
	public struct AeccWSHatchData
	{
		// Token: 0x06000DDD RID: 3549
		public unsafe static extern void <MarshalCopy>(AeccDbSurfaceStyle.AeccWSHatchData* A_0, AeccDbSurfaceStyle.AeccWSHatchData* A_1);

		// Token: 0x06000DDE RID: 3550
		public unsafe static extern void <MarshalDestroy>(AeccDbSurfaceStyle.AeccWSHatchData* A_0);

		// Token: 0x04000982 RID: 2434
		private long <alignment\u0020member>;
	}

	// Token: 0x020002A0 RID: 672
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum TriangleDisplayMode
	{

	}

	// Token: 0x020002A1 RID: 673
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum GriddedDisplayMode
	{

	}

	// Token: 0x020002A2 RID: 674
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum PointDisplayMode
	{

	}

	// Token: 0x020002A3 RID: 675
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum PointDisplayTextMode
	{

	}

	// Token: 0x020002A4 RID: 676
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum BorderDisplayMode
	{

	}

	// Token: 0x020002A5 RID: 677
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum WatershedDisplayMode
	{

	}

	// Token: 0x020002A6 RID: 678
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum ContourDisplayMode
	{

	}

	// Token: 0x020002A7 RID: 679
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum ContourDisplayLabelAlongMode
	{

	}

	// Token: 0x020002A8 RID: 680
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum ContourDisplayLabelDirectionMode
	{

	}

	// Token: 0x020002A9 RID: 681
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum ContourDisplayLabelEnclosureMode
	{

	}

	// Token: 0x020002AA RID: 682
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum SlopeVectorDisplayMode
	{

	}

	// Token: 0x020002AB RID: 683
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum SlopeVectorDisplayLocationMode
	{

	}

	// Token: 0x020002AC RID: 684
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum SlopeVectorDisplayVisibilityMode
	{

	}

	// Token: 0x020002AD RID: 685
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum CodedElevationsDisplayMode
	{

	}

	// Token: 0x020002AE RID: 686
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum CodedElevationsDisplayVisibilityMode
	{

	}

	// Token: 0x020002AF RID: 687
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum CodedElevationsDisplayEntityMode
	{

	}

	// Token: 0x020002B0 RID: 688
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum CodedSlopesDisplayMode
	{

	}

	// Token: 0x020002B1 RID: 689
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum CodedSlopesDisplayVisibilityMode
	{

	}

	// Token: 0x020002B2 RID: 690
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum CodedSlopesDisplayEntityMode
	{

	}

	// Token: 0x020002B3 RID: 691
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum CodedDirectionsDisplayMode
	{

	}

	// Token: 0x020002B4 RID: 692
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum CodedDirectionsDisplayVisibilityMode
	{

	}

	// Token: 0x020002B5 RID: 693
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum CodedDirectionsDisplayEntityMode
	{

	}

	// Token: 0x020002B6 RID: 694
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum AnalysisAlgorithm
	{

	}

	// Token: 0x020002B7 RID: 695
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum SlopeArrowType
	{

	}

	// Token: 0x020002B8 RID: 696
	[NativeCppClass]
	[CLSCompliant(false)]
	public enum DisplayComponents
	{

	}

	// Token: 0x020002B9 RID: 697
	[CLSCompliant(false)]
	[NativeCppClass]
	public enum RangesCreationMethod
	{

	}
}
