using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200013E RID: 318
	[Wrapper("AeccDbPointDescKeySet")]
	public class PointDescriptionKeySet : DBObject
	{
		// Token: 0x06000D81 RID: 3457
		public extern ObjectIdCollection GetPointDescriptionKeyIds();

		// Token: 0x1700058A RID: 1418
		public extern ObjectId this[string codeName]
		{
			get;
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000D83 RID: 3459
		public extern int Count { get; }

		// Token: 0x06000D84 RID: 3460
		public extern ObjectId Add(string codeName);

		// Token: 0x06000D85 RID: 3461
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Contains(string name);

		// Token: 0x06000D86 RID: 3462
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Contains(ObjectId objectId);

		// Token: 0x06000D87 RID: 3463
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(ObjectId keyId);

		// Token: 0x06000D88 RID: 3464
		public extern void Clear();
	}
}
