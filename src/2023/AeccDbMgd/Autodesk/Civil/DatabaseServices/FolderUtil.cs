using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020006FF RID: 1791
	public class FolderUtil
	{
		// Token: 0x06000E1F RID: 3615
		public static extern ObjectId GetNonAlignmentRootFolder(RXClass rxClass, Database database);

		// Token: 0x06000E20 RID: 3616
		public static extern ObjectId GetAlignmentRootFolder(AlignmentType aType, Database database);

		// Token: 0x06000E21 RID: 3617
		public extern FolderUtil();
	}
}
