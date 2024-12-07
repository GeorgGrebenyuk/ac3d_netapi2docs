using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A0B RID: 2571
	public sealed class SurfaceAnalysisWatershedData : ISurfaceAnalysis
	{
		// Token: 0x06001351 RID: 4945
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe extern void Initialize(AeccDbSurface.ColorValue* codeValue);

		// Token: 0x06001352 RID: 4946
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe extern void Update(AeccDbSurface.ColorValue* A_0);

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001353 RID: 4947
		public extern int AreaID { get; }

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001354 RID: 4948
		public extern WatershedType Type { get; }

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001355 RID: 4949
		// (set) Token: 0x06001356 RID: 4950
		public extern bool Visible { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001357 RID: 4951
		public extern int[] DrainsInto { get; }

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001358 RID: 4952
		// (set) Token: 0x06001359 RID: 4953
		public extern string Description { get; set; }

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x0600135A RID: 4954
		// (set) Token: 0x0600135B RID: 4955
		public extern Color SegmentColor { get; set; }

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x0600135C RID: 4956
		// (set) Token: 0x0600135D RID: 4957
		public extern ObjectId SegmentLineTypeId { get; set; }

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x0600135E RID: 4958
		// (set) Token: 0x0600135F RID: 4959
		public extern LineWeight SegmentLineWeight { get; set; }

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001360 RID: 4960
		// (set) Token: 0x06001361 RID: 4961
		public extern string AreaHatchPatternName { get; set; }

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001362 RID: 4962
		// (set) Token: 0x06001363 RID: 4963
		public extern Color AreaColor { get; set; }

		// Token: 0x06001364 RID: 4964
		public extern SurfaceAnalysisWatershedData();

		// Token: 0x040013F5 RID: 5109
		private int <SyntheticNonEmptyStructMarker>;
	}
}
