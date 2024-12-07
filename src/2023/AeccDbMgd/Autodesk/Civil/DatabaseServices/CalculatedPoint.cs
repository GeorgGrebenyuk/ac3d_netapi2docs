using System;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200117D RID: 4477
	public sealed class CalculatedPoint : CalculatedSubentity
	{
		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06002579 RID: 9593
		public sealed override extern CorridorCodeCollection CorridorCodes { get; }

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x0600257A RID: 9594
		public extern Point3d StationOffsetElevationToBaseline { get; }

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x0600257B RID: 9595
		public extern Point3d StationOffsetElevationToSubassembly { get; }

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x0600257C RID: 9596
		public extern Point3d XYZ { get; }

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x0600257D RID: 9597
		public extern Vector3d NormalToSubassembly { get; }

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x0600257E RID: 9598
		public extern Vector3d NormalToBaseline { get; }

		// Token: 0x04001ACF RID: 6863
		private int <SyntheticNonEmptyStructMarker>;
	}
}
