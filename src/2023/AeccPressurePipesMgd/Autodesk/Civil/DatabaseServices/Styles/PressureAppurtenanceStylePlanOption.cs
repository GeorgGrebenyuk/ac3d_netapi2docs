using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000189 RID: 393
	public sealed class PressureAppurtenanceStylePlanOption
	{
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600019E RID: 414
		// (set) Token: 0x0600019F RID: 415
		public extern PressureAppurtenancePlanViewType ViewOptions { get; set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001A0 RID: 416
		// (set) Token: 0x060001A1 RID: 417
		public extern ObjectId SymbolBlockId { get; set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001A2 RID: 418
		// (set) Token: 0x060001A3 RID: 419
		public extern double SymbolBlockScaleX { get; set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001A4 RID: 420
		// (set) Token: 0x060001A5 RID: 421
		public extern double SymbolBlockScaleY { get; set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001A6 RID: 422
		// (set) Token: 0x060001A7 RID: 423
		public extern double SymbolBlockScaleZ { get; set; }

		// Token: 0x04000205 RID: 517
		private int <SyntheticNonEmptyStructMarker>;
	}
}
