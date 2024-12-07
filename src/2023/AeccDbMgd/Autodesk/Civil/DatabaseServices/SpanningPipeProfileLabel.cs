using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000110 RID: 272
	[Wrapper("AeccDbSpanningPipeProfileLabel")]
	public sealed class SpanningPipeProfileLabel : FeatureLabel
	{
		// Token: 0x06000C1A RID: 3098
		public static extern ObjectId Create(ObjectIdCollection profileViewPartIds, ObjectId anchorProfileViewPartId, ObjectId profileViewId);

		// Token: 0x06000C1B RID: 3099
		public static extern ObjectId Create(ObjectIdCollection profileViewPartIds, ObjectId anchorProfileViewPartId, ObjectId profileViewId, double ratio, ObjectId labelStyleId);

		// Token: 0x06000C1C RID: 3100
		public static extern ObjectIdCollection GetAvailableLabelIds(ObjectId profileViewId);

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000C1D RID: 3101
		// (set) Token: 0x06000C1E RID: 3102
		public extern ObjectId ReferenceAlignmentId { get; set; }

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000C1F RID: 3103
		// (set) Token: 0x06000C20 RID: 3104
		public extern double Ratio { get; set; }

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000C21 RID: 3105
		public extern double Length2DCenterToCenter { get; }

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000C22 RID: 3106
		public extern double Length3DCenterToCenter { get; }

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000C23 RID: 3107
		public extern double Length2DEdgeToEdge { get; }

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000C24 RID: 3108
		public extern double Length3DEdgeToEdge { get; }

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000C25 RID: 3109
		// (set) Token: 0x06000C26 RID: 3110
		public extern bool ShowSpannedProfileViewPipes { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000C27 RID: 3111
		public extern ObjectIdCollection ProfileViewPipeIds { get; }

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000C28 RID: 3112
		public extern ObjectIdCollection ProfileViewStructureIds { get; }

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000C29 RID: 3113
		// (set) Token: 0x06000C2A RID: 3114
		public extern ObjectId AnchorProfileViewPartId { get; set; }
	}
}
