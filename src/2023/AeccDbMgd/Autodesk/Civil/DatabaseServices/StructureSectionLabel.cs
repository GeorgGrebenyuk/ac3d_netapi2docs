using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200010E RID: 270
	[Wrapper("AeccDbStructureSectionLabel")]
	public sealed class StructureSectionLabel : PartSectionLabel
	{
		// Token: 0x06000C06 RID: 3078
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId structureId, ObjectId sectionPipeNetworkId, int partIndex);

		// Token: 0x06000C07 RID: 3079
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId structureId, ObjectId sectionPipeNetworkId, int partIndex, ObjectId labelStyleId);

		// Token: 0x06000C08 RID: 3080
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId sectionViewId);
	}
}
