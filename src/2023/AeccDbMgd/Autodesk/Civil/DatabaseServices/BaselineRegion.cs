using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000BB0 RID: 2992
	public sealed class BaselineRegion : CivilWrapper<AeccDbCorridor>
	{
		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x0600165A RID: 5722
		// (set) Token: 0x0600165B RID: 5723
		public extern string Name { get; set; }

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x0600165C RID: 5724
		public extern ObjectId CorridorId { get; }

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x0600165D RID: 5725
		[DeprecatedVersion(CivilVersion.Civil2014)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.BaselineRegion.NeedsProcessing instead.", false)]
		public extern bool IsProcessed { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x0600165E RID: 5726
		// (set) Token: 0x0600165F RID: 5727
		public extern bool NeedsProcessing { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001660 RID: 5728
		public extern OffsetBaselineCollection OffsetBaselines { get; }

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001661 RID: 5729
		public extern AppliedAssemblyCollection AppliedAssemblies { get; }

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001662 RID: 5730
		// (set) Token: 0x06001663 RID: 5731
		public extern double StartStation { get; set; }

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001664 RID: 5732
		// (set) Token: 0x06001665 RID: 5733
		public extern double EndStation { get; set; }

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001666 RID: 5734
		// (set) Token: 0x06001667 RID: 5735
		public extern ObjectId AssemblyId { get; set; }

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001668 RID: 5736
		public extern Guid RegionGUID { get; }

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001669 RID: 5737
		public extern AppliedAssemblySetting AppliedAssemblySetting { get; }

		// Token: 0x0600166A RID: 5738
		public extern SubassemblyTargetInfoCollection GetTargets();

		// Token: 0x0600166B RID: 5739
		public extern void SetTargets(SubassemblyTargetInfoCollection updatedTargets);

		// Token: 0x0600166C RID: 5740
		public extern double[] SortedStations();

		// Token: 0x0600166D RID: 5741
		public extern double[] AdditionalStations();

		// Token: 0x0600166E RID: 5742
		public extern void ClearAdditionalStations();

		// Token: 0x0600166F RID: 5743
		public extern void AddStation(double rawStation, string description);

		// Token: 0x06001670 RID: 5744
		public extern void DeleteStation(double rawStation);

		// Token: 0x06001671 RID: 5745
		public extern BaselineRegion Split(double splitStation);

		// Token: 0x06001672 RID: 5746
		public extern OverriddenStationInfo[] GetOverriddenStations();

		// Token: 0x06001673 RID: 5747
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool RemoveOverriddenStation(double station);

		// Token: 0x06001674 RID: 5748
		public extern void Match(BaselineRegion sourceRegion, RegionMatchType matchOption);

		// Token: 0x06001675 RID: 5749
		public extern void Merge(BaselineRegion firstRegion, BaselineRegion lastRegion);

		// Token: 0x04001532 RID: 5426
		private int <SyntheticNonEmptyStructMarker>;
	}
}
