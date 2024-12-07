using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F83 RID: 3971
	public sealed class SurfaceGridStyle : SurfaceBaseStyle
	{
		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06001EB4 RID: 7860
		// (set) Token: 0x06001EB5 RID: 7861
		public extern bool UsePrimaryGrid { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06001EB6 RID: 7862
		// (set) Token: 0x06001EB7 RID: 7863
		public extern double PrimaryGridInterval { get; set; }

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06001EB8 RID: 7864
		// (set) Token: 0x06001EB9 RID: 7865
		public extern double PrimaryGridOrientation { get; set; }

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06001EBA RID: 7866
		// (set) Token: 0x06001EBB RID: 7867
		public extern bool UseSecondaryGrid { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06001EBC RID: 7868
		// (set) Token: 0x06001EBD RID: 7869
		public extern double SecondaryGridInterval { get; set; }

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06001EBE RID: 7870
		// (set) Token: 0x06001EBF RID: 7871
		public extern double SecondaryGridOrientation { get; set; }
	}
}
