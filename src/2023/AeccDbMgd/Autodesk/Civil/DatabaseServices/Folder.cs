using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000142 RID: 322
	[Wrapper("AeccDbClassFolderNode")]
	public class Folder : DBObject
	{
		// Token: 0x06000DC8 RID: 3528
		public extern ObjectId GetFolder(string nameOrPath);

		// Token: 0x06000DC9 RID: 3529
		public extern ObjectId CreateFolder(string name);

		// Token: 0x06000DCA RID: 3530
		public extern string GetPath();

		// Token: 0x06000DCB RID: 3531
		public extern ObjectId GetParent();

		// Token: 0x06000DCC RID: 3532
		public extern ObjectIdCollection GetSubFolders();

		// Token: 0x06000DCD RID: 3533
		public extern void RenameFolder(string newName);

		// Token: 0x06000DCE RID: 3534
		public extern void DeleteFolder();

		// Token: 0x06000DCF RID: 3535
		public extern void AddEntity(ObjectId entityId);

		// Token: 0x06000DD0 RID: 3536
		protected internal extern Folder(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
