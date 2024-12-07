using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E68 RID: 3688
	public sealed class CurveCurveReverseCurveTransitionDescription : TransitionDescriptionBase
	{
		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06001C0D RID: 7181
		// (set) Token: 0x06001C0E RID: 7182
		public extern double FirstCurveRadius { get; set; }

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06001C0F RID: 7183
		// (set) Token: 0x06001C10 RID: 7184
		public extern double SecondCurveRadius { get; set; }

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06001C11 RID: 7185
		// (set) Token: 0x06001C12 RID: 7186
		public extern double ReverseCurveRadius { get; set; }

		// Token: 0x0400174E RID: 5966
		private int <SyntheticNonEmptyStructMarker>;
	}
}
