using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CF3 RID: 3315
	public sealed class SettingsCmdCreateSurface : SettingsSurface
	{
		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06001793 RID: 6035
		public extern SettingsCmdCreateSurface.SettingsNameFormat NameFormat { get; }

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06001794 RID: 6036
		public extern SettingsCmdCreateSurface.SettingsCmdSurfaceCreation SurfaceCreation { get; }

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06001795 RID: 6037
		public extern SettingsCmdCreateSurface.SettingsCmdBuildOptions BuildOptions { get; }

		// Token: 0x02000CF4 RID: 3316
		public sealed class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x17000A8C RID: 2700
			// (get) Token: 0x06001796 RID: 6038
			public extern PropertyString Surface { get; }
		}

		// Token: 0x02000CF5 RID: 3317
		public sealed class SettingsCmdSurfaceCreation : TreeOidWrapper
		{
			// Token: 0x17000A92 RID: 2706
			// (get) Token: 0x06001797 RID: 6039
			public extern PropertyEnum<SurfaceType> DefaultType { get; }

			// Token: 0x17000A91 RID: 2705
			// (get) Token: 0x06001798 RID: 6040
			public extern PropertyDouble CutFactor { get; }

			// Token: 0x17000A90 RID: 2704
			// (get) Token: 0x06001799 RID: 6041
			public extern PropertyDouble FillFactor { get; }

			// Token: 0x17000A8F RID: 2703
			// (get) Token: 0x0600179A RID: 6042
			public extern PropertyDouble GridSurfaceXSpacing { get; }

			// Token: 0x17000A8E RID: 2702
			// (get) Token: 0x0600179B RID: 6043
			public extern PropertyDouble GridSurfaceYSpacing { get; }

			// Token: 0x17000A8D RID: 2701
			// (get) Token: 0x0600179C RID: 6044
			public extern PropertyDouble GridSurfaceOrientation { get; }
		}

		// Token: 0x02000CF6 RID: 3318
		public sealed class SettingsCmdBuildOptions : TreeOidWrapper
		{
			// Token: 0x17000A9E RID: 2718
			// (get) Token: 0x0600179D RID: 6045
			public extern PropertyBoolean CopyDeletedDependentObjects { get; }

			// Token: 0x17000A9D RID: 2717
			// (get) Token: 0x0600179E RID: 6046
			public extern PropertyBoolean ExcludeElevationsLessThan { get; }

			// Token: 0x17000A9C RID: 2716
			// (get) Token: 0x0600179F RID: 6047
			public extern PropertyDouble ElevationLessThan { get; }

			// Token: 0x17000A9B RID: 2715
			// (get) Token: 0x060017A0 RID: 6048
			public extern PropertyBoolean ExcludeElevationsGreaterThan { get; }

			// Token: 0x17000A9A RID: 2714
			// (get) Token: 0x060017A1 RID: 6049
			public extern PropertyDouble ElevationGreaterThan { get; }

			// Token: 0x17000A99 RID: 2713
			// (get) Token: 0x060017A2 RID: 6050
			public extern PropertyBoolean UseMaximumAngle { get; }

			// Token: 0x17000A98 RID: 2712
			// (get) Token: 0x060017A3 RID: 6051
			public extern PropertyDouble MaximumAngleBetweenAdjacentTINLines { get; }

			// Token: 0x17000A97 RID: 2711
			// (get) Token: 0x060017A4 RID: 6052
			public extern PropertyBoolean UseMaximumTriangleLength { get; }

			// Token: 0x17000A96 RID: 2710
			// (get) Token: 0x060017A5 RID: 6053
			public extern PropertyDouble MaximumTriangleLength { get; }

			// Token: 0x17000A95 RID: 2709
			// (get) Token: 0x060017A6 RID: 6054
			public extern PropertyBoolean ConvertProximityBreaklinesToStandard { get; }

			// Token: 0x17000A94 RID: 2708
			// (get) Token: 0x060017A7 RID: 6055
			public extern PropertyBoolean AllowCrossingBreaklines { get; }

			// Token: 0x17000A93 RID: 2707
			// (get) Token: 0x060017A8 RID: 6056
			public extern PropertyEnum<ElevationToUseType> ElevationToUse { get; }
		}
	}
}
