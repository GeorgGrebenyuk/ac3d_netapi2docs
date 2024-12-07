using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000FA9 RID: 4009
	public sealed class LabelStylesParcelRoot : LabelStylesNode
	{
		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06001F9E RID: 8094
		public extern LabelStyleCollection CurveLabelStyles { get; }

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06001F9F RID: 8095
		public extern LabelStyleCollection AreaLabelStyles { get; }

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06001FA0 RID: 8096
		public extern LabelStyleCollection LineLabelStyles { get; }
	}
}
