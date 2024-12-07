using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000108 RID: 264
	[Wrapper("AeccDbPipeLabel")]
	public sealed class PipeLabel : FeatureLabel
	{
		// Token: 0x06000BE7 RID: 3047
		public static extern ObjectId Create(ObjectId pipeId, double ratio);

		// Token: 0x06000BE8 RID: 3048
		public static extern ObjectId Create(ObjectId pipeId, double ratio, ObjectId labelStyleId);

		// Token: 0x06000BE9 RID: 3049
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId pipeId);

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000BEA RID: 3050
		// (set) Token: 0x06000BEB RID: 3051
		public extern ObjectId ReferenceAlignmentId { get; set; }

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000BEC RID: 3052
		// (set) Token: 0x06000BED RID: 3053
		public extern double Ratio { get; set; }
	}
}
