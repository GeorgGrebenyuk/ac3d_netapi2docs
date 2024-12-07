using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200001C RID: 28
	[Wrapper("AeccDbAppurtenanceSectionLabel")]
	public sealed class PressureAppurtenanceSectionLabel : PressurePartSectionLabel
	{
		// Token: 0x0600013F RID: 319
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId appurtenanceId, ObjectId sectionNetworkId, int partIndex, double ratio, Vector3d direction, DimensionAnchorOptionType dimOpt, double dimVal);

		// Token: 0x06000140 RID: 320
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId appurtenanceId, ObjectId sectionNetworkId, int partIndex, double ratio, Vector3d direction, ObjectId labelStyleId, DimensionAnchorOptionType dimOpt, double dimVal);

		// Token: 0x06000141 RID: 321
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId sectionViewId, ObjectId appurtenanceId, ObjectId sectionNetworkId);
	}
}
