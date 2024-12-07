using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F57 RID: 3927
	public sealed class GridOptions : CivilWrapper<AeccDbGraphStyle>
	{
		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06001DA5 RID: 7589
		// (set) Token: 0x06001DA6 RID: 7590
		public extern bool UseClipGrid { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06001DA7 RID: 7591
		// (set) Token: 0x06001DA8 RID: 7592
		public extern bool ClipToHighestProfile { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06001DA9 RID: 7593
		// (set) Token: 0x06001DAA RID: 7594
		public extern bool OmitGridInPaddingAreas { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x04001836 RID: 6198
		private int <SyntheticNonEmptyStructMarker>;
	}
}
