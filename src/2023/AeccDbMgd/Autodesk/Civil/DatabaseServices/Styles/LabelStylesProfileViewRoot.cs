using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000FAC RID: 4012
	public sealed class LabelStylesProfileViewRoot : LabelStylesNode
	{
		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06001FA9 RID: 8105
		public extern LabelStyleCollection DepthLabelStyles { get; }

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06001FAA RID: 8106
		public extern LabelStyleCollection StationElevationLabelStyles { get; }
	}
}
