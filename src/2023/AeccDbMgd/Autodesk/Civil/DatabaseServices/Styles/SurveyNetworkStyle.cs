using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000B7 RID: 183
	[Wrapper("AeccDbSvNetworkStyle")]
	public sealed class SurveyNetworkStyle : StyleBase
	{
		// Token: 0x060007E3 RID: 2019
		public extern DisplayStyle GetDisplayStylePlan(SurveyNetworkDisplayStyleType type);

		// Token: 0x060007E4 RID: 2020
		public extern DisplayStyle GetDisplayStyleModel(SurveyNetworkDisplayStyleType type);

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060007E5 RID: 2021
		// (set) Token: 0x060007E6 RID: 2022
		public extern ObjectId KnownControlPointsMarkerStyleId { get; set; }

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060007E7 RID: 2023
		// (set) Token: 0x060007E8 RID: 2024
		public extern ObjectId UnknownControlPointsMarkerStyleId { get; set; }

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060007E9 RID: 2025
		// (set) Token: 0x060007EA RID: 2026
		public extern ObjectId NonControlPointsMarkerStyleId { get; set; }

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060007EB RID: 2027
		// (set) Token: 0x060007EC RID: 2028
		public extern ObjectId SideshotPointsMarkerStyleId { get; set; }

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060007ED RID: 2029
		// (set) Token: 0x060007EE RID: 2030
		public extern ObjectId ToleranceErrorPointsMarkerStyleId { get; set; }

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060007EF RID: 2031
		// (set) Token: 0x060007F0 RID: 2032
		public extern double ErrorEllipseScaleFactor { get; set; }

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060007F1 RID: 2033
		// (set) Token: 0x060007F2 RID: 2034
		public extern SurveyElevationDisplayType NetworkDisplayMode { get; set; }

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060007F3 RID: 2035
		// (set) Token: 0x060007F4 RID: 2036
		public extern double FlattenToElevationBy { get; set; }

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060007F5 RID: 2037
		// (set) Token: 0x060007F6 RID: 2038
		public extern double ExaggerateElevationBy { get; set; }
	}
}
