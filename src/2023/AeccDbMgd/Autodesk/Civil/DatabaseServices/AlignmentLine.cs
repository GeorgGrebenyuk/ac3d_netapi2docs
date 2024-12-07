using System;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000792 RID: 1938
	public class AlignmentLine : AlignmentCurve
	{
		// Token: 0x1700063F RID: 1599
		public override extern AlignmentSubEntity this[int index]
		{
			get;
		}

		// Token: 0x1700063E RID: 1598
		// (set) Token: 0x06000F1F RID: 3871
		public override extern double Length { set; }

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06000F20 RID: 3872
		public extern AlignmentLineConstraintType Constraint2 { get; }

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06000F21 RID: 3873
		public extern double Direction { get; }

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06000F22 RID: 3874
		public extern Point2d MidPoint { get; }

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06000F23 RID: 3875
		// (set) Token: 0x06000F24 RID: 3876
		public extern Point2d PassThroughPoint1 { get; set; }

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06000F25 RID: 3877
		// (set) Token: 0x06000F26 RID: 3878
		public extern Point2d PassThroughPoint2 { get; set; }

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06000F27 RID: 3879
		// (set) Token: 0x06000F28 RID: 3880
		public extern string CurveGroupIndex { get; set; }

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06000F29 RID: 3881
		// (set) Token: 0x06000F2A RID: 3882
		public extern string CurveGroupSubEntityIndex { get; set; }

		// Token: 0x04001181 RID: 4481
		private int <SyntheticNonEmptyStructMarker>;
	}
}
