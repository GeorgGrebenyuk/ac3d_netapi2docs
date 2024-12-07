using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DBE RID: 3518
	public struct SurfaceVolumeInfo
	{
		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06001A1F RID: 6687
		public extern double Cut { get; }

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06001A20 RID: 6688
		public extern double Fill { get; }

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06001A21 RID: 6689
		public extern double Net { get; }

		// Token: 0x0400166C RID: 5740
		private double m_dCut;

		// Token: 0x0400166D RID: 5741
		private double m_dFill;

		// Token: 0x0400166E RID: 5742
		private double m_dNet;
	}
}
