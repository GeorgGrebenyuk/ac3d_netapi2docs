using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000019 RID: 25
	[Wrapper("AeccDbFittingProfileLabel")]
	public sealed class PressureFittingProfileLabel : PressurePartProfileLabel
	{
		// Token: 0x06000130 RID: 304
		public static extern ObjectId Create(ObjectId profileViewPartId, ObjectId profileViewId, double ratio, Vector3d direction, ObjectId labelStyleId);

		// Token: 0x06000131 RID: 305
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId profileViewPartId, ObjectId profileViewId);

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000132 RID: 306
		// (set) Token: 0x06000133 RID: 307
		public extern double Ratio { get; set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000134 RID: 308
		// (set) Token: 0x06000135 RID: 309
		public extern Vector3d Direction { get; set; }
	}
}
