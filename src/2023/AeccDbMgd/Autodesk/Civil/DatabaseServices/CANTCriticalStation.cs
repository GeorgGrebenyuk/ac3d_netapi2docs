using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000741 RID: 1857
	public sealed class CANTCriticalStation
	{
		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06000E60 RID: 3680
		public extern ObjectId ParentAlignmentId { get; }

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06000E61 RID: 3681
		public extern string CANTCurveName { get; }

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06000E62 RID: 3682
		public extern SuperelevationCriticalStationType StationType { get; }

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06000E63 RID: 3683
		public extern SuperelevationTransitionRegionType TransitionRegionType { get; }

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06000E64 RID: 3684
		// (set) Token: 0x06000E65 RID: 3685
		public extern double Station { get; set; }

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06000E66 RID: 3686
		// (set) Token: 0x06000E67 RID: 3687
		public extern string TransitionDescription { get; set; }

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000E68 RID: 3688
		// (set) Token: 0x06000E69 RID: 3689
		public extern double AppliedCANT { get; set; }

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000E6A RID: 3690
		public extern double LeftRailElevationDifference { get; }

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000E6B RID: 3691
		public extern double RightRailElevationDifference { get; }

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000E6C RID: 3692
		public extern double EquilibriumCant { get; }

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000E6D RID: 3693
		public extern double CantDeficiency { get; }

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000E6E RID: 3694
		public extern double CantGradient { get; }

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06000E6F RID: 3695
		public extern double VerticalSpeed { get; }

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06000E70 RID: 3696
		public extern double LateralAcceleration { get; }

		// Token: 0x0400113B RID: 4411
		private int <SyntheticNonEmptyStructMarker>;
	}
}
