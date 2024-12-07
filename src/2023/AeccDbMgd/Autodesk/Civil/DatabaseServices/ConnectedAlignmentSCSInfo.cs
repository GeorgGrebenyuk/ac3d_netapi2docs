using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200075E RID: 1886
	public sealed class ConnectedAlignmentSCSInfo : ConnectedAlignmentInfo
	{
		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06000E90 RID: 3728
		// (set) Token: 0x06000E91 RID: 3729
		public extern double CurveRadius { get; set; }

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06000E92 RID: 3730
		public extern SpiralType SpiralDefinition { get; }

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06000E93 RID: 3731
		// (set) Token: 0x06000E94 RID: 3732
		public extern double SpiralInLength { get; set; }

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06000E95 RID: 3733
		// (set) Token: 0x06000E96 RID: 3734
		public extern double SpiralOutLength { get; set; }
	}
}
