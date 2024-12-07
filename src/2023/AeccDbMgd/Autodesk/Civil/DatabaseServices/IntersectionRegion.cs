using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200119D RID: 4509
	public sealed class IntersectionRegion : CivilWrapper<AeccDbIntersection>
	{
		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x060025BC RID: 9660
		public extern ObjectId CurbReturnAlignmentId { get; }

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x060025BD RID: 9661
		public extern ObjectId CurbReturnProfileId { get; }

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x060025BE RID: 9662
		// (set) Token: 0x060025BF RID: 9663
		public extern string Name { get; set; }

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x060025C0 RID: 9664
		public extern double Angle { get; }

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x060025C1 RID: 9665
		public extern ObjectId InAlignmentId { get; }

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x060025C2 RID: 9666
		public extern ObjectId OutAlignmentId { get; }

		// Token: 0x04001AE7 RID: 6887
		private int <SyntheticNonEmptyStructMarker>;
	}
}
