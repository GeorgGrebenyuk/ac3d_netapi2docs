using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200018C RID: 396
	public sealed class PressureFittingStylePlanOption
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001A9 RID: 425
		// (set) Token: 0x060001AA RID: 426
		public extern PressureFittingPlanViewType ViewOptions { get; set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001AB RID: 427
		// (set) Token: 0x060001AC RID: 428
		public extern ObjectId SymbolBlockId { get; set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001AD RID: 429
		// (set) Token: 0x060001AE RID: 430
		public extern double SymbolBlockScaleX { get; set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001AF RID: 431
		// (set) Token: 0x060001B0 RID: 432
		public extern double SymbolBlockScaleY { get; set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001B1 RID: 433
		// (set) Token: 0x060001B2 RID: 434
		public extern double SymbolBlockScaleZ { get; set; }

		// Token: 0x0400020A RID: 522
		private int <SyntheticNonEmptyStructMarker>;
	}
}
