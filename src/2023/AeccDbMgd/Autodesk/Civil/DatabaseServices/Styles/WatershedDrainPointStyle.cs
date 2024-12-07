using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Colors;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F8B RID: 3979
	public class WatershedDrainPointStyle : WatershedBaseStyle
	{
		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06001EF9 RID: 7929
		// (set) Token: 0x06001EFA RID: 7930
		public extern bool DrawDrainPoint { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06001EFB RID: 7931
		// (set) Token: 0x06001EFC RID: 7932
		public extern PointSymbolType PointDisplayType { get; set; }

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06001EFD RID: 7933
		// (set) Token: 0x06001EFE RID: 7934
		public extern Color PointColor { get; set; }

		// Token: 0x04001862 RID: 6242
		private int <SyntheticNonEmptyStructMarker>;
	}
}
