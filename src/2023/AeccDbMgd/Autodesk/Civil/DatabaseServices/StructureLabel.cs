using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000109 RID: 265
	[Wrapper("AeccDbStructureLabel")]
	public sealed class StructureLabel : FeatureLabel
	{
		// Token: 0x06000BEE RID: 3054
		public static extern ObjectId Create(ObjectId structureId);

		// Token: 0x06000BEF RID: 3055
		public static extern ObjectId Create(ObjectId structureId, ObjectId labelStyleId, Point3d labelLocation);

		// Token: 0x06000BF0 RID: 3056
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId structureId);

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000BF1 RID: 3057
		// (set) Token: 0x06000BF2 RID: 3058
		public extern ObjectId ReferenceAlignmentId { get; set; }
	}
}
