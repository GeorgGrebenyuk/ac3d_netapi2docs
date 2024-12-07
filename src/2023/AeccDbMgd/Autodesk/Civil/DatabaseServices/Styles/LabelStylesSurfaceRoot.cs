using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000FB1 RID: 4017
	public sealed class LabelStylesSurfaceRoot : LabelStylesNode
	{
		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06001FB5 RID: 8117
		public extern LabelStyleCollection ContourLabelStyles { get; }

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06001FB6 RID: 8118
		public extern LabelStyleCollection SlopeLabelStyles { get; }

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06001FB7 RID: 8119
		public extern LabelStyleCollection SpotElevationLabelStyles { get; }

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06001FB8 RID: 8120
		public extern LabelStyleCollection WatershedLabelStyles { get; }
	}
}
