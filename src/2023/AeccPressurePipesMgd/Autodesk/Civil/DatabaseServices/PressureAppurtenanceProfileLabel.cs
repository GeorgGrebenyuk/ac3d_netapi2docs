using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200001A RID: 26
	[Wrapper("AeccDbAppurtenanceProfileLabel")]
	public sealed class PressureAppurtenanceProfileLabel : PressurePartProfileLabel
	{
		// Token: 0x06000136 RID: 310
		public static extern ObjectId Create(ObjectId profileViewPartId, ObjectId profileViewId, double ratio, Vector3d direction, ObjectId labelStyleId);

		// Token: 0x06000137 RID: 311
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId profileViewPartId, ObjectId profileViewId);

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000138 RID: 312
		// (set) Token: 0x06000139 RID: 313
		public extern double Ratio { get; set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600013A RID: 314
		// (set) Token: 0x0600013B RID: 315
		public extern Vector3d Direction { get; set; }
	}
}
