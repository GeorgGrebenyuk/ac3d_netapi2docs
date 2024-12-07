using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009D8 RID: 2520
	public sealed class TerrainSurfaceProperties
	{
		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060012A9 RID: 4777
		public extern double SurfaceArea2D { get; }

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x060012AA RID: 4778
		public extern double SurfaceArea3D { get; }

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x060012AB RID: 4779
		public extern double MinimumGradeOrSlope { get; }

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060012AC RID: 4780
		public extern double MaximumGradeOrSlope { get; }

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060012AD RID: 4781
		public extern double MeanGradeOrSlope { get; }

		// Token: 0x040013CE RID: 5070
		private int <SyntheticNonEmptyStructMarker>;
	}
}
