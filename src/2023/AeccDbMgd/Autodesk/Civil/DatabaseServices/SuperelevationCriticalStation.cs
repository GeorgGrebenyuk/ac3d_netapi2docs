using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E6E RID: 3694
	public sealed class SuperelevationCriticalStation
	{
		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06001C28 RID: 7208
		public extern ObjectId ParentAlignmentId { get; }

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06001C29 RID: 7209
		public extern string SuperelevationCurveName { get; }

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06001C2A RID: 7210
		public extern SuperelevationTransitionRegionType TransitionRegionType { get; }

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06001C2B RID: 7211
		public extern SuperelevationCriticalStationType StationType { get; }

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06001C2C RID: 7212
		// (set) Token: 0x06001C2D RID: 7213
		public extern double Station { get; set; }

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06001C2E RID: 7214
		// (set) Token: 0x06001C2F RID: 7215
		public extern string TransitionDescription { get; set; }

		// Token: 0x06001C30 RID: 7216
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsGradeBreak(SuperelevationCrossSegmentType crossSegmentType);

		// Token: 0x06001C31 RID: 7217
		public extern void RemoveGradeBreak(SuperelevationCrossSegmentType crossSegmentType);

		// Token: 0x06001C32 RID: 7218
		public extern void BreakSegment(SuperelevationCrossSegmentType crossSegmentType);

		// Token: 0x06001C33 RID: 7219
		public extern double GetSlope(SuperelevationCrossSegmentType crossSegmentType);

		// Token: 0x06001C34 RID: 7220
		public extern void SetSlope(SuperelevationCrossSegmentType crossSegmentType, double slope);

		// Token: 0x06001C35 RID: 7221
		public extern double GetSmoothingLength(SuperelevationCrossSegmentType crossSegmentType);

		// Token: 0x06001C36 RID: 7222
		public extern void SetSmoothingLength(SuperelevationCrossSegmentType crossSegmentType, double length);

		// Token: 0x04001751 RID: 5969
		private int <SyntheticNonEmptyStructMarker>;
	}
}
