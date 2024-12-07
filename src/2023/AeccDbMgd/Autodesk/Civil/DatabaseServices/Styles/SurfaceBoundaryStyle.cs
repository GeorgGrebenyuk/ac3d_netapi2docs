using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F7C RID: 3964
	public sealed class SurfaceBoundaryStyle : SurfaceBaseStyle
	{
		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06001E86 RID: 7814
		// (set) Token: 0x06001E87 RID: 7815
		public extern bool DisplayExteriorBoundaries { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06001E88 RID: 7816
		// (set) Token: 0x06001E89 RID: 7817
		public extern bool DisplayInteriorBoundaries { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06001E8A RID: 7818
		// (set) Token: 0x06001E8B RID: 7819
		public extern bool UseDatum { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06001E8C RID: 7820
		// (set) Token: 0x06001E8D RID: 7821
		public extern bool ProjectGridToDatum { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06001E8E RID: 7822
		// (set) Token: 0x06001E8F RID: 7823
		public extern double DatumElevation { get; set; }
	}
}
