using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000F12 RID: 3858
	public class ProfileCircular : ProfileEntity
	{
		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06001D0F RID: 7439
		public override extern ProfileEntityType EntityType { get; }

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06001D10 RID: 7440
		public extern VerticalCurveType CurveType { get; }

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06001D11 RID: 7441
		public extern double PVIStation { get; }

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06001D12 RID: 7442
		public extern double PVIElevation { get; }

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06001D13 RID: 7443
		public extern double GradeIn { get; }

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06001D14 RID: 7444
		public extern double GradeOut { get; }

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06001D15 RID: 7445
		public extern double GradeChange { get; }

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06001D16 RID: 7446
		// (set) Token: 0x06001D17 RID: 7447
		public extern double K { get; set; }

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06001D18 RID: 7448
		// (set) Token: 0x06001D19 RID: 7449
		public extern double Radius { get; set; }

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06001D1A RID: 7450
		public extern double HighLowPointStation { get; }

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06001D1B RID: 7451
		public extern double HighLowPointElevation { get; }

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06001D1C RID: 7452
		public extern double TangentOffsetAtPVI { get; }

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06001D1D RID: 7453
		public extern double M { get; }
	}
}
