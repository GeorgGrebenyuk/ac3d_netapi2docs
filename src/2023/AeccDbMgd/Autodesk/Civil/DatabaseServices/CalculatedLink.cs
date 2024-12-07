using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200117B RID: 4475
	public sealed class CalculatedLink : CalculatedSubentity
	{
		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06002576 RID: 9590
		public sealed override extern CorridorCodeCollection CorridorCodes { get; }

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06002577 RID: 9591
		public extern CalculatedPointCollection CalculatedPoints { get; }

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06002578 RID: 9592
		public extern CorridorLinkDrawOverride DrawOverride { get; }

		// Token: 0x04001ACA RID: 6858
		private int <SyntheticNonEmptyStructMarker>;
	}
}
