using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200086C RID: 2156
	public class PointGroupElevationOverrideInfo : PointGroupOverrideInfo
	{
		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x0600104A RID: 4170
		// (set) Token: 0x0600104B RID: 4171
		public extern double FixedElevation { get; set; }

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600104C RID: 4172
		// (set) Token: 0x0600104D RID: 4173
		public extern UDPDouble UDP { get; set; }
	}
}
