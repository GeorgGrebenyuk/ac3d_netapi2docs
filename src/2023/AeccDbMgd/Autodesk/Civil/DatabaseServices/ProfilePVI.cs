using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000F16 RID: 3862
	public class ProfilePVI : CivilWrapper<AeccDbVAlignment>
	{
		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06001D5D RID: 7517
		public extern ProfileEntity VerticalCurve { get; }

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06001D5E RID: 7518
		public extern ProfileEntityType PVIType { get; }

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06001D5F RID: 7519
		// (set) Token: 0x06001D60 RID: 7520
		public extern double Station { get; set; }

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06001D61 RID: 7521
		// (set) Token: 0x06001D62 RID: 7522
		public extern double Elevation { get; set; }

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06001D63 RID: 7523
		// (set) Token: 0x06001D64 RID: 7524
		public extern double GradeIn { get; set; }

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06001D65 RID: 7525
		// (set) Token: 0x06001D66 RID: 7526
		public extern double GradeOut { get; set; }

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06001D67 RID: 7527
		// (set) Token: 0x06001D68 RID: 7528
		public extern double PassingSightDistance { get; set; }

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06001D69 RID: 7529
		// (set) Token: 0x06001D6A RID: 7530
		public extern double StoppingSightDistance { get; set; }

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06001D6B RID: 7531
		// (set) Token: 0x06001D6C RID: 7532
		public extern double HeadlightSightDistance { get; set; }

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06001D6D RID: 7533
		public extern uint EntityBefore { get; }

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06001D6E RID: 7534
		public extern uint EntityAfter { get; }

		// Token: 0x040017FE RID: 6142
		private int <SyntheticNonEmptyStructMarker>;
	}
}
