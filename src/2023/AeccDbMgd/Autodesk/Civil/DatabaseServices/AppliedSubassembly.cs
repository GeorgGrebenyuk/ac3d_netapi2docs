using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001139 RID: 4409
	public sealed class AppliedSubassembly : CivilWrapper<AeccDbCorridor>
	{
		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06002485 RID: 9349
		public extern ObjectId CorridorId { get; }

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06002486 RID: 9350
		public extern CalculatedPointCollection Points { get; }

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x06002487 RID: 9351
		public extern CalculatedLinkCollection Links { get; }

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x06002488 RID: 9352
		public extern CalculatedShapeCollection Shapes { get; }

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06002489 RID: 9353
		public extern Point3d OriginStationOffsetElevationToBaseline { get; }

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x0600248A RID: 9354
		public extern BaseBaseline BaselineHookedTo { get; }

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x0600248B RID: 9355
		public extern ObjectId SubassemblyId { get; }

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x0600248C RID: 9356
		public extern IAppliedSubassemblyParam[] Parameters { get; }

		// Token: 0x0600248D RID: 9357
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Contains(string paramKeyName);

		// Token: 0x0600248E RID: 9358
		public extern AppliedSubassemblyParam<T> GetParameter<T>(string paramKeyName);

		// Token: 0x04001A8D RID: 6797
		private int <SyntheticNonEmptyStructMarker>;
	}
}
