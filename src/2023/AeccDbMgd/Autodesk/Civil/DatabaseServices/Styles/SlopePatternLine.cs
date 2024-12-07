using System;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F77 RID: 3959
	public sealed class SlopePatternLine : CivilWrapper<AeccDbSlopePatternStyle>
	{
		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06001E4B RID: 7755
		// (set) Token: 0x06001E4C RID: 7756
		public extern SlopePatternStartType StartType { get; set; }

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06001E4D RID: 7757
		// (set) Token: 0x06001E4E RID: 7758
		public extern SlopePatternLengthType LengthType { get; set; }

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06001E4F RID: 7759
		// (set) Token: 0x06001E50 RID: 7760
		public extern double PercentofLength { get; set; }

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06001E51 RID: 7761
		// (set) Token: 0x06001E52 RID: 7762
		public extern double MaximumLength { get; set; }

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06001E53 RID: 7763
		// (set) Token: 0x06001E54 RID: 7764
		public extern double Length { get; set; }

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06001E55 RID: 7765
		// (set) Token: 0x06001E56 RID: 7766
		public extern double PercentofLength1 { get; set; }

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06001E57 RID: 7767
		// (set) Token: 0x06001E58 RID: 7768
		public extern double PercentofLength2 { get; set; }

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06001E59 RID: 7769
		// (set) Token: 0x06001E5A RID: 7770
		public extern double Grade1 { get; set; }

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06001E5B RID: 7771
		// (set) Token: 0x06001E5C RID: 7772
		public extern double Grade2 { get; set; }

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06001E5D RID: 7773
		// (set) Token: 0x06001E5E RID: 7774
		public extern string Linetype { get; set; }

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06001E5F RID: 7775
		// (set) Token: 0x06001E60 RID: 7776
		public extern LineWeight LineWeight { get; set; }

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06001E61 RID: 7777
		// (set) Token: 0x06001E62 RID: 7778
		public extern Color Color { get; set; }

		// Token: 0x04001851 RID: 6225
		private int <SyntheticNonEmptyStructMarker>;
	}
}
