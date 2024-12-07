using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000107 RID: 263
	[Wrapper("AeccDbFlowSegmentLabel")]
	public sealed class FlowSegmentLabel : FeatureLabel
	{
		// Token: 0x06000BE0 RID: 3040
		public static extern ObjectId Create(FlowSegment flowSegment);

		// Token: 0x06000BE1 RID: 3041
		public static extern ObjectId Create(FlowSegment flowSegment, ObjectId labelStyleId);

		// Token: 0x06000BE2 RID: 3042
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId catchmentId);

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000BE3 RID: 3043
		// (set) Token: 0x06000BE4 RID: 3044
		public extern double Ratio { get; set; }

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000BE5 RID: 3045
		// (set) Token: 0x06000BE6 RID: 3046
		public extern int FlowSegmentIndex { get; set; }
	}
}
