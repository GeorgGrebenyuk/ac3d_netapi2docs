using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000EB RID: 235
	[Wrapper("AeccDbCorridor")]
	public sealed class Corridor : Entity
	{
		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000A85 RID: 2693
		// (set) Token: 0x06000A86 RID: 2694
		public extern double MaximumTriangleSideLength { get; set; }

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000A87 RID: 2695
		// (set) Token: 0x06000A88 RID: 2696
		public extern string CodeSetStyleName { get; set; }

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000A89 RID: 2697
		// (set) Token: 0x06000A8A RID: 2698
		public extern ObjectId CodeSetStyleId { get; set; }

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000A8B RID: 2699
		public extern BaselineCollection Baselines { get; }

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000A8C RID: 2700
		public extern FeatureLineCodeInfoCollection FeatureLineCodeInfos { get; }

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000A8D RID: 2701
		public extern CorridorSlopePatternCollection SlopePatterns { get; }

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000A8E RID: 2702
		public extern CorridorSurfaceCollection CorridorSurfaces { get; }

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000A8F RID: 2703
		// (set) Token: 0x06000A90 RID: 2704
		public extern bool RebuildAutomatic { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000A91 RID: 2705
		public extern bool IsOutOfDate { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000A92 RID: 2706
		// (set) Token: 0x06000A93 RID: 2707
		public extern CorridorRegionLockType RegionLockMode { get; set; }

		// Token: 0x06000A94 RID: 2708
		public extern void Rebuild();

		// Token: 0x06000A95 RID: 2709
		public extern ObjectId ExportFeatureLinesAsCogoPoints(string pointGroupName, CorridorPointCodeSelector codes, ValueType baseLineRange);

		// Token: 0x06000A96 RID: 2710
		public extern ObjectId ExportFeatureLinesAsCogoPoints(string pointGroupName, CorridorPointCodeSelector codes);

		// Token: 0x06000A97 RID: 2711
		public extern SubassemblyTargetInfoCollection GetTargets();

		// Token: 0x06000A98 RID: 2712
		public extern void SetTargets(SubassemblyTargetInfoCollection updatedTargets);

		// Token: 0x06000A99 RID: 2713
		public extern string[] GetPointCodes();

		// Token: 0x06000A9A RID: 2714
		public extern string[] GetLinkCodes();

		// Token: 0x06000A9B RID: 2715
		public extern string[] GetShapeCodes();

		// Token: 0x17000486 RID: 1158
		// (set) Token: 0x06000A9C RID: 2716
		public override extern string StyleName { set; }

		// Token: 0x17000485 RID: 1157
		// (set) Token: 0x06000A9D RID: 2717
		public override extern ObjectId StyleId { set; }
	}
}
