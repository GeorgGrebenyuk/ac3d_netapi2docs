using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DCA RID: 3530
	public class UDPInteger : UDP
	{
		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06001A24 RID: 6692
		// (set) Token: 0x06001A25 RID: 6693
		public new extern int DefaultValue { get; set; }

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06001A26 RID: 6694
		// (set) Token: 0x06001A27 RID: 6695
		public extern bool UpperBoundInclusive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06001A28 RID: 6696
		// (set) Token: 0x06001A29 RID: 6697
		public extern bool LowerBoundInclusive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06001A2A RID: 6698
		// (set) Token: 0x06001A2B RID: 6699
		public extern int UpperBoundValue { get; set; }

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06001A2C RID: 6700
		// (set) Token: 0x06001A2D RID: 6701
		public extern int LowerBoundValue { get; set; }

		// Token: 0x04001679 RID: 5753
		private int <SyntheticNonEmptyStructMarker>;
	}
}
