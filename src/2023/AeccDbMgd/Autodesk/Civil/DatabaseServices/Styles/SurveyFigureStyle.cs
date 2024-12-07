using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000B8 RID: 184
	[Wrapper("AeccDbSvFigureStyle")]
	public sealed class SurveyFigureStyle : StyleBase
	{
		// Token: 0x060007F7 RID: 2039
		public extern DisplayStyle GetDisplayStylePlan(SurveyFigureDisplayType displayType);

		// Token: 0x060007F8 RID: 2040
		public extern DisplayStyle GetDisplayStyleModel(SurveyFigureDisplayType displayType);

		// Token: 0x060007F9 RID: 2041
		public extern DisplayStyle GetDisplayStyleProfile(SurveyFigureProfileDisplayType displayType);

		// Token: 0x060007FA RID: 2042
		public extern DisplayStyle GetDisplayStyleSection(SurveyFigureSectionDisplayType displayType);

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060007FB RID: 2043
		// (set) Token: 0x060007FC RID: 2044
		public extern ObjectId VertexMarkerStyleId { get; set; }

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060007FD RID: 2045
		// (set) Token: 0x060007FE RID: 2046
		public extern ObjectId MidpointMarkerStyleId { get; set; }

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060007FF RID: 2047
		// (set) Token: 0x06000800 RID: 2048
		public extern ObjectId StartPointMarkerStyleId { get; set; }

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000801 RID: 2049
		// (set) Token: 0x06000802 RID: 2050
		public extern ObjectId EndPointMarkerStyleId { get; set; }

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000803 RID: 2051
		// (set) Token: 0x06000804 RID: 2052
		public extern ObjectId AdditionalMarkerStyleId { get; set; }

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000805 RID: 2053
		// (set) Token: 0x06000806 RID: 2054
		public extern bool AlignVertexMarkersWithFigure { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000807 RID: 2055
		// (set) Token: 0x06000808 RID: 2056
		public extern bool AlignMidpointMarkersWithFigure { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000809 RID: 2057
		// (set) Token: 0x0600080A RID: 2058
		public extern bool AlignEndpointMarkersWithFigure { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600080B RID: 2059
		// (set) Token: 0x0600080C RID: 2060
		public extern bool AlignAdditionalMarkersWithFigure { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x0600080D RID: 2061
		// (set) Token: 0x0600080E RID: 2062
		public extern SurveyFigureMarkerPlacementType AdditionalMarkerPlacementMethod { get; set; }

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x0600080F RID: 2063
		// (set) Token: 0x06000810 RID: 2064
		public extern double AdditionalMarkerInterval { get; set; }

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000811 RID: 2065
		// (set) Token: 0x06000812 RID: 2066
		public extern int AdditionalMarkerDivideFigureBy { get; set; }

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000813 RID: 2067
		// (set) Token: 0x06000814 RID: 2068
		public extern bool PlaceAdditionalMarkerAtFigureStartPoint { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000815 RID: 2069
		// (set) Token: 0x06000816 RID: 2070
		public extern bool PlaceAdditionalMarkerAtFigureEndPoint { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000817 RID: 2071
		// (set) Token: 0x06000818 RID: 2072
		public extern SurveyElevationDisplayType NetworkDisplayMode { get; set; }

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000819 RID: 2073
		// (set) Token: 0x0600081A RID: 2074
		public extern double FlattenToElevationBy { get; set; }

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x0600081B RID: 2075
		// (set) Token: 0x0600081C RID: 2076
		public extern double ExaggerateElevationBy { get; set; }

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x0600081D RID: 2077
		// (set) Token: 0x0600081E RID: 2078
		public extern ObjectId BeginningVertexMarkerStyleId { get; set; }

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x0600081F RID: 2079
		// (set) Token: 0x06000820 RID: 2080
		public extern ObjectId InternalVertexMarkerStyleId { get; set; }

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000821 RID: 2081
		// (set) Token: 0x06000822 RID: 2082
		public extern ObjectId EndingVertexMarkerStyleId { get; set; }

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000823 RID: 2083
		// (set) Token: 0x06000824 RID: 2084
		public extern ObjectId CrossingMarkerStyleId { get; set; }
	}
}
