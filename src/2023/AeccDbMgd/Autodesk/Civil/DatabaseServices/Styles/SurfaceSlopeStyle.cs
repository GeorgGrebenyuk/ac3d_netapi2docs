using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F88 RID: 3976
	public sealed class SurfaceSlopeStyle : SurfaceBaseStyle
	{
		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06001EE0 RID: 7904
		// (set) Token: 0x06001EE1 RID: 7905
		public extern SurfaceDisplayType DisplayEntityMode { get; set; }

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06001EE2 RID: 7906
		// (set) Token: 0x06001EE3 RID: 7907
		public extern SurfaceGroupValuesByType GroupValuesBy { get; set; }

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06001EE4 RID: 7908
		// (set) Token: 0x06001EE5 RID: 7909
		public extern int NumberOfRanges { get; set; }

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06001EE6 RID: 7910
		// (set) Token: 0x06001EE7 RID: 7911
		public extern PrecisionRangeType RangePrecision { get; set; }

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06001EE8 RID: 7912
		// (set) Token: 0x06001EE9 RID: 7913
		public extern ColorSchemeType ColorScheme { get; set; }

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06001EEA RID: 7914
		// (set) Token: 0x06001EEB RID: 7915
		public extern ObjectId LegendStyleId { get; set; }

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06001EEC RID: 7916
		// (set) Token: 0x06001EED RID: 7917
		public extern string LegendStyleName { get; set; }
	}
}
