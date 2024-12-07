using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000013 RID: 19
	[Wrapper("AeccDbFittingLabel")]
	public sealed class PressureFittingLabel : FeatureLabel
	{
		// Token: 0x06000112 RID: 274
		public static extern ObjectId Create(ObjectId fittingId, ObjectId styleId, double ratio, Vector3d direction);

		// Token: 0x06000113 RID: 275
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId fittingId);

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000114 RID: 276
		// (set) Token: 0x06000115 RID: 277
		public extern ObjectId ReferenceAlignmentId { get; set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000116 RID: 278
		// (set) Token: 0x06000117 RID: 279
		public extern double Ratio { get; set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000118 RID: 280
		// (set) Token: 0x06000119 RID: 281
		public extern Vector3d Direction { get; set; }
	}
}
