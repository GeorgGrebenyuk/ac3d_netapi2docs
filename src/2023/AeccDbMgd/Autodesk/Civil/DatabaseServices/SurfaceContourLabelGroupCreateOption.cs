using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000137 RID: 311
	public class SurfaceContourLabelGroupCreateOption
	{
		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000D0A RID: 3338
		// (set) Token: 0x06000D0B RID: 3339
		public extern bool ShowLabelLine { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000D0C RID: 3340
		// (set) Token: 0x06000D0D RID: 3341
		public extern ObjectId MajorContourlabelStyleId { get; set; }

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000D0E RID: 3342
		// (set) Token: 0x06000D0F RID: 3343
		public extern bool ShowMajorContourlabelgroup { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000D10 RID: 3344
		// (set) Token: 0x06000D11 RID: 3345
		public extern ObjectId MinorContourlabelStyleId { get; set; }

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000D12 RID: 3346
		// (set) Token: 0x06000D13 RID: 3347
		public extern bool ShowMinorContourlabelgroup { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000D14 RID: 3348
		// (set) Token: 0x06000D15 RID: 3349
		public extern ObjectId UserDefinedContourlabelStyleId { get; set; }

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000D16 RID: 3350
		// (set) Token: 0x06000D17 RID: 3351
		public extern bool ShowUserDefinedContourlabelgroup { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000D18 RID: 3352
		// (set) Token: 0x06000D19 RID: 3353
		public extern LabelMaskType MaskType { get; set; }

		// Token: 0x06000D1A RID: 3354
		public extern SurfaceContourLabelGroupCreateOption();

		// Token: 0x0400031E RID: 798
		private int <SyntheticNonEmptyStructMarker>;
	}
}
