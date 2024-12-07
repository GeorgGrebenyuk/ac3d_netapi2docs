using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000A6 RID: 166
	[Wrapper("AeccDbFeatureLineStyle")]
	public sealed class FeatureLineStyle : StyleBase
	{
		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000761 RID: 1889
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.FeatureLineStyle.GetFeatureLineDisplayStylePlan instead.", false)]
		public extern DisplayStyle FeatureLineDisplayStylePlan { get; }

		// Token: 0x06000762 RID: 1890
		public extern DisplayStyle GetFeatureLineDisplayStylePlan();

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000763 RID: 1891
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.FeatureLineStyle.GetFeatureLineDisplayStyleModel instead.", false)]
		public extern DisplayStyle FeatureLineDisplayStyleModel { get; }

		// Token: 0x06000764 RID: 1892
		public extern DisplayStyle GetFeatureLineDisplayStyleModel();

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000765 RID: 1893
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.FeatureLineStyle.GetSectionMarkerDisplayStyleSection instead.", false)]
		public extern DisplayStyle SectionMarkerDisplayStyleSection { get; }

		// Token: 0x06000766 RID: 1894
		public extern DisplayStyle GetSectionMarkerDisplayStyleSection();

		// Token: 0x06000767 RID: 1895
		public extern DisplayStyle GetDisplayStyleProfile(FeatureLineDisplayStyleProfileType type);

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000768 RID: 1896
		// (set) Token: 0x06000769 RID: 1897
		public extern ObjectId SectionMarkerStyleId { get; set; }

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600076A RID: 1898
		// (set) Token: 0x0600076B RID: 1899
		public extern string SectionMarkerStyleName { get; set; }

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600076C RID: 1900
		// (set) Token: 0x0600076D RID: 1901
		public extern ObjectId ProfileBeginningVertexMarkerStyleId { get; set; }

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600076E RID: 1902
		// (set) Token: 0x0600076F RID: 1903
		public extern string ProfileBeginningVertexMarkerStyleName { get; set; }

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000770 RID: 1904
		// (set) Token: 0x06000771 RID: 1905
		public extern ObjectId ProfileInternalVertexMarkerStyleId { get; set; }

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000772 RID: 1906
		// (set) Token: 0x06000773 RID: 1907
		public extern string ProfileInternalVertexMarkerStyleName { get; set; }

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000774 RID: 1908
		// (set) Token: 0x06000775 RID: 1909
		public extern ObjectId ProfileEndingVertexMarkerStyleId { get; set; }

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000776 RID: 1910
		// (set) Token: 0x06000777 RID: 1911
		public extern string ProfileEndingVertexMarkerStyleName { get; set; }
	}
}
