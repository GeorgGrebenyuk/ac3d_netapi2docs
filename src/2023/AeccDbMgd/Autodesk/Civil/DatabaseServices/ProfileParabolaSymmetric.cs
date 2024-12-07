using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000F15 RID: 3861
	public class ProfileParabolaSymmetric : ProfileEntity
	{
		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06001D38 RID: 7480
		public override extern ProfileEntityType EntityType { get; }

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06001D39 RID: 7481
		public extern VerticalCurveType CurveType { get; }

		// Token: 0x06001D3A RID: 7482
		public extern double GetPassingSightDistance(double eyeHeight, double objectHeight);

		// Token: 0x06001D3B RID: 7483
		public extern void SetPassingSightDistance(double eyeHeight, double objectHeight, double distance);

		// Token: 0x06001D3C RID: 7484
		public extern double GetStoppingSightDistance(double eyeHeight, double objectHeight);

		// Token: 0x06001D3D RID: 7485
		public extern void SetStoppingSightDistance(double eyeHeight, double objectHeight, double distance);

		// Token: 0x06001D3E RID: 7486
		public extern double GetHeadlightSightDistance(double maxAngle, double headlightHeight);

		// Token: 0x06001D3F RID: 7487
		public extern void SetHeadlightSightDistance(double maxAngle, double headlightHeight, double distance);

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06001D40 RID: 7488
		public extern double PVIStation { get; }

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06001D41 RID: 7489
		public extern double PVIElevation { get; }

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06001D42 RID: 7490
		public extern double GradeIn { get; }

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06001D43 RID: 7491
		public extern double GradeOut { get; }

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06001D44 RID: 7492
		public extern double GradeChange { get; }

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06001D45 RID: 7493
		// (set) Token: 0x06001D46 RID: 7494
		public extern double K { get; set; }

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06001D47 RID: 7495
		// (set) Token: 0x06001D48 RID: 7496
		public extern double Radius { get; set; }

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06001D49 RID: 7497
		public extern double HighLowPointStation { get; }

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06001D4A RID: 7498
		public extern double HighLowPointElevation { get; }

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06001D4B RID: 7499
		public extern double TangentOffsetAtPVI { get; }

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06001D4C RID: 7500
		public extern double M { get; }

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06001D4D RID: 7501
		// (set) Token: 0x06001D4E RID: 7502
		public extern double ThroughPoint1Station { get; set; }

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06001D4F RID: 7503
		// (set) Token: 0x06001D50 RID: 7504
		public extern double ThroughPoint1Elevation { get; set; }

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06001D51 RID: 7505
		// (set) Token: 0x06001D52 RID: 7506
		public extern double ThroughPoint2Station { get; set; }

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06001D53 RID: 7507
		// (set) Token: 0x06001D54 RID: 7508
		public extern double ThroughPoint2Elevation { get; set; }

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06001D55 RID: 7509
		// (set) Token: 0x06001D56 RID: 7510
		public extern double ThroughPoint3Station { get; set; }

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06001D57 RID: 7511
		// (set) Token: 0x06001D58 RID: 7512
		public extern double ThroughPoint3Elevation { get; set; }

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06001D59 RID: 7513
		// (set) Token: 0x06001D5A RID: 7514
		public extern double GradeAtThroughPoint1 { get; set; }

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06001D5B RID: 7515
		// (set) Token: 0x06001D5C RID: 7516
		public extern double GradeAtThroughPoint2 { get; set; }
	}
}
