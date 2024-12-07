using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CF8 RID: 3320
	public sealed class SettingsCmdCreateSurfaceGridFromDEM : SettingsSurface
	{
		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x060017A9 RID: 6057
		public extern SettingsCmdCreateSurfaceGridFromDEM.SettingsCmdImportOptions ImportOptions { get; }

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x060017AA RID: 6058
		public extern SettingsCmdCreateSurfaceGridFromDEM.SettingsCmdBuildOptions BuildOptions { get; }

		// Token: 0x02000CF9 RID: 3321
		public sealed class SettingsCmdImportOptions : TreeOidWrapper
		{
			// Token: 0x17000AA2 RID: 2722
			// (get) Token: 0x060017AB RID: 6059
			public extern PropertyBoolean UseCustomNullElevation { get; }

			// Token: 0x17000AA1 RID: 2721
			// (get) Token: 0x060017AC RID: 6060
			public extern PropertyDouble NullElevation { get; }
		}

		// Token: 0x02000CFA RID: 3322
		public sealed class SettingsCmdBuildOptions : TreeOidWrapper
		{
			// Token: 0x17000AA7 RID: 2727
			// (get) Token: 0x060017AD RID: 6061
			public extern PropertyBoolean CopyDeletedDependentObjects { get; }

			// Token: 0x17000AA6 RID: 2726
			// (get) Token: 0x060017AE RID: 6062
			public extern PropertyBoolean ExcludeElevationsLessThan { get; }

			// Token: 0x17000AA5 RID: 2725
			// (get) Token: 0x060017AF RID: 6063
			public extern PropertyDouble ElevationLessThan { get; }

			// Token: 0x17000AA4 RID: 2724
			// (get) Token: 0x060017B0 RID: 6064
			public extern PropertyBoolean ExcludeElevationsGreaterThan { get; }

			// Token: 0x17000AA3 RID: 2723
			// (get) Token: 0x060017B1 RID: 6065
			public extern PropertyDouble ElevationGreaterThan { get; }
		}
	}
}
