using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000763 RID: 1891
	public sealed class AlignmentSubEntityArc : AlignmentSubEntity
	{
		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06000EBE RID: 3774
		public override extern AlignmentSubEntityType SubEntityType { get; }

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06000EBF RID: 3775
		// (set) Token: 0x06000EC0 RID: 3776
		public extern Point2d CenterPoint { get; set; }

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06000EC1 RID: 3777
		// (set) Token: 0x06000EC2 RID: 3778
		public extern double Radius { get; set; }

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06000EC3 RID: 3779
		public extern double StartDirection { get; }

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06000EC4 RID: 3780
		public extern double EndDirection { get; }

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06000EC5 RID: 3781
		// (set) Token: 0x06000EC6 RID: 3782
		public extern double Delta { get; set; }

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06000EC7 RID: 3783
		// (set) Token: 0x06000EC8 RID: 3784
		public extern double ChordLength { get; set; }

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06000EC9 RID: 3785
		public extern double ChordDirection { get; }

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06000ECA RID: 3786
		// (set) Token: 0x06000ECB RID: 3787
		public extern double ExternalSecant { get; set; }

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06000ECC RID: 3788
		// (set) Token: 0x06000ECD RID: 3789
		public extern double ExternalTangent { get; set; }

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06000ECE RID: 3790
		// (set) Token: 0x06000ECF RID: 3791
		public extern double MidOrdinate { get; set; }

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06000ED0 RID: 3792
		// (set) Token: 0x06000ED1 RID: 3793
		public extern Point2d PassThroughPoint1 { get; set; }

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06000ED2 RID: 3794
		// (set) Token: 0x06000ED3 RID: 3795
		public extern Point2d PassThroughPoint2 { get; set; }

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06000ED4 RID: 3796
		// (set) Token: 0x06000ED5 RID: 3797
		public extern Point2d PassThroughPoint3 { get; set; }

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06000ED6 RID: 3798
		// (set) Token: 0x06000ED7 RID: 3799
		public extern double DirectionAtPoint1 { get; set; }

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06000ED8 RID: 3800
		// (set) Token: 0x06000ED9 RID: 3801
		public extern double DirectionAtPoint2 { get; set; }

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06000EDA RID: 3802
		public extern double PIStation { get; }

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06000EDB RID: 3803
		public extern Point2d PIPoint { get; }

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06000EDC RID: 3804
		// (set) Token: 0x06000EDD RID: 3805
		public extern bool GreaterThan180 { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06000EDE RID: 3806
		// (set) Token: 0x06000EDF RID: 3807
		public extern double DeflectedAngle { get; set; }

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06000EE0 RID: 3808
		public extern bool ReverseCurve { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06000EE1 RID: 3809
		public extern bool Clockwise { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06000EE2 RID: 3810
		public extern double MinimumRadius { get; }
	}
}
