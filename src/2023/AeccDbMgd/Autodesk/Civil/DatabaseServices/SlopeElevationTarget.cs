using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200118F RID: 4495
	[Wrapper("AeccSlopeElevationTarget")]
	public class SlopeElevationTarget : CivilWrapper<AeccSlopeElevationTarget>
	{
		// Token: 0x06002594 RID: 9620
		public extern SlopeElevationTarget(ObjectId targetId);

		// Token: 0x06002595 RID: 9621
		public extern double GetElevation(ObjectId alignmentId, double stationOnAlignment, AlignmentSide side);

		// Token: 0x06002596 RID: 9622
		public extern double GetElevation(ObjectId alignmentId, double stationOnAlignment);

		// Token: 0x06002597 RID: 9623
		public extern void GetNearestPipeOfNetworkToAlignment(ObjectId alignmentId, double stationOnAlignment, AlignmentSide side, ref ObjectId pipeId);

		// Token: 0x06002598 RID: 9624
		public extern void GetNearestPipeOfNetworkToAlignment(ObjectId alignmentId, double stationOnAlignment, ref ObjectId pipeId);

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06002599 RID: 9625
		public extern ObjectId TargetId { get; }
	}
}
