using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001205 RID: 4613
	public sealed class LabelStylesSurveyRoot : LabelStylesNode
	{
		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x06002702 RID: 9986
		public extern LabelStyleCollection CurveLabelStyles { get; }

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x06002703 RID: 9987
		public extern LabelStyleCollection FigureLabelStyles { get; }

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x06002704 RID: 9988
		public extern LabelStyleCollection LineLabelStyles { get; }
	}
}
