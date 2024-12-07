using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200013C RID: 316
	[Wrapper("AeccDbViewFrameLabeling")]
	public sealed class ViewFrameLabelGroup : AutoFeatureLabelGroup
	{
		// Token: 0x06000D55 RID: 3413
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId viewFrameGroupId);

		// Token: 0x06000D56 RID: 3414
		public static extern ObjectId Create(ObjectId viewFrameGroupId);

		// Token: 0x06000D57 RID: 3415
		public static extern ObjectId Create(ObjectId viewFrameGroupId, ObjectId labelStyleId, ViewFrameLabelLocationType anchorPosition);
	}
}
