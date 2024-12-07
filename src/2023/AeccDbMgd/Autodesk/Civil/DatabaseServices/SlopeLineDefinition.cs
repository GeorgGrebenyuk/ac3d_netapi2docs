using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000059 RID: 89
	public class SlopeLineDefinition
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003D2 RID: 978
		// (set) Token: 0x060003D3 RID: 979
		public extern SlopeLineType type { get; set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003D4 RID: 980
		// (set) Token: 0x060003D5 RID: 981
		public extern SlopeLineSide side { get; set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003D6 RID: 982
		// (set) Token: 0x060003D7 RID: 983
		public extern int index { get; set; }

		// Token: 0x060003D8 RID: 984
		public extern SlopeLineDefinition(SlopeLineType nType, SlopeLineSide nSide, int nIndexFromOutsideEdgeToCL);

		// Token: 0x040002FA RID: 762
		private int <SyntheticNonEmptyStructMarker>;
	}
}
