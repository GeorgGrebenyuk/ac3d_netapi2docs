using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001192 RID: 4498
	[Wrapper("AeccWidthOffsetTarget")]
	public class WidthOffsetTarget : CivilWrapper<AeccWidthOffsetTarget>
	{
		// Token: 0x0600259D RID: 9629
		public extern WidthOffsetTarget(ObjectId targetId);

		// Token: 0x0600259E RID: 9630
		public extern double GetDistanceToAlignment(ObjectId alignmentId, double stationOnAlignment, ref double xOnTarget, ref double yOnTarget);

		// Token: 0x0600259F RID: 9631
		public extern double GetDistanceToAlignment(ObjectId alignmentId, double stationOnAlignment, AlignmentSide side, ref double xOnTarget, ref double yOnTarget);

		// Token: 0x060025A0 RID: 9632
		public extern void GetNearestPipeOfNetworkToAlignment(ObjectId alignmentId, double stationOnAlignment, AlignmentSide side, ref ObjectId pipeId);

		// Token: 0x060025A1 RID: 9633
		public extern void GetNearestPipeOfNetworkToAlignment(ObjectId alignmentId, double stationOnAlignment, ref ObjectId pipeId);

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x060025A2 RID: 9634
		public extern ObjectId TargetId { get; }
	}
}
