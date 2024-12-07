using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000011 RID: 17
	[Wrapper("AeccDbPressurePipeLabel")]
	public sealed class PressurePipeLabel : FeatureLabel
	{
		// Token: 0x06000104 RID: 260
		public static extern ObjectId Create(ObjectId pipeId, double ratio, ObjectId labelStyleId);

		// Token: 0x06000105 RID: 261
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId pipeId);

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000106 RID: 262
		// (set) Token: 0x06000107 RID: 263
		public extern ObjectId ReferenceAlignmentId { get; set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000108 RID: 264
		// (set) Token: 0x06000109 RID: 265
		public extern double Ratio { get; set; }
	}
}
