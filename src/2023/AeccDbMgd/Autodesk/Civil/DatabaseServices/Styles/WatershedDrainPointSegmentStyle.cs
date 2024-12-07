using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F8D RID: 3981
	public class WatershedDrainPointSegmentStyle : WatershedBaseStyle
	{
		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06001F07 RID: 7943
		// (set) Token: 0x06001F08 RID: 7944
		public extern bool DrawDrainPoint { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06001F09 RID: 7945
		// (set) Token: 0x06001F0A RID: 7946
		public extern PointSymbolType PointDisplayType { get; set; }

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06001F0B RID: 7947
		// (set) Token: 0x06001F0C RID: 7948
		public extern Color PointColor { get; set; }

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06001F0D RID: 7949
		// (set) Token: 0x06001F0E RID: 7950
		public extern bool DrawDrainSegment { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06001F0F RID: 7951
		// (set) Token: 0x06001F10 RID: 7952
		public extern string SegmentLinetypeName { get; set; }

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06001F11 RID: 7953
		// (set) Token: 0x06001F12 RID: 7954
		public extern ObjectId SegmentLinetypeId { get; set; }

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06001F13 RID: 7955
		// (set) Token: 0x06001F14 RID: 7956
		public extern Color SegmentColor { get; set; }

		// Token: 0x04001864 RID: 6244
		private int <SyntheticNonEmptyStructMarker>;
	}
}
