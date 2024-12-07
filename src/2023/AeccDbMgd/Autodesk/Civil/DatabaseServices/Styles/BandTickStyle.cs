using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F99 RID: 3993
	public sealed class BandTickStyle : CivilWrapper<AeccDbGraphStyleBands>
	{
		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06001F2C RID: 7980
		// (set) Token: 0x06001F2D RID: 7981
		public extern bool IncrementTicksToFullHeight { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06001F2E RID: 7982
		// (set) Token: 0x06001F2F RID: 7983
		public extern bool IncrementSmallTicksAtTop { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06001F30 RID: 7984
		// (set) Token: 0x06001F31 RID: 7985
		public extern bool IncrementSmallTicksAtMiddle { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06001F32 RID: 7986
		// (set) Token: 0x06001F33 RID: 7987
		public extern bool IncrementSmallTicksAtBottom { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06001F34 RID: 7988
		// (set) Token: 0x06001F35 RID: 7989
		public extern double SmallTicksAtTopSize { get; set; }

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06001F36 RID: 7990
		// (set) Token: 0x06001F37 RID: 7991
		public extern double SmallTicksAtMiddleSize { get; set; }

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06001F38 RID: 7992
		// (set) Token: 0x06001F39 RID: 7993
		public extern double SmallTicksAtBottomSize { get; set; }

		// Token: 0x0400186A RID: 6250
		private int <SyntheticNonEmptyStructMarker>;
	}
}
