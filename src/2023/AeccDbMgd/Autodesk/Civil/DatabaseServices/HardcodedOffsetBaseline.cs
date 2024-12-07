using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200113A RID: 4410
	[Obsolete("This class is no longer used in Civil.", false)]
	[DeprecatedVersion(CivilVersion.Civil2014)]
	public sealed class HardcodedOffsetBaseline : BaseBaseline
	{
		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x0600248F RID: 9359
		public override extern CorridorBaselineType BaselineType { get; }

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06002490 RID: 9360
		public override extern ObjectId AlignmentId { get; }

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06002491 RID: 9361
		public override extern ObjectId ProfileId { get; }

		// Token: 0x06002492 RID: 9362
		public sealed override extern double[] SortedStations();

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06002493 RID: 9363
		public extern string Name { get; }

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06002494 RID: 9364
		public extern Point2d OffsetElevationFromMainBaseline { get; }

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06002495 RID: 9365
		public extern BaselineFeatureLines RelatedOffsetBaselineFeatureLines { get; }

		// Token: 0x06002496 RID: 9366
		[return: MarshalAs(UnmanagedType.U1)]
		public sealed override extern bool IsFeatureLineBased();

		// Token: 0x04001A8E RID: 6798
		private int <SyntheticNonEmptyStructMarker>;
	}
}
