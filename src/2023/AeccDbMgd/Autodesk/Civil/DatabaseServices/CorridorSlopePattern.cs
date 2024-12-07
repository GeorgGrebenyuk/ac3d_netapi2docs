using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000BB9 RID: 3001
	public sealed class CorridorSlopePattern : CivilWrapper<AeccDbCorridor>
	{
		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x0600169B RID: 5787
		public extern ObjectId CorridorId { get; }

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x0600169C RID: 5788
		// (set) Token: 0x0600169D RID: 5789
		public extern ObjectId StyleId { get; set; }

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x0600169E RID: 5790
		// (set) Token: 0x0600169F RID: 5791
		public extern string StyleName { get; set; }

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x060016A0 RID: 5792
		public extern CorridorFeatureLine FeatureLine1 { get; }

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x060016A1 RID: 5793
		public extern CorridorFeatureLine FeatureLine2 { get; }

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x060016A2 RID: 5794
		public extern ObjectId BaselineId { get; }

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x060016A3 RID: 5795
		// (set) Token: 0x060016A4 RID: 5796
		public extern double StartStation { get; set; }

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x060016A5 RID: 5797
		// (set) Token: 0x060016A6 RID: 5798
		public extern double EndStation { get; set; }

		// Token: 0x0400153D RID: 5437
		private int <SyntheticNonEmptyStructMarker>;
	}
}
