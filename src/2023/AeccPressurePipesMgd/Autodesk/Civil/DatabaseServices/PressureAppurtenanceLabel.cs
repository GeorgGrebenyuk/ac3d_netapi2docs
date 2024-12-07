using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000012 RID: 18
	[Wrapper("AeccDbAppurtenanceLabel")]
	public sealed class PressureAppurtenanceLabel : FeatureLabel
	{
		// Token: 0x0600010A RID: 266
		public static extern ObjectId Create(ObjectId appurtenanceId, ObjectId styleId, double ratio, Vector3d direction);

		// Token: 0x0600010B RID: 267
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId appurtenanceId);

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600010C RID: 268
		// (set) Token: 0x0600010D RID: 269
		public extern ObjectId ReferenceAlignmentId { get; set; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600010E RID: 270
		// (set) Token: 0x0600010F RID: 271
		public extern double Ratio { get; set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000110 RID: 272
		// (set) Token: 0x06000111 RID: 273
		public extern Vector3d Direction { get; set; }
	}
}
