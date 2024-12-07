using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200116A RID: 4458
	public sealed class FeatureLinePoint : CivilWrapper<AeccDbCorridor>
	{
		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x060024FB RID: 9467
		public extern ObjectId CorridorId { get; }

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x060024FC RID: 9468
		public extern double Station { get; }

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x060024FD RID: 9469
		public extern double Offset { get; }

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x060024FE RID: 9470
		public extern Point3d XYZ { get; }

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x060024FF RID: 9471
		public extern bool IsBreak { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x04001AB9 RID: 6841
		private int <SyntheticNonEmptyStructMarker>;
	}
}
