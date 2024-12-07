using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020001CB RID: 459
	public sealed class PressurePipeStyleProfileOption
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000239 RID: 569
		// (set) Token: 0x0600023A RID: 570
		public extern double InnerDiameter { get; set; }

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600023B RID: 571
		// (set) Token: 0x0600023C RID: 572
		public extern double OuterDiameter { get; set; }

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600023D RID: 573
		// (set) Token: 0x0600023E RID: 574
		public extern double EndLineSize { get; set; }

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600023F RID: 575
		// (set) Token: 0x06000240 RID: 576
		public extern PressurePipeHatchType HatchOptions { get; set; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000241 RID: 577
		// (set) Token: 0x06000242 RID: 578
		public extern PressurePipeWallSizeType WallSizeType { get; set; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000243 RID: 579
		// (set) Token: 0x06000244 RID: 580
		public extern PressurePipeEndSizeType EndSizeType { get; set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000245 RID: 581
		// (set) Token: 0x06000246 RID: 582
		public extern bool AlignHatchToPipe { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000247 RID: 583
		// (set) Token: 0x06000248 RID: 584
		public extern PressurePipeHatchType CrossingHatch { get; set; }

		// Token: 0x04000223 RID: 547
		private int <SyntheticNonEmptyStructMarker>;
	}
}
