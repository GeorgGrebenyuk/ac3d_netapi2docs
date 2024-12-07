using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000BB1 RID: 2993
	public sealed class AdditionalAppliedAssemblyInfo
	{
		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001676 RID: 5750
		// (set) Token: 0x06001677 RID: 5751
		public extern double Station { get; set; }

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001678 RID: 5752
		// (set) Token: 0x06001679 RID: 5753
		public extern string Description { get; set; }

		// Token: 0x0600167A RID: 5754
		public extern AdditionalAppliedAssemblyInfo(double station, string description);

		// Token: 0x04001533 RID: 5427
		private int <SyntheticNonEmptyStructMarker>;
	}
}
