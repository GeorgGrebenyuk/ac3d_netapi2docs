using System;
using System.Collections.Generic;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using CollaborationUtils;

namespace Autodesk.Civil.AeccUiMgd
{
	// Token: 0x02000182 RID: 386
	public class DataSharingUtils
	{
		// Token: 0x06000186 RID: 390
		public static extern void ShowDesktopConnectorErrorMessage(ReturnCode errorCode);

		// Token: 0x06000187 RID: 391
		public static extern List<string> GetDependencyFiles(Database db);

		// Token: 0x06000188 RID: 392
		public static extern void DowngradeDocOpen(Document doc);

		// Token: 0x06000189 RID: 393
		public extern DataSharingUtils();
	}
}
