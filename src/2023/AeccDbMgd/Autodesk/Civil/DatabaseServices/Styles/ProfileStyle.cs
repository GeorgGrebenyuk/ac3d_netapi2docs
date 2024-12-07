using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200009E RID: 158
	[Wrapper("AeccDbVAlignmentStyle")]
	public sealed class ProfileStyle : StyleBase
	{
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060006FB RID: 1787
		// (set) Token: 0x060006FC RID: 1788
		public extern double ChainTessellationDistance3D { get; set; }

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060006FD RID: 1789
		// (set) Token: 0x060006FE RID: 1790
		public extern ObjectId ThroughPointMarkerStyle { get; set; }

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060006FF RID: 1791
		// (set) Token: 0x06000700 RID: 1792
		public extern ObjectId VIntersectionPointMarkerStyle { get; set; }

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000701 RID: 1793
		// (set) Token: 0x06000702 RID: 1794
		public extern ObjectId BeginPointMarkerStyle { get; set; }

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000703 RID: 1795
		// (set) Token: 0x06000704 RID: 1796
		public extern ObjectId EndPointMarkerStyle { get; set; }

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000705 RID: 1797
		// (set) Token: 0x06000706 RID: 1798
		public extern ObjectId VTangentCurveIntersectPointMarkerStyle { get; set; }

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000707 RID: 1799
		// (set) Token: 0x06000708 RID: 1800
		public extern ObjectId VCompoundCurveIntersectPointMarkerStyle { get; set; }

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000709 RID: 1801
		// (set) Token: 0x0600070A RID: 1802
		public extern ObjectId VReverseCurveIntersectPointMarkerStyle { get; set; }

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600070B RID: 1803
		// (set) Token: 0x0600070C RID: 1804
		public extern ObjectId VCurveTangentIntersectPointMarkerStyle { get; set; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600070D RID: 1805
		// (set) Token: 0x0600070E RID: 1806
		public extern ObjectId HighPointMarkerStyle { get; set; }

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600070F RID: 1807
		// (set) Token: 0x06000710 RID: 1808
		public extern ObjectId LowPointMarkerStyle { get; set; }

		// Token: 0x06000711 RID: 1809
		public extern DisplayStyle GetDisplayStyleProfile(ProfileDisplayStyleProfileType type);

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000712 RID: 1810
		// (set) Token: 0x06000713 RID: 1811
		public extern ObjectId ProfileMarkerSectionViewMarkerStyle { get; set; }

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000714 RID: 1812
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.ProfileStyle.GetChain3DDisplayStyleModel instead.", false)]
		public extern DisplayStyle Chain3DDisplayStyleModel { get; }

		// Token: 0x06000715 RID: 1813
		public extern DisplayStyle GetChain3DDisplayStyleModel();

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000716 RID: 1814
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.ProfileStyle.GetProfileMarkerDisplayStyleSection instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle ProfileMarkerDisplayStyleSection { get; }

		// Token: 0x06000717 RID: 1815
		public extern DisplayStyle GetProfileMarkerDisplayStyleSection();

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000718 RID: 1816
		public extern ArrowHeadOption ArrowHeadOption { get; }
	}
}
