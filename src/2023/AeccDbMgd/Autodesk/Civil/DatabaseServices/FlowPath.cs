using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000768 RID: 1896
	public class FlowPath
	{
		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06000EEB RID: 3819
		public extern int FlowSegmentCount { get; }

		// Token: 0x06000EEC RID: 3820
		public extern FlowSegment GetFlowSegmentAt(int index);

		// Token: 0x0400115D RID: 4445
		private int <SyntheticNonEmptyStructMarker>;
	}
}
