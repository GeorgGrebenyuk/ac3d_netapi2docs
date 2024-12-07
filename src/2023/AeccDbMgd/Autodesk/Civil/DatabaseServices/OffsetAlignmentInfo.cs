using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DFB RID: 3579
	public class OffsetAlignmentInfo : CivilWrapper<AeccDbAlignment>
	{
		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06001A93 RID: 6803
		public extern ObjectId ParentAlignmentId { get; }

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06001A94 RID: 6804
		public extern AlignmentRegionCollection Regions { get; }

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06001A95 RID: 6805
		public extern AlignmentTransitionCollection Transitions { get; }

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06001A96 RID: 6806
		// (set) Token: 0x06001A97 RID: 6807
		public extern AlignmentLockModeType LockMode { get; set; }

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06001A98 RID: 6808
		// (set) Token: 0x06001A99 RID: 6809
		public extern bool LockToStartStation { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06001A9A RID: 6810
		// (set) Token: 0x06001A9B RID: 6811
		public extern bool LockToEndStation { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06001A9C RID: 6812
		// (set) Token: 0x06001A9D RID: 6813
		public extern double NominalOffset { get; set; }

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06001A9E RID: 6814
		// (set) Token: 0x06001A9F RID: 6815
		public extern AlignmentUpdateModeType UpdateMode { get; set; }

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06001AA0 RID: 6816
		public extern EntitySideType Side { get; }

		// Token: 0x06001AA1 RID: 6817
		public extern void AddWidening(double startStation, double endStation, double offsetDistance);

		// Token: 0x06001AA2 RID: 6818
		public extern void AddAutoWidenings(AutoWideningCriteriaInfo wideningCriteria, AlignmentSubEntityArc[] curveGroups);

		// Token: 0x06001AA3 RID: 6819
		public extern void AddAutoWidenings(AutoWideningCriteriaInfo wideningCriteria, SweptCurveLocation location);

		// Token: 0x06001AA4 RID: 6820
		public extern void AddAutoWidenings(AutoWideningInfo wideningInfo, AlignmentSubEntityArc[] curveGroups);

		// Token: 0x06001AA5 RID: 6821
		public extern void AddAutoWidenings(AutoWideningInfo wideningInfo, SweptCurveLocation location);
	}
}
