using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000764 RID: 1892
	public struct RailCANTInfo
	{
		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06000EE3 RID: 3811
		public extern RailAlignmentPivotType Pivot { get; }

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06000EE4 RID: 3812
		public extern double AppliedCANT { get; }

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06000EE5 RID: 3813
		public extern double LeftRailElevationDifference { get; }

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06000EE6 RID: 3814
		public extern double RightRailElevationDifference { get; }

		// Token: 0x04001156 RID: 4438
		private RailAlignmentPivotType m_ePivot;

		// Token: 0x04001157 RID: 4439
		private double m_dAppliedCANT;

		// Token: 0x04001158 RID: 4440
		private double m_dLeftRailElevDiff;

		// Token: 0x04001159 RID: 4441
		private double m_dRightRailElevDiff;
	}
}
