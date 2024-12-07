using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000FA4 RID: 4004
	public class SectionLabelSetItem : BaseLabelSetItem
	{
		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06001F7A RID: 8058
		// (set) Token: 0x06001F7B RID: 8059
		public extern double Increment { get; set; }

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06001F7C RID: 8060
		// (set) Token: 0x06001F7D RID: 8061
		public extern double DimensionAnchorValue { get; set; }

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06001F7E RID: 8062
		// (set) Token: 0x06001F7F RID: 8063
		public extern DimensionAnchorType DimensionAnchorOption { get; set; }

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06001F80 RID: 8064
		// (set) Token: 0x06001F81 RID: 8065
		public extern double Weeding { get; set; }

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06001F82 RID: 8066
		// (set) Token: 0x06001F83 RID: 8067
		public extern double StaggerLineHeight1 { get; set; }

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06001F84 RID: 8068
		// (set) Token: 0x06001F85 RID: 8069
		public extern double StaggerLineHeight2 { get; set; }

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06001F86 RID: 8070
		// (set) Token: 0x06001F87 RID: 8071
		public extern StaggerLabelType StaggerLabel { get; set; }
	}
}
