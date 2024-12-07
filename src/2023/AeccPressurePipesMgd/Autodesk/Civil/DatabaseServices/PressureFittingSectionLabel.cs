using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200001B RID: 27
	[Wrapper("AeccDbFittingSectionLabel")]
	public sealed class PressureFittingSectionLabel : PressurePartSectionLabel
	{
		// Token: 0x0600013C RID: 316
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId fittingId, ObjectId sectionNetworkId, int partIndex, double ratio, Vector3d direction, DimensionAnchorOptionType dimOpt, double dimVal);

		// Token: 0x0600013D RID: 317
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId fittingId, ObjectId sectionNetworkId, int partIndex, double ratio, Vector3d direction, ObjectId labelStyleId, DimensionAnchorOptionType dimOpt, double dimVal);

		// Token: 0x0600013E RID: 318
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId sectionViewId, ObjectId fittingId, ObjectId sectionNetworkId);
	}
}
