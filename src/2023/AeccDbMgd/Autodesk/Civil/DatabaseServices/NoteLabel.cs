using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000102 RID: 258
	[Wrapper("AeccDbNoteLabel")]
	public class NoteLabel : Label
	{
		// Token: 0x06000B9F RID: 2975
		public static extern ObjectId Create(Database database, Point3d location);

		// Token: 0x06000BA0 RID: 2976
		public static extern ObjectId Create(Point3d location, ObjectId labelStyleId, ObjectId markerStyleId);

		// Token: 0x06000BA1 RID: 2977
		public static extern ObjectIdCollection GetAvailableLabelIds(Database database);

		// Token: 0x06000BA2 RID: 2978
		protected internal extern NoteLabel(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
