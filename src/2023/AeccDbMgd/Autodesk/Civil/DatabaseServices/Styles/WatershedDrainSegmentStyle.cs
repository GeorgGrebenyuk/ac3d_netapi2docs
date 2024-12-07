using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F8C RID: 3980
	public class WatershedDrainSegmentStyle : WatershedBaseStyle
	{
		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06001EFF RID: 7935
		// (set) Token: 0x06001F00 RID: 7936
		public extern bool DrawDrainSegment { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06001F01 RID: 7937
		// (set) Token: 0x06001F02 RID: 7938
		public extern string SegmentLinetypeName { get; set; }

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06001F03 RID: 7939
		// (set) Token: 0x06001F04 RID: 7940
		public extern ObjectId SegmentLinetypeId { get; set; }

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06001F05 RID: 7941
		// (set) Token: 0x06001F06 RID: 7942
		public extern Color SegmentColor { get; set; }

		// Token: 0x04001863 RID: 6243
		private int <SyntheticNonEmptyStructMarker>;
	}
}
