using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000760 RID: 1888
	public sealed class ConnectedAlignmentSCSSInfo : ConnectedAlignmentInfo
	{
		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06000EA0 RID: 3744
		// (set) Token: 0x06000EA1 RID: 3745
		public extern double CurveRadius { get; set; }

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06000EA2 RID: 3746
		public extern SpiralType SpiralDefinition { get; }

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06000EA3 RID: 3747
		// (set) Token: 0x06000EA4 RID: 3748
		public extern double SpiralInLength { get; set; }

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06000EA5 RID: 3749
		// (set) Token: 0x06000EA6 RID: 3750
		public extern double SpiralOutLength { get; set; }

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06000EA7 RID: 3751
		// (set) Token: 0x06000EA8 RID: 3752
		public extern double ReverseSpiralOutLength { get; set; }
	}
}
