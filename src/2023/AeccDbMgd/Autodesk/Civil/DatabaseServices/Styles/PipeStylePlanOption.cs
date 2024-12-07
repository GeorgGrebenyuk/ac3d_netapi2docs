using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000CE RID: 206
	public sealed class PipeStylePlanOption : PipeStyleOptionBase
	{
		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600099B RID: 2459
		// (set) Token: 0x0600099C RID: 2460
		public extern double CenterlineSize { get; set; }

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x0600099D RID: 2461
		// (set) Token: 0x0600099E RID: 2462
		public extern double CenterlineSizePercent { get; set; }

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x0600099F RID: 2463
		// (set) Token: 0x060009A0 RID: 2464
		public extern PipeCenterlineWidthType CenterlineWidthOptions { get; set; }

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060009A1 RID: 2465
		// (set) Token: 0x060009A2 RID: 2466
		public extern PipeCenterlineType CenterlineOptions { get; set; }
	}
}
