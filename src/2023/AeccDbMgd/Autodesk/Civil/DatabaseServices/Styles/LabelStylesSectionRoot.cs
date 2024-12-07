using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000FAF RID: 4015
	public sealed class LabelStylesSectionRoot : LabelStylesNode
	{
		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06001FAE RID: 8110
		public extern LabelStyleCollection GradeBreakLabelStyles { get; }

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06001FAF RID: 8111
		public extern LabelStyleCollection MajorOffsetLabelStyles { get; }

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06001FB0 RID: 8112
		public extern LabelStyleCollection MinorOffsetLabelStyles { get; }

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06001FB1 RID: 8113
		public extern LabelStyleCollection SegmentLabelStyles { get; }

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06001FB2 RID: 8114
		public extern LabelStyleCollection CorridorPointLabelStyles { get; }
	}
}
