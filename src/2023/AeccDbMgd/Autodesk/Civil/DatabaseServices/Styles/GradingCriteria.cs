using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000C1 RID: 193
	[Wrapper("AeccDbGradingCriteria")]
	public sealed class GradingCriteria : StyleBase
	{
		// Token: 0x06000855 RID: 2133
		public sealed override extern ObjectId CopyAsSibling(string criteriaName);

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000856 RID: 2134
		// (set) Token: 0x06000857 RID: 2135
		public extern GradingTargetType Target { get; set; }

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000858 RID: 2136
		// (set) Token: 0x06000859 RID: 2137
		public extern GradingSurfaceProjectionType SurfaceProjectionType { get; set; }

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x0600085A RID: 2138
		// (set) Token: 0x0600085B RID: 2139
		public extern GradingElevationProjectionType ElevationProjectionType { get; set; }

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600085C RID: 2140
		// (set) Token: 0x0600085D RID: 2141
		public extern GradingRelativeElevationProjectionType RelativeElevationProjectionType { get; set; }

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600085E RID: 2142
		// (set) Token: 0x0600085F RID: 2143
		public extern GradingDistanceProjectionType DistanceProjectionType { get; set; }

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000860 RID: 2144
		public extern PropertyEnum<GradingSearchOrderType> SearchOrder { get; }

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000861 RID: 2145
		public extern PropertyDouble ProjectionRelativeElevation { get; }

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000862 RID: 2146
		public extern PropertyDouble RelativeElevation { get; }

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000863 RID: 2147
		public extern PropertyDouble Elevation { get; }

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000864 RID: 2148
		public extern PropertyDouble Distance { get; }

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000865 RID: 2149
		public extern PropertyDouble ProjectionDistance { get; }

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000866 RID: 2150
		public extern PropertyEnum<GradingSlopeFormatType> CutSlopeFormatType { get; }

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000867 RID: 2151
		public extern PropertyDouble CutSlope { get; }

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000868 RID: 2152
		public extern PropertyEnum<GradingSlopeFormatType> FillSlopeFormatType { get; }

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000869 RID: 2153
		public extern PropertyDouble FillSlope { get; }

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x0600086A RID: 2154
		public extern PropertyEnum<GradingSlopeFormatType> SlopeFormatType { get; }

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600086B RID: 2155
		public extern PropertyDouble Slope { get; }

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600086C RID: 2156
		public extern PropertyEnum<GradingInteriorCornerOverlapSolutionType> InteriorCornerOverlap { get; }
	}
}
