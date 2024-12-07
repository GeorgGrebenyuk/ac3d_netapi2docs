using System;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000FA0 RID: 4000
	public class ProfileLabelSetItem : BaseLabelSetItem
	{
		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06001F64 RID: 8036
		// (set) Token: 0x06001F65 RID: 8037
		public extern double Increment { get; set; }

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06001F66 RID: 8038
		// (set) Token: 0x06001F67 RID: 8039
		public extern double DimensionAnchorValue { get; set; }

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06001F68 RID: 8040
		// (set) Token: 0x06001F69 RID: 8041
		public extern DimensionAnchorType DimensionAnchorOption { get; set; }

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06001F6A RID: 8042
		// (set) Token: 0x06001F6B RID: 8043
		public extern double Weeding { get; set; }

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06001F6C RID: 8044
		// (set) Token: 0x06001F6D RID: 8045
		public extern double StaggerLineHeight1 { get; set; }

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06001F6E RID: 8046
		// (set) Token: 0x06001F6F RID: 8047
		public extern double StaggerLineHeight2 { get; set; }

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06001F70 RID: 8048
		// (set) Token: 0x06001F71 RID: 8049
		public extern StaggerLabelType StaggerLabel { get; set; }

		// Token: 0x06001F72 RID: 8050
		public extern Dictionary<AlignmentPointType, bool> GetLabeledAlignmentGeometryPoints();

		// Token: 0x06001F73 RID: 8051
		public extern void SetLabeledAlignmentGeometryPoints(Dictionary<AlignmentPointType, bool> pointTypes);
	}
}
