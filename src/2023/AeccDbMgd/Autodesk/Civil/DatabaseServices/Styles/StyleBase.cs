using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200005B RID: 91
	[Wrapper("AeccDbStyle")]
	public class StyleBase : DBObject
	{
		// Token: 0x17000135 RID: 309
		// (set) Token: 0x060003EB RID: 1003
		public override extern string Name { set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003EC RID: 1004
		// (set) Token: 0x060003ED RID: 1005
		public extern string CreateBy { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003EE RID: 1006
		public extern string ModifiedBy { get; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003EF RID: 1007
		public extern string DateCreated { get; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003F0 RID: 1008
		public extern string DateModified { get; }

		// Token: 0x060003F1 RID: 1009
		public virtual extern ObjectId CopyAsSibling(string styleName);

		// Token: 0x060003F2 RID: 1010
		public static extern void ExportTo(ObjectIdCollection styleIds, Database destinationDatabase, StyleConflictResolverType conflictResolution);

		// Token: 0x060003F3 RID: 1011
		public extern void ExportTo(Database destinationDatabase, StyleConflictResolverType conflictResolution);

		// Token: 0x060003F4 RID: 1012
		protected internal extern StyleBase(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
