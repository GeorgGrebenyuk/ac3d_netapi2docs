using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000048 RID: 72
	public struct SurfaceMinimizeFlatAreaOptions
	{
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600021A RID: 538
		// (set) Token: 0x0600021B RID: 539
		public extern bool FillGaps { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600021C RID: 540
		// (set) Token: 0x0600021D RID: 541
		public extern bool SwapEdges { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600021E RID: 542
		// (set) Token: 0x0600021F RID: 543
		public extern bool AddPointsToTriangles { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000220 RID: 544
		// (set) Token: 0x06000221 RID: 545
		public extern bool AddPointsToEdges { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000222 RID: 546
		public extern SurfaceMinimizeFlatAreaOptions([MarshalAs(UnmanagedType.U1)] bool fillGaps, [MarshalAs(UnmanagedType.U1)] bool swapEdges, [MarshalAs(UnmanagedType.U1)] bool addPointsToTriangles, [MarshalAs(UnmanagedType.U1)] bool addPointsToEdges);

		// Token: 0x040002E7 RID: 743
		private bool <backing_store>FillGaps;

		// Token: 0x040002E8 RID: 744
		private bool <backing_store>SwapEdges;

		// Token: 0x040002E9 RID: 745
		private bool <backing_store>AddPointsToTriangles;

		// Token: 0x040002EA RID: 746
		private bool <backing_store>AddPointsToEdges;
	}
}
