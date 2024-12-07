using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000FAD RID: 4013
	public sealed class LabelStylesProjectionRoot : LabelStylesNode
	{
		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06001FAB RID: 8107
		public extern LabelStyleCollection ProfileViewProjectionLabelStyles { get; }

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06001FAC RID: 8108
		public extern LabelStyleCollection SectionViewProjectionLabelStyles { get; }
	}
}
