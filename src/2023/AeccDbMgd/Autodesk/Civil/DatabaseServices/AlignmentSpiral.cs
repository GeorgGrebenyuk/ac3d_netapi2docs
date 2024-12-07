using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E49 RID: 3657
	public class AlignmentSpiral : AlignmentCurve
	{
		// Token: 0x17000DD9 RID: 3545
		public override extern AlignmentSubEntity this[int index]
		{
			get;
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06001B8E RID: 7054
		// (set) Token: 0x06001B8F RID: 7055
		public extern double A { get; set; }

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06001B90 RID: 7056
		public extern bool Compound { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06001B91 RID: 7057
		public extern SpiralCurveType CurveType { get; }

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06001B92 RID: 7058
		// (set) Token: 0x06001B93 RID: 7059
		public extern string CurveGroupIndex { get; set; }

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06001B94 RID: 7060
		// (set) Token: 0x06001B95 RID: 7061
		public extern string CurveGroupSubEntityIndex { get; set; }

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06001B96 RID: 7062
		public extern double Delta { get; }

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06001B97 RID: 7063
		public extern double StartDirection { get; }

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06001B98 RID: 7064
		public extern double EndDirection { get; }

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06001B99 RID: 7065
		public extern double K { get; }

		// Token: 0x17000DCF RID: 3535
		// (set) Token: 0x06001B9A RID: 7066
		public override extern double Length { set; }

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06001B9B RID: 7067
		public extern double LongTangent { get; }

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06001B9C RID: 7068
		public extern double MinimumTransitionLength { get; }

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06001B9D RID: 7069
		public extern double P { get; }

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06001B9E RID: 7070
		public extern Point2d RadialPoint { get; }

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06001B9F RID: 7071
		public extern double RadiusIn { get; }

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06001BA0 RID: 7072
		public extern double RadiusOut { get; }

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06001BA1 RID: 7073
		public extern double ShortTangent { get; }

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06001BA2 RID: 7074
		public extern double SPIAngle { get; }

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06001BA3 RID: 7075
		public extern Point2d SPIPoint { get; }

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06001BA4 RID: 7076
		public extern AlignmentSpiralConstraintType Constraint2 { get; }

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06001BA5 RID: 7077
		public extern SpiralType SpiralDefinition { get; }

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06001BA6 RID: 7078
		public extern double SPIStation { get; }

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06001BA7 RID: 7079
		public extern SpiralDirectionType Direction { get; }

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06001BA8 RID: 7080
		public extern double TotalX { get; }

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06001BA9 RID: 7081
		public extern double TotalY { get; }

		// Token: 0x040016FD RID: 5885
		private int <SyntheticNonEmptyStructMarker>;
	}
}
