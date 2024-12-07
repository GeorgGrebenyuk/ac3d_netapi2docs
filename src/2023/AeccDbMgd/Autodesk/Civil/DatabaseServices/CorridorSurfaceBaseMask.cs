using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001171 RID: 4465
	public abstract class CorridorSurfaceBaseMask : CivilWrapper<AeccDbCorridor>
	{
		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x0600253D RID: 9533
		public extern ObjectId CorridorId { get; }

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x0600253E RID: 9534
		// (set) Token: 0x0600253F RID: 9535
		public extern string Name { get; set; }

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06002540 RID: 9536
		// (set) Token: 0x06002541 RID: 9537
		public extern string Description { get; set; }

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06002542 RID: 9538
		public extern FeatureLineComponentCollection FeatureLineComponents { get; }

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06002543 RID: 9539
		public extern bool IsDefinedFromPolygon { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x06002544 RID: 9540
		public extern Point3d[] PolygonPoints();

		// Token: 0x06002545 RID: 9541
		[HandleProcessCorruptedStateExceptions]
		protected override extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x04001AC0 RID: 6848
		private int <SyntheticNonEmptyStructMarker>;
	}
}
