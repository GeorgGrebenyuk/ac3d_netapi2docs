using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000BC9 RID: 3017
	public sealed class OffsetBaseline : BaseBaseline
	{
		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x060016F4 RID: 5876
		public override extern CorridorBaselineType BaselineType { get; }

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x060016F5 RID: 5877
		public override extern ObjectId AlignmentId { get; }

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x060016F6 RID: 5878
		public override extern ObjectId ProfileId { get; }

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x060016F7 RID: 5879
		// (set) Token: 0x060016F8 RID: 5880
		public new extern double StartStation { get; set; }

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x060016F9 RID: 5881
		// (set) Token: 0x060016FA RID: 5882
		public new extern double EndStation { get; set; }

		// Token: 0x060016FB RID: 5883
		public sealed override extern double[] SortedStations();

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x060016FC RID: 5884
		public extern string Name { get; }

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x060016FD RID: 5885
		public extern Guid OffsetGUID { get; }

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060016FE RID: 5886
		[DeprecatedVersion(CivilVersion.Civil2014)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.OffsetBaseline.StartStation instead.", false)]
		public extern double StartStationOnMainBaseline { get; }

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060016FF RID: 5887
		[DeprecatedVersion(CivilVersion.Civil2014)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.OffsetBaseline.EndStation instead.", false)]
		public extern double EndStationOnMainBaseline { get; }

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001700 RID: 5888
		public extern BaselineFeatureLines RelatedOffsetBaselineFeatureLines { get; }

		// Token: 0x06001701 RID: 5889
		public extern double MainBaselineStationToOffsetBaselineStation(double mainBaselineStation);

		// Token: 0x06001702 RID: 5890
		public extern double OffsetBaselineStationToMainBaselineStation(double offsetBaselineStation);

		// Token: 0x06001703 RID: 5891
		public extern Point2d GetOffsetElevationFromMainBaselineStation(double mainBaselineStation);

		// Token: 0x06001704 RID: 5892
		[return: MarshalAs(UnmanagedType.U1)]
		public sealed override extern bool IsFeatureLineBased();

		// Token: 0x0400154F RID: 5455
		private int <SyntheticNonEmptyStructMarker>;
	}
}
