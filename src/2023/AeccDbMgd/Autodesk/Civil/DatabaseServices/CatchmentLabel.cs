using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000104 RID: 260
	[Wrapper("AeccDbCatchmentAreaLabel")]
	public sealed class CatchmentLabel : FeatureLabel
	{
		// Token: 0x06000BB0 RID: 2992
		public static extern ObjectId Create(ObjectId catchmentId);

		// Token: 0x06000BB1 RID: 2993
		public static extern ObjectId Create(ObjectId catchmentId, ObjectId labelStyleId);

		// Token: 0x06000BB2 RID: 2994
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId catchmentId);
	}
}
