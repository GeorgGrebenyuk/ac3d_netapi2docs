using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000CD RID: 205
	public abstract class PipeStyleOptionBase : CivilWrapper<AeccDbPipeStyle>
	{
		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000981 RID: 2433
		// (set) Token: 0x06000982 RID: 2434
		public extern double InnerDiameter { get; set; }

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000983 RID: 2435
		// (set) Token: 0x06000984 RID: 2436
		public extern double InnerDiameterPercent { get; set; }

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000985 RID: 2437
		// (set) Token: 0x06000986 RID: 2438
		public extern double OuterDiameter { get; set; }

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000987 RID: 2439
		// (set) Token: 0x06000988 RID: 2440
		public extern double OuterDiameterPercent { get; set; }

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000989 RID: 2441
		// (set) Token: 0x0600098A RID: 2442
		public extern double EndLineSize { get; set; }

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x0600098B RID: 2443
		// (set) Token: 0x0600098C RID: 2444
		public extern double EndLineSizePercent { get; set; }

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x0600098D RID: 2445
		// (set) Token: 0x0600098E RID: 2446
		public extern PipeHatchType HatchOptions { get; set; }

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x0600098F RID: 2447
		// (set) Token: 0x06000990 RID: 2448
		public extern PipeWallSizeType WallSizeType { get; set; }

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000991 RID: 2449
		// (set) Token: 0x06000992 RID: 2450
		public extern PipeEndSizeType EndSizeType { get; set; }

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000993 RID: 2451
		// (set) Token: 0x06000994 RID: 2452
		public extern PipeUserDefinedType WallSizeOptions { get; set; }

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000995 RID: 2453
		// (set) Token: 0x06000996 RID: 2454
		public extern PipeUserDefinedType EndSizeOptions { get; set; }

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000997 RID: 2455
		// (set) Token: 0x06000998 RID: 2456
		public extern bool AlignHatchToPipe { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000999 RID: 2457
		// (set) Token: 0x0600099A RID: 2458
		public extern bool PipeToPipeEndCleanup { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
	}
}
