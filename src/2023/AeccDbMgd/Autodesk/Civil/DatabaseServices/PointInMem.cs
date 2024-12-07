using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011D1 RID: 4561
	public sealed class PointInMem : IPoint
	{
		// Token: 0x0600267F RID: 9855
		public extern PointInMem();

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06002680 RID: 9856
		public extern CodeCollection Codes { get; }

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x06002681 RID: 9857
		// (set) Token: 0x06002682 RID: 9858
		public extern double Station { get; set; }

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x06002683 RID: 9859
		// (set) Token: 0x06002684 RID: 9860
		public extern double Offset { get; set; }

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x06002685 RID: 9861
		// (set) Token: 0x06002686 RID: 9862
		public extern double Elevation { get; set; }

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x06002687 RID: 9863
		public extern int Index { get; }

		// Token: 0x04001B15 RID: 6933
		private int <SyntheticNonEmptyStructMarker>;
	}
}
