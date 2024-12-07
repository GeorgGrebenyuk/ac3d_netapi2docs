using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000E00 RID: 3584
	public sealed class LabelSetStylesRoot : TreeOidWrapper
	{
		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06001B30 RID: 6960
		public extern AlignmentLabelSetStyleCollection AlignmentLabelSetStyles { get; }

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06001B31 RID: 6961
		public extern ProfileLabelSetStyleCollection ProfileLabelSetStyles { get; }

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06001B32 RID: 6962
		public extern SectionLabelSetStyleCollection SectionLabelSetStyles { get; }
	}
}
