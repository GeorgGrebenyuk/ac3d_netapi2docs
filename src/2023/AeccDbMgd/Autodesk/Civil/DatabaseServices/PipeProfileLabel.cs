using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200010B RID: 267
	[Wrapper("AeccDbPipeProfileLabel")]
	public sealed class PipeProfileLabel : PartProfileLabel
	{
		// Token: 0x06000BF7 RID: 3063
		public static extern ObjectId Create(ObjectId profileViewPartId, ObjectId profileViewId);

		// Token: 0x06000BF8 RID: 3064
		public static extern ObjectId Create(ObjectId profileViewPartId, ObjectId profileViewId, double ratio, ObjectId labelStyleId);

		// Token: 0x06000BF9 RID: 3065
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId profileViewId);

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000BFA RID: 3066
		// (set) Token: 0x06000BFB RID: 3067
		public extern double Ratio { get; set; }
	}
}
