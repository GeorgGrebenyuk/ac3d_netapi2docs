using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200010F RID: 271
	[Wrapper("AeccDbSpanningPipeLabel")]
	public sealed class SpanningPipeLabel : FeatureLabel
	{
		// Token: 0x06000C09 RID: 3081
		public static extern ObjectId Create(ObjectIdCollection partIds, ObjectId anchorPipeId);

		// Token: 0x06000C0A RID: 3082
		public static extern ObjectId Create(ObjectIdCollection partIds, ObjectId anchorPipeId, double ratio, ObjectId labelStyleId);

		// Token: 0x06000C0B RID: 3083
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId pipeId);

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000C0C RID: 3084
		// (set) Token: 0x06000C0D RID: 3085
		public extern ObjectId ReferenceAlignmentId { get; set; }

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000C0E RID: 3086
		// (set) Token: 0x06000C0F RID: 3087
		public extern double Ratio { get; set; }

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000C10 RID: 3088
		public extern double Length2DCenterToCenter { get; }

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000C11 RID: 3089
		public extern double Length3DCenterToCenter { get; }

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000C12 RID: 3090
		public extern double Length2DEdgeToEdge { get; }

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000C13 RID: 3091
		public extern double Length3DEdgeToEdge { get; }

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000C14 RID: 3092
		public extern ObjectIdCollection PipeIds { get; }

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000C15 RID: 3093
		public extern ObjectIdCollection StructureIds { get; }

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000C16 RID: 3094
		// (set) Token: 0x06000C17 RID: 3095
		public extern ObjectId AnchorPipeId { get; set; }

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000C18 RID: 3096
		// (set) Token: 0x06000C19 RID: 3097
		public extern bool ShowSpannedPipes { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
	}
}
