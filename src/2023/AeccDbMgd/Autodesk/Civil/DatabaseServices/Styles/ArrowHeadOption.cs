using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F45 RID: 3909
	public sealed class ArrowHeadOption : CivilWrapper<AeccDbStyle>
	{
		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06001D7A RID: 7546
		// (set) Token: 0x06001D7B RID: 7547
		public extern ArrowHeadType ArrowType { get; set; }

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06001D7C RID: 7548
		// (set) Token: 0x06001D7D RID: 7549
		public extern string ArrowBlockName { get; set; }

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06001D7E RID: 7550
		// (set) Token: 0x06001D7F RID: 7551
		public extern ArrowHeadSizeType SizeOption { get; set; }

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06001D80 RID: 7552
		// (set) Token: 0x06001D81 RID: 7553
		public extern double SizeValue { get; set; }

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06001D82 RID: 7554
		// (set) Token: 0x06001D83 RID: 7555
		public extern ArrowHeadFitType Fit { get; set; }

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06001D84 RID: 7556
		// (set) Token: 0x06001D85 RID: 7557
		public extern double FixedScaleX { get; set; }

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06001D86 RID: 7558
		public extern double FixedScaleY { get; }

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06001D87 RID: 7559
		public extern double FixedScaleZ { get; }
	}
}
