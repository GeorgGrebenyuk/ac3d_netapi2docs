using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200013B RID: 315
	[Wrapper("AeccDbSampleLineLabeling")]
	public class SampleLineLabelGroup : AutoFeatureLabelGroup
	{
		// Token: 0x06000D4F RID: 3407
		public static extern ObjectIdCollection GetAvailableLabelGroupIds(ObjectId sampleLineGroupId);

		// Token: 0x06000D50 RID: 3408
		public static extern ObjectId Create(ObjectId sampleLineGroupId);

		// Token: 0x06000D51 RID: 3409
		public static extern ObjectId Create(ObjectId sampleLineGroupId, ObjectId labelStyleId);

		// Token: 0x06000D52 RID: 3410
		protected internal extern SampleLineLabelGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x06000D53 RID: 3411
		protected override extern double GetFeatureStartStation();

		// Token: 0x06000D54 RID: 3412
		protected override extern double GetFeatureEndStation();
	}
}
