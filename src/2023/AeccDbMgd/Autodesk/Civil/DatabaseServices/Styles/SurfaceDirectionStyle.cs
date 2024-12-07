using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F81 RID: 3969
	public sealed class SurfaceDirectionStyle : SurfaceBaseStyle
	{
		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06001E90 RID: 7824
		// (set) Token: 0x06001E91 RID: 7825
		public extern SurfaceGroupValuesByType GroupValuesBy { get; set; }

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06001E92 RID: 7826
		// (set) Token: 0x06001E93 RID: 7827
		public extern int NumberOfRanges { get; set; }

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06001E94 RID: 7828
		// (set) Token: 0x06001E95 RID: 7829
		public extern PrecisionRangeType RangePrecision { get; set; }

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06001E96 RID: 7830
		// (set) Token: 0x06001E97 RID: 7831
		public extern SurfaceDisplayType DisplayEntityMode { get; set; }

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06001E98 RID: 7832
		// (set) Token: 0x06001E99 RID: 7833
		public extern ColorSchemeType ColorScheme { get; set; }

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06001E9A RID: 7834
		// (set) Token: 0x06001E9B RID: 7835
		public extern string LegendStyleName { get; set; }

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06001E9C RID: 7836
		// (set) Token: 0x06001E9D RID: 7837
		public extern ObjectId LegendStyleId { get; set; }
	}
}
