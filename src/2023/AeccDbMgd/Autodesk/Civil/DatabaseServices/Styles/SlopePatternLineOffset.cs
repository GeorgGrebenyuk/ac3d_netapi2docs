using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F78 RID: 3960
	public sealed class SlopePatternLineOffset : CivilWrapper<AeccDbSlopePatternStyle>
	{
		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06001E63 RID: 7779
		// (set) Token: 0x06001E64 RID: 7780
		public extern SlopePatternOffsetType OffsetType { get; set; }

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06001E65 RID: 7781
		// (set) Token: 0x06001E66 RID: 7782
		public extern double PercentofLength { get; set; }

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06001E67 RID: 7783
		// (set) Token: 0x06001E68 RID: 7784
		public extern double MinimumDistance { get; set; }

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06001E69 RID: 7785
		// (set) Token: 0x06001E6A RID: 7786
		public extern double MaximumDistance { get; set; }

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06001E6B RID: 7787
		// (set) Token: 0x06001E6C RID: 7788
		public extern double RadialOffsetAngle { get; set; }

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06001E6D RID: 7789
		// (set) Token: 0x06001E6E RID: 7790
		public extern double Distance { get; set; }

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06001E6F RID: 7791
		// (set) Token: 0x06001E70 RID: 7792
		public extern int Numberoflines { get; set; }

		// Token: 0x04001852 RID: 6226
		private int <SyntheticNonEmptyStructMarker>;
	}
}
