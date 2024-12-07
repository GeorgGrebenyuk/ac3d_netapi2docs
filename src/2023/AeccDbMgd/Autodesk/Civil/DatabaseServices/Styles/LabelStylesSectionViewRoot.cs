using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000FB0 RID: 4016
	public sealed class LabelStylesSectionViewRoot : LabelStylesNode
	{
		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06001FB3 RID: 8115
		public extern LabelStyleCollection GradeLabelStyles { get; }

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06001FB4 RID: 8116
		public extern LabelStyleCollection OffsetElevationLabelStyles { get; }
	}
}
