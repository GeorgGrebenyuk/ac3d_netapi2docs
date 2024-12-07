using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200075C RID: 1884
	public abstract class ConnectedAlignmentInfo
	{
		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06000E80 RID: 3712
		public extern ObjectId IncomingParentAlignmentId { get; }

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06000E81 RID: 3713
		public extern ObjectId OutgoingParentAlignmentId { get; }

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06000E82 RID: 3714
		// (set) Token: 0x06000E83 RID: 3715
		public extern AlignmentUpdateModeType UpdateMode { get; set; }

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06000E84 RID: 3716
		public extern CurbReturnCurveGroupType CurveGroupType { get; }

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06000E85 RID: 3717
		// (set) Token: 0x06000E86 RID: 3718
		public extern double OffsetIn { get; set; }

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06000E87 RID: 3719
		// (set) Token: 0x06000E88 RID: 3720
		public extern double OffsetOut { get; set; }

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06000E89 RID: 3721
		public extern bool GreaterThan180 { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06000E8A RID: 3722
		// (set) Token: 0x06000E8B RID: 3723
		public extern double ConnectionOverlapLengthIn { get; set; }

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06000E8C RID: 3724
		// (set) Token: 0x06000E8D RID: 3725
		public extern double ConnectionOverlapLengthOut { get; set; }

		// Token: 0x04001155 RID: 4437
		protected unsafe AeccDbAlignment* m_pDbAlignment;
	}
}
