using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001076 RID: 4214
	public sealed class LabelStylesPipeRoot : LabelStylesNode
	{
		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x060021AD RID: 8621
		public extern LabelStyleCollection PlanProfileLabelStyles { get; }

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x060021AE RID: 8622
		public extern LabelStyleCollection CrossSectionLabelStyles { get; }

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x060021AF RID: 8623
		public extern LabelStyleCollection CrossProfileLabelStyles { get; }
	}
}
