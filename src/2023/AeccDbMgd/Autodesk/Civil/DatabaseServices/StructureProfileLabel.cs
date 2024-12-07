using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000111 RID: 273
	[Wrapper("AeccDbStructureProfileLabel")]
	public sealed class StructureProfileLabel : PartProfileLabel
	{
		// Token: 0x06000C2B RID: 3115
		public static extern ObjectId Create(ObjectId profileViewId, ObjectId profileViewPartId);

		// Token: 0x06000C2C RID: 3116
		public static extern ObjectId Create(ObjectId profileViewId, ObjectId profileViewPartId, ObjectId labelStyleId);

		// Token: 0x06000C2D RID: 3117
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId profileViewId);
	}
}
