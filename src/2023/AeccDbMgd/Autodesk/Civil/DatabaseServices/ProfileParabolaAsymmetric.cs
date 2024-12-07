using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000F14 RID: 3860
	public class ProfileParabolaAsymmetric : ProfileEntity
	{
		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06001D28 RID: 7464
		public override extern ProfileEntityType EntityType { get; }

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06001D29 RID: 7465
		public extern VerticalCurveType CurveType { get; }

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06001D2A RID: 7466
		public extern double PVIStation { get; }

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06001D2B RID: 7467
		public extern double PVIElevation { get; }

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06001D2C RID: 7468
		public extern double GradeIn { get; }

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06001D2D RID: 7469
		public extern double GradeOut { get; }

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06001D2E RID: 7470
		public extern double GradeChange { get; }

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06001D2F RID: 7471
		// (set) Token: 0x06001D30 RID: 7472
		public extern double K { get; set; }

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06001D31 RID: 7473
		public extern double HighLowPointStation { get; }

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06001D32 RID: 7474
		public extern double HighLowPointElevation { get; }

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06001D33 RID: 7475
		public extern double TangentOffsetAtPVI { get; }

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06001D34 RID: 7476
		// (set) Token: 0x06001D35 RID: 7477
		public extern double AsymmetricLength1 { get; set; }

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06001D36 RID: 7478
		// (set) Token: 0x06001D37 RID: 7479
		public extern double AsymmetricLength2 { get; set; }
	}
}
