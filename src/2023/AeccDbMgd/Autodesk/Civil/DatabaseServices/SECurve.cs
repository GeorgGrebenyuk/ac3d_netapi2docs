using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E7C RID: 3708
	public class SECurve
	{
		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06001C3C RID: 7228
		public extern SuperelevationCriticalStationCollection CriticalStations { get; }

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06001C3D RID: 7229
		public extern CANTCriticalStationCollection CANTCriticalStations { get; }

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06001C3E RID: 7230
		public extern double StartStation { get; }

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06001C3F RID: 7231
		public extern double EndStation { get; }

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06001C40 RID: 7232
		public extern ObjectId ParentAlignmentId { get; }

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06001C41 RID: 7233
		// (set) Token: 0x06001C42 RID: 7234
		public extern string Name { get; set; }

		// Token: 0x0400175E RID: 5982
		private int <SyntheticNonEmptyStructMarker>;
	}
}
