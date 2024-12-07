using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000791 RID: 1937
	public class AlignmentArc : AlignmentCurve
	{
		// Token: 0x17000636 RID: 1590
		public override extern AlignmentSubEntity this[int index]
		{
			get;
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06000EF5 RID: 3829
		public extern AlignmentArcConstraintType Constraint2 { get; }

		// Token: 0x17000634 RID: 1588
		// (set) Token: 0x06000EF6 RID: 3830
		public override extern double Length { set; }

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06000EF7 RID: 3831
		// (set) Token: 0x06000EF8 RID: 3832
		public extern Point2d CenterPoint { get; set; }

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06000EF9 RID: 3833
		// (set) Token: 0x06000EFA RID: 3834
		public extern double Radius { get; set; }

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06000EFB RID: 3835
		public extern double StartDirection { get; }

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06000EFC RID: 3836
		public extern double EndDirection { get; }

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06000EFD RID: 3837
		// (set) Token: 0x06000EFE RID: 3838
		public extern double Delta { get; set; }

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06000EFF RID: 3839
		// (set) Token: 0x06000F00 RID: 3840
		public extern double ChordLength { get; set; }

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06000F01 RID: 3841
		public extern double ChordDirection { get; }

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06000F02 RID: 3842
		// (set) Token: 0x06000F03 RID: 3843
		public extern double ExternalSecant { get; set; }

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06000F04 RID: 3844
		// (set) Token: 0x06000F05 RID: 3845
		public extern double ExternalTangent { get; set; }

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06000F06 RID: 3846
		// (set) Token: 0x06000F07 RID: 3847
		public extern double MidOrdinate { get; set; }

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06000F08 RID: 3848
		// (set) Token: 0x06000F09 RID: 3849
		public extern Point2d PassThroughPoint1 { get; set; }

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06000F0A RID: 3850
		// (set) Token: 0x06000F0B RID: 3851
		public extern Point2d PassThroughPoint2 { get; set; }

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06000F0C RID: 3852
		// (set) Token: 0x06000F0D RID: 3853
		public extern Point2d PassThroughPoint3 { get; set; }

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06000F0E RID: 3854
		// (set) Token: 0x06000F0F RID: 3855
		public extern double DirectionAtPoint1 { get; set; }

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06000F10 RID: 3856
		// (set) Token: 0x06000F11 RID: 3857
		public extern double DirectionAtPoint2 { get; set; }

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06000F12 RID: 3858
		public extern double PIStation { get; }

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06000F13 RID: 3859
		// (set) Token: 0x06000F14 RID: 3860
		public extern bool GreaterThan180 { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06000F15 RID: 3861
		// (set) Token: 0x06000F16 RID: 3862
		public extern double DeflectedAngle { get; set; }

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06000F17 RID: 3863
		public extern bool ReverseCurve { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06000F18 RID: 3864
		public extern bool Clockwise { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06000F19 RID: 3865
		// (set) Token: 0x06000F1A RID: 3866
		public extern string CurveGroupIndex { get; set; }

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06000F1B RID: 3867
		// (set) Token: 0x06000F1C RID: 3868
		public extern string CurveGroupSubEntityIndex { get; set; }

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06000F1D RID: 3869
		public extern double MinimumRadius { get; }

		// Token: 0x04001180 RID: 4480
		private int <SyntheticNonEmptyStructMarker>;
	}
}
