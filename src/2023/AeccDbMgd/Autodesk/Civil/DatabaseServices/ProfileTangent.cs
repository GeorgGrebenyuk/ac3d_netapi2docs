using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000F13 RID: 3859
	public class ProfileTangent : ProfileEntity
	{
		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06001D1E RID: 7454
		public override extern ProfileEntityType EntityType { get; }

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06001D1F RID: 7455
		public extern double Grade { get; }

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06001D20 RID: 7456
		// (set) Token: 0x06001D21 RID: 7457
		public extern double ThroughPoint1Station { get; set; }

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06001D22 RID: 7458
		// (set) Token: 0x06001D23 RID: 7459
		public extern double ThroughPoint1Elevation { get; set; }

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06001D24 RID: 7460
		// (set) Token: 0x06001D25 RID: 7461
		public extern double ThroughPoint2Station { get; set; }

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06001D26 RID: 7462
		// (set) Token: 0x06001D27 RID: 7463
		public extern double ThroughPoint2Elevation { get; set; }
	}
}
