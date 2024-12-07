using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000EA RID: 234
	public struct BaseLineRange
	{
		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000A7E RID: 2686
		// (set) Token: 0x06000A7F RID: 2687
		public extern double StartStation { get; set; }

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000A80 RID: 2688
		// (set) Token: 0x06000A81 RID: 2689
		public extern double EndStation { get; set; }

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000A82 RID: 2690
		// (set) Token: 0x06000A83 RID: 2691
		public extern ObjectId BaseLineId { get; set; }

		// Token: 0x06000A84 RID: 2692
		public extern void CheckStationRange();

		// Token: 0x04000312 RID: 786
		private double m_dStartStation;

		// Token: 0x04000313 RID: 787
		private double m_dEndStation;

		// Token: 0x04000314 RID: 788
		private ObjectId m_baselineId;
	}
}
