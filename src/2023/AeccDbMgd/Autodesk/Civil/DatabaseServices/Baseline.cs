using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001114 RID: 4372
	public sealed class Baseline : BaseBaseline
	{
		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x060023EC RID: 9196
		public override extern CorridorBaselineType BaselineType { get; }

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x060023ED RID: 9197
		public override extern ObjectId AlignmentId { get; }

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x060023EE RID: 9198
		public override extern Guid baselineGUID { get; }

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x060023EF RID: 9199
		public override extern ObjectId ProfileId { get; }

		// Token: 0x060023F0 RID: 9200
		public sealed override extern double[] SortedStations();

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x060023F1 RID: 9201
		// (set) Token: 0x060023F2 RID: 9202
		public extern string Name { get; set; }

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x060023F3 RID: 9203
		[DeprecatedVersion(CivilVersion.Civil2014)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Baseline.NeedsProcessing instead.", false)]
		public extern bool IsProcessed { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x060023F4 RID: 9204
		// (set) Token: 0x060023F5 RID: 9205
		public extern bool NeedsProcessing { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x060023F6 RID: 9206
		public extern BaselineRegionCollection BaselineRegions { get; }

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x060023F7 RID: 9207
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Baseline.GetAppliedAssemblyAtIndex instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2014)]
		public extern AppliedAssembly AppliedAssembly { get; }

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x060023F8 RID: 9208
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Baseline.GetAppliedAssemblyAtIndex instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2014)]
		public extern AppliedAssembly AppliedAssembly { get; }

		// Token: 0x060023F9 RID: 9209
		public extern AppliedAssembly GetAppliedAssemblyAtIndex(int index);

		// Token: 0x060023FA RID: 9210
		public extern AppliedAssembly GetAppliedAssemblyAtStation(double station);

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x060023FB RID: 9211
		public extern BaselineFeatureLinesCollection OffsetBaselineFeatureLinesCol { get; }

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x060023FC RID: 9212
		public extern BaselineFeatureLines MainBaselineFeatureLines { get; }

		// Token: 0x060023FD RID: 9213
		public extern SubassemblyTargetInfoCollection GetTargets();

		// Token: 0x060023FE RID: 9214
		public extern void SetTargets(SubassemblyTargetInfoCollection updatedTargets);

		// Token: 0x060023FF RID: 9215
		[return: MarshalAs(UnmanagedType.U1)]
		public sealed override extern bool IsFeatureLineBased();

		// Token: 0x06002400 RID: 9216
		public extern void UpdateStation(double station);

		// Token: 0x04001A70 RID: 6768
		private int <SyntheticNonEmptyStructMarker>;
	}
}
