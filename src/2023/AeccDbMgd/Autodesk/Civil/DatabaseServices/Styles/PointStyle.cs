using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200009D RID: 157
	[Wrapper("AeccDbPointStyle")]
	public sealed class PointStyle : MarkerStyleBase
	{
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060006EB RID: 1771
		// (set) Token: 0x060006EC RID: 1772
		public extern PointDisplay3dType Display3dType { get; set; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060006ED RID: 1773
		// (set) Token: 0x060006EE RID: 1774
		public extern double Elevation { get; set; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060006EF RID: 1775
		// (set) Token: 0x060006F0 RID: 1776
		public extern double ScaleFactor { get; set; }

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060006F1 RID: 1777
		// (set) Token: 0x060006F2 RID: 1778
		public extern PointMarkerDisplayType MarkerType { get; set; }

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060006F3 RID: 1779
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.PointStyle.GetLabelDisplayStylePlan instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle LabelDisplayStylePlan { get; }

		// Token: 0x060006F4 RID: 1780
		public extern DisplayStyle GetLabelDisplayStylePlan();

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060006F5 RID: 1781
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.PointStyle.GetLabelDisplayStyleModel instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle LabelDisplayStyleModel { get; }

		// Token: 0x060006F6 RID: 1782
		public extern DisplayStyle GetLabelDisplayStyleModel();

		// Token: 0x060006F7 RID: 1783
		public extern DisplayStyle GetDisplayStylePlan(PointDisplayStyleType type);

		// Token: 0x060006F8 RID: 1784
		public extern DisplayStyle GetDisplayStyleModel(PointDisplayStyleType type);

		// Token: 0x060006F9 RID: 1785
		public extern DisplayStyle GetDisplayStyleProfile();

		// Token: 0x060006FA RID: 1786
		public extern DisplayStyle GetDisplayStyleSection();
	}
}
