using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000016 RID: 22
	[Wrapper("AeccDbCrossingPressurePipeProfileLabel")]
	public sealed class CrossingPressurePipeProfileLabel : PressurePartProfileLabel
	{
		// Token: 0x06000122 RID: 290
		public static extern ObjectIdCollection Create(ObjectId profileViewPartId, ObjectId profileViewId, double ratio, ObjectId labelStyleId);

		// Token: 0x06000123 RID: 291
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId profileViewPartId, ObjectId profileViewId);

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000124 RID: 292
		// (set) Token: 0x06000125 RID: 293
		public extern double Ratio { get; set; }
	}
}
