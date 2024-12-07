using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200010D RID: 269
	[Wrapper("AeccDbPipeSectionLabel")]
	public sealed class PipeSectionLabel : PartSectionLabel
	{
		// Token: 0x06000C03 RID: 3075
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId pipeId, ObjectId sectionPipeNetworkId, int partIndex);

		// Token: 0x06000C04 RID: 3076
		public static extern ObjectId Create(ObjectId sectionViewId, ObjectId pipeId, ObjectId sectionPipeNetworkId, int partIndex, ObjectId labelStyleId);

		// Token: 0x06000C05 RID: 3077
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId sectionViewId);
	}
}
