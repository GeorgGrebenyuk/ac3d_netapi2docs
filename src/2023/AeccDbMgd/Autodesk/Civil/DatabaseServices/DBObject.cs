using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000039 RID: 57
	[Wrapper("AeccDbTreeNode")]
	public class DBObject : DBObject
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000148 RID: 328
		public virtual extern object Application { get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000149 RID: 329
		public virtual extern object Document { get; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600014A RID: 330
		// (set) Token: 0x0600014B RID: 331
		public virtual extern string Name { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600014C RID: 332
		// (set) Token: 0x0600014D RID: 333
		public virtual extern string Description { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600014E RID: 334
		public extern bool IsUsed { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x0600014F RID: 335
		protected internal extern DBObject(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
