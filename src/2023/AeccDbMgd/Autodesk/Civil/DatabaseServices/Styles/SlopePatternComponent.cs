using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F76 RID: 3958
	public sealed class SlopePatternComponent : CivilWrapper<AeccDbSlopePatternStyle>
	{
		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06001E48 RID: 7752
		public extern SlopePatternLine SlopeLine { get; }

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06001E49 RID: 7753
		public extern SlopePatternLineOffset SlopeLineOffset { get; }

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06001E4A RID: 7754
		public extern SlopePatternLineSymbol SlopeLineSymbol { get; }

		// Token: 0x04001850 RID: 6224
		private int <SyntheticNonEmptyStructMarker>;
	}
}
