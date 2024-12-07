using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000B52 RID: 2898
	public sealed class LabelStylesCatchmentRoot : LabelStylesNode
	{
		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x0600157C RID: 5500
		public extern LabelStyleCollection AreaLabelStyles { get; }

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x0600157D RID: 5501
		public extern LabelStyleCollection FlowSegmentLabelStyles { get; }
	}
}
