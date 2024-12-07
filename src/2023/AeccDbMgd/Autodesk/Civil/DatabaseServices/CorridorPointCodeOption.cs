using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000E9 RID: 233
	public class CorridorPointCodeOption
	{
		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000A79 RID: 2681
		// (set) Token: 0x06000A7A RID: 2682
		public extern string CodeName { get; set; }

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000A7B RID: 2683
		// (set) Token: 0x06000A7C RID: 2684
		public extern bool Selected { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000A7D RID: 2685
		public extern CorridorPointCodeOption();

		// Token: 0x04000311 RID: 785
		private int <SyntheticNonEmptyStructMarker>;
	}
}
