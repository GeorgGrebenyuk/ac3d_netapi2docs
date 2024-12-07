using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F82 RID: 3970
	public sealed class SurfaceElevationStyle : SurfaceBaseStyle
	{
		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06001E9E RID: 7838
		// (set) Token: 0x06001E9F RID: 7839
		public extern SurfaceGroupValuesByType GroupValuesBy { get; set; }

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06001EA0 RID: 7840
		// (set) Token: 0x06001EA1 RID: 7841
		public extern int NumberOfRanges { get; set; }

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06001EA2 RID: 7842
		// (set) Token: 0x06001EA3 RID: 7843
		public extern PrecisionRangeType RangePrecision { get; set; }

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06001EA4 RID: 7844
		// (set) Token: 0x06001EA5 RID: 7845
		public extern SurfaceDisplayType DisplayEntityMode { get; set; }

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06001EA6 RID: 7846
		// (set) Token: 0x06001EA7 RID: 7847
		public extern ColorSchemeType ColorScheme { get; set; }

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06001EA8 RID: 7848
		// (set) Token: 0x06001EA9 RID: 7849
		public extern ColorSchemeType CutScheme { get; set; }

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06001EAA RID: 7850
		// (set) Token: 0x06001EAB RID: 7851
		public extern ColorSchemeType FillScheme { get; set; }

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06001EAC RID: 7852
		// (set) Token: 0x06001EAD RID: 7853
		public extern string LegendStyleName { get; set; }

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06001EAE RID: 7854
		// (set) Token: 0x06001EAF RID: 7855
		public extern ObjectId LegendStyleId { get; set; }

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06001EB0 RID: 7856
		// (set) Token: 0x06001EB1 RID: 7857
		public extern DataBandingType DataBandingMode { get; set; }

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06001EB2 RID: 7858
		// (set) Token: 0x06001EB3 RID: 7859
		public extern double IntervalLength { get; set; }
	}
}
