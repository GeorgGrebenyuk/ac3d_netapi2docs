using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000762 RID: 1890
	public sealed class ConnectedAlignmentCCCInfo : ConnectedAlignmentInfo
	{
		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06000EB4 RID: 3764
		// (set) Token: 0x06000EB5 RID: 3765
		public extern double ArcInRadius { get; set; }

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06000EB6 RID: 3766
		// (set) Token: 0x06000EB7 RID: 3767
		public extern double ArcInLength { get; set; }

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06000EB8 RID: 3768
		// (set) Token: 0x06000EB9 RID: 3769
		public extern double ArcMiddleRadius { get; set; }

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06000EBA RID: 3770
		// (set) Token: 0x06000EBB RID: 3771
		public extern double ArcOutRadius { get; set; }

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06000EBC RID: 3772
		// (set) Token: 0x06000EBD RID: 3773
		public extern double ArcOutLength { get; set; }
	}
}
