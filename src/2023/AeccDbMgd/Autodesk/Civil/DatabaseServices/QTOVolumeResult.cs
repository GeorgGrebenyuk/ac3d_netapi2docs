using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B62 RID: 2914
	public class QTOVolumeResult : CivilWrapper<AeccQuantityTakeoffResult::SECTIONAL_RESULT>
	{
		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x0600159C RID: 5532
		public extern double CumulativeCutVolume { get; }

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x0600159D RID: 5533
		public extern double CumulativeFillVolume { get; }

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x0600159E RID: 5534
		public extern double CumulativeUsableVolume { get; }

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x0600159F RID: 5535
		public extern double IncrementalCutVolume { get; }

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x060015A0 RID: 5536
		public extern double IncrementalFillVolume { get; }

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060015A1 RID: 5537
		public extern double IncrementalUsableVolume { get; }
	}
}
