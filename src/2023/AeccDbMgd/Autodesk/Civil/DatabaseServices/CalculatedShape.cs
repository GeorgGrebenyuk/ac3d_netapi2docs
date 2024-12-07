using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001188 RID: 4488
	public sealed class CalculatedShape : CalculatedSubentity
	{
		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06002584 RID: 9604
		public sealed override extern CorridorCodeCollection CorridorCodes { get; }

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06002585 RID: 9605
		public extern CalculatedLinkCollection CalculatedLinks { get; }

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06002586 RID: 9606
		public extern double Area { get; }
	}
}
