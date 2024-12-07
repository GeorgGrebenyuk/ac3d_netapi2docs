using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000018 RID: 24
	[Wrapper("AeccDbPressurePipeSectionLabel")]
	public sealed class PressurePipeSectionLabel : PressurePartSectionLabel
	{
		// Token: 0x0600012D RID: 301
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId pipeId, ObjectId sectionNetworkId, int partIndex, double ratio, Vector3d direction, DimensionAnchorOptionType dimOpt, double dimVal);

		// Token: 0x0600012E RID: 302
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId pipeId, ObjectId sectionNetworkId, int partIndex, double ratio, Vector3d direction, ObjectId labelStyleId, DimensionAnchorOptionType dimOpt, double dimVal);

		// Token: 0x0600012F RID: 303
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId sectionViewId, ObjectId pipeId, ObjectId sectionNetworkId);
	}
}
