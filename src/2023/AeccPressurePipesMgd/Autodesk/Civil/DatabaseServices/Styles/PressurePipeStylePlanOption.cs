using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020001CA RID: 458
	public sealed class PressurePipeStylePlanOption
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600022B RID: 555
		// (set) Token: 0x0600022C RID: 556
		public extern double InnerDiameter { get; set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600022D RID: 557
		// (set) Token: 0x0600022E RID: 558
		public extern double OuterDiameter { get; set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600022F RID: 559
		// (set) Token: 0x06000230 RID: 560
		public extern double EndLineSize { get; set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000231 RID: 561
		// (set) Token: 0x06000232 RID: 562
		public extern PressurePipeHatchType HatchOptions { get; set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000233 RID: 563
		// (set) Token: 0x06000234 RID: 564
		public extern PressurePipeWallSizeType WallSizeType { get; set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000235 RID: 565
		// (set) Token: 0x06000236 RID: 566
		public extern PressurePipeEndSizeType EndSizeType { get; set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000237 RID: 567
		// (set) Token: 0x06000238 RID: 568
		public extern bool AlignHatchToPipe { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x04000222 RID: 546
		private int <SyntheticNonEmptyStructMarker>;
	}
}
