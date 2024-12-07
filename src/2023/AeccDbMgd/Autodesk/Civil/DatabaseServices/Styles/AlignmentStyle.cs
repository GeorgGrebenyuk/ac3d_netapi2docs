using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000A5 RID: 165
	[Wrapper("AeccDbAlignmentStyle")]
	public sealed class AlignmentStyle : StyleBase
	{
		// Token: 0x06000737 RID: 1847
		public extern DisplayStyle GetDisplayStylePlan(AlignmentDisplayStyleType type);

		// Token: 0x06000738 RID: 1848
		public extern DisplayStyle GetDisplayStyleModel(AlignmentDisplayStyleType type);

		// Token: 0x06000739 RID: 1849
		public extern DisplayStyle GetDisplayStyleSection();

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x0600073A RID: 1850
		// (set) Token: 0x0600073B RID: 1851
		public extern ObjectId MidPointMarkerStyle { get; set; }

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x0600073C RID: 1852
		// (set) Token: 0x0600073D RID: 1853
		public extern ObjectId CurveLineIntersectPointMarkerStyle { get; set; }

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600073E RID: 1854
		// (set) Token: 0x0600073F RID: 1855
		public extern ObjectId IntersectionPointMarkerStyle { get; set; }

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000740 RID: 1856
		// (set) Token: 0x06000741 RID: 1857
		public extern ObjectId ReverseCurveIntersectPointMarkerStyle { get; set; }

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000742 RID: 1858
		// (set) Token: 0x06000743 RID: 1859
		public extern ObjectId SpiralSpiralIntersectPointMarkerStyle { get; set; }

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000744 RID: 1860
		// (set) Token: 0x06000745 RID: 1861
		public extern ObjectId ReverseSpiralIntersectPointMarkerStyle { get; set; }

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000746 RID: 1862
		// (set) Token: 0x06000747 RID: 1863
		public extern ObjectId BeginPointMarkerStyle { get; set; }

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000748 RID: 1864
		// (set) Token: 0x06000749 RID: 1865
		public extern bool EnableRadiusSnap { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600074A RID: 1866
		// (set) Token: 0x0600074B RID: 1867
		public extern ObjectId ThroughPointMarkerStyle { get; set; }

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x0600074C RID: 1868
		// (set) Token: 0x0600074D RID: 1869
		public extern ObjectId CompoundCurveIntersectPointMarkerStyle { get; set; }

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600074E RID: 1870
		// (set) Token: 0x0600074F RID: 1871
		public extern double RadiusSnapValue { get; set; }

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000750 RID: 1872
		// (set) Token: 0x06000751 RID: 1873
		public extern ObjectId StationReferencePointMarkerStyle { get; set; }

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000752 RID: 1874
		// (set) Token: 0x06000753 RID: 1875
		public extern ObjectId SpiralLineIntersectPointMarkerStyle { get; set; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000754 RID: 1876
		// (set) Token: 0x06000755 RID: 1877
		public extern ObjectId LineSpiralIntersectPointMarkerStyle { get; set; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000756 RID: 1878
		// (set) Token: 0x06000757 RID: 1879
		public extern ObjectId LineCurveIntersectPointMarkerStyle { get; set; }

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000758 RID: 1880
		// (set) Token: 0x06000759 RID: 1881
		public extern ObjectId SpiralCurveIntersectPointMarkerStyle { get; set; }

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600075A RID: 1882
		// (set) Token: 0x0600075B RID: 1883
		public extern ObjectId EndPointMarkerStyle { get; set; }

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600075C RID: 1884
		// (set) Token: 0x0600075D RID: 1885
		public extern ObjectId CurveSpiralIntersectPointMarkerStyle { get; set; }

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600075E RID: 1886
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.AlignmentStyle.GetLineMarkerDisplayStyleSection instead.", false)]
		public extern DisplayStyle LineMarkerDisplayStyleSection { get; }

		// Token: 0x0600075F RID: 1887
		public extern DisplayStyle GetLineMarkerDisplayStyleSection();

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000760 RID: 1888
		public extern ArrowHeadOption ArrowHeadOption { get; }
	}
}
