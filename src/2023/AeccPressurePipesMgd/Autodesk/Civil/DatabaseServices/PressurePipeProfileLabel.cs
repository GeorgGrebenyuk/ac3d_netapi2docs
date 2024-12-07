using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000015 RID: 21
	[Wrapper("AeccDbPressurePipeProfileLabel")]
	public sealed class PressurePipeProfileLabel : PressurePartProfileLabel
	{
		// Token: 0x0600011E RID: 286
		public static extern ObjectId Create(ObjectId profileViewPartId, ObjectId profileViewId, double ratio, ObjectId labelStyleId);

		// Token: 0x0600011F RID: 287
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId profileViewPartId, ObjectId profileViewId);

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000120 RID: 288
		// (set) Token: 0x06000121 RID: 289
		public extern double Ratio { get; set; }
	}
}
