using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F53 RID: 3923
	public sealed class HatchDisplayStyle : CivilWrapper<AeccDbStyle>
	{
		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06001D8F RID: 7567
		// (set) Token: 0x06001D90 RID: 7568
		public extern HatchType HatchType { get; set; }

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06001D91 RID: 7569
		// (set) Token: 0x06001D92 RID: 7570
		public extern string Pattern { get; set; }

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06001D93 RID: 7571
		// (set) Token: 0x06001D94 RID: 7572
		public extern double ScaleFactor { get; set; }

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06001D95 RID: 7573
		// (set) Token: 0x06001D96 RID: 7574
		public extern double Angle { get; set; }

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06001D97 RID: 7575
		// (set) Token: 0x06001D98 RID: 7576
		public extern bool UseAngleOfObject { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06001D99 RID: 7577
		// (set) Token: 0x06001D9A RID: 7578
		public extern double Spacing { get; set; }

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06001D9B RID: 7579
		// (set) Token: 0x06001D9C RID: 7580
		public extern double UOffset { get; set; }

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06001D9D RID: 7581
		// (set) Token: 0x06001D9E RID: 7582
		public extern double VOffset { get; set; }

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06001D9F RID: 7583
		// (set) Token: 0x06001DA0 RID: 7584
		public extern bool IsDoubleHatch { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x0400182F RID: 6191
		private int <SyntheticNonEmptyStructMarker>;
	}
}
