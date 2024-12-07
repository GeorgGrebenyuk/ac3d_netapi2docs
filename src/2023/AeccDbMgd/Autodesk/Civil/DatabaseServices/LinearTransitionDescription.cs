using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E6B RID: 3691
	public sealed class LinearTransitionDescription : TransitionDescriptionBase
	{
		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06001C1B RID: 7195
		// (set) Token: 0x06001C1C RID: 7196
		public extern double TaperRatio { get; set; }

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06001C1D RID: 7197
		// (set) Token: 0x06001C1E RID: 7198
		public extern TaperInputType TaperInput { get; set; }
	}
}
