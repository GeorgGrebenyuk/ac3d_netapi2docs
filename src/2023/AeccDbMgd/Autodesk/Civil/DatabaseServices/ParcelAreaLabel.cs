using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000112 RID: 274
	[Wrapper("AeccDbParcelFaceLabel")]
	public class ParcelAreaLabel : FeatureLabel
	{
		// Token: 0x06000C2E RID: 3118
		public static extern ObjectId Create(ObjectId parcelId);

		// Token: 0x06000C2F RID: 3119
		public static extern ObjectId Create(ObjectId parcelId, ObjectId labelStyleId);

		// Token: 0x06000C30 RID: 3120
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId parcelId);
	}
}
