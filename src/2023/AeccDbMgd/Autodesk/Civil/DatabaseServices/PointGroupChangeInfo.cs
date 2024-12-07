using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000869 RID: 2153
	public class PointGroupChangeInfo
	{
		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001040 RID: 4160
		public extern uint[] PointsToAdd { get; }

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001041 RID: 4161
		public extern uint[] PointsToRemove { get; }

		// Token: 0x04001271 RID: 4721
		private int <SyntheticNonEmptyStructMarker>;
	}
}
