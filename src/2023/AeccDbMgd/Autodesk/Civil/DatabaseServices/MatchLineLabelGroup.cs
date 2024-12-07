using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200007B RID: 123
	[Wrapper("AeccDbMatchLineLabeling")]
	public sealed class MatchLineLabelGroup : AutoFeatureLabelGroup
	{
		// Token: 0x06000581 RID: 1409
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId viewFrameGroupId);

		// Token: 0x06000582 RID: 1410
		public static extern ObjectId Create(ObjectId viewFrameGroupId, EntitySideType side);

		// Token: 0x06000583 RID: 1411
		public static extern ObjectId Create(ObjectId viewFrameGroupId, EntitySideType side, ObjectId labelStyleId, MatchLineLabelLocationType anchorPosition);

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000584 RID: 1412
		public extern EntitySideType Side { get; }

		// Token: 0x06000585 RID: 1413
		public static extern ObjectId GetLabelGroupIdBySide(ObjectId viewFrameGroupId, EntitySideType side);
	}
}
