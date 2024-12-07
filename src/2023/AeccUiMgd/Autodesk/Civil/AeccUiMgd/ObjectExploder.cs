using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd
{
	// Token: 0x0200005C RID: 92
	public class ObjectExploder
	{
		// Token: 0x0600000D RID: 13
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool ConvertC3DToACAD(string fromDwgFile, string toDwgFile, XREFOption xrefOption, ExportSaveFormat saveFormat, out string errorMessage);

		// Token: 0x0600000E RID: 14
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool ConvertDwgToDgn(string fromDwgFile, string toDgnFile, string seedFile, string setupFile, int dgnFormat);

		// Token: 0x0600000F RID: 15
		public static extern void SetIsInExplodeCogoPoints([MarshalAs(UnmanagedType.U1)] bool inExplode);

		// Token: 0x06000010 RID: 16
		public static extern void SetExportFeatureLineAs3D(ExportFeatureLineType exportType);

		// Token: 0x06000011 RID: 17
		public static extern void SetIsInC3DExportPaperSpace([MarshalAs(UnmanagedType.U1)] bool inC3DExportPaperSpace);

		// Token: 0x06000012 RID: 18
		public static extern void GetAndClearC3DExportToDwgMTextInfo(out string mtextInfo);

		// Token: 0x06000013 RID: 19
		public extern ObjectExploder();
	}
}
