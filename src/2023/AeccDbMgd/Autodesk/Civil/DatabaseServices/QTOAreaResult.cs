using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B61 RID: 2913
	public class QTOAreaResult : CivilWrapper<AeccQuantityTakeoffResult::SECTIONAL_RESULT>
	{
		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001592 RID: 5522
		public extern double CutArea { get; }

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001593 RID: 5523
		public extern double FillArea { get; }

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001594 RID: 5524
		public extern double MomentOfCutArea { get; }

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001595 RID: 5525
		public extern double MomentOfFillArea { get; }

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001596 RID: 5526
		public extern double FactoredCutArea { get; }

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001597 RID: 5527
		public extern double FactoredFillArea { get; }

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001598 RID: 5528
		public extern double FactoredUsableArea { get; }

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001599 RID: 5529
		public extern double MomentOfFactoredCutArea { get; }

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x0600159A RID: 5530
		public extern double MomentOfFactoredFillArea { get; }

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x0600159B RID: 5531
		public extern double MomentOfFactoredUsableArea { get; }
	}
}
