using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D1B RID: 3355
	public sealed class SettingsCmdCreateParcelROW : SettingsParcel
	{
		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06001802 RID: 6146
		public extern SettingsCmdCreateParcelROW.SettingsCmdCreateParcelRightOfWay CreateParcelRightOfWay { get; }

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06001803 RID: 6147
		public extern SettingsCmdCreateParcelROW.SettingsCmdCleanupAtParcelBoundaries CleanupAtParcelBoundaries { get; }

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06001804 RID: 6148
		public extern SettingsCmdCreateParcelROW.SettingsCmdCleanupAtAlignmentIntersections CleanupAtAlignmentIntersections { get; }

		// Token: 0x02000D1C RID: 3356
		public sealed class SettingsCmdCreateParcelRightOfWay : TreeOidWrapper
		{
			// Token: 0x17000AFB RID: 2811
			// (get) Token: 0x06001805 RID: 6149
			public extern PropertyDouble OffsetFromAlignment { get; }
		}

		// Token: 0x02000D1D RID: 3357
		public sealed class SettingsCmdCleanupAtParcelBoundaries : TreeOidWrapper
		{
			// Token: 0x17000AFD RID: 2813
			// (get) Token: 0x06001806 RID: 6150
			public extern PropertyDouble FilletRadiusAtParcelBoundaryIntersections { get; }

			// Token: 0x17000AFC RID: 2812
			// (get) Token: 0x06001807 RID: 6151
			public extern PropertyEnum<ROWCleanupType> CleanupMethodFillet { get; }
		}

		// Token: 0x02000D1E RID: 3358
		public sealed class SettingsCmdCleanupAtAlignmentIntersections : TreeOidWrapper
		{
			// Token: 0x17000AFF RID: 2815
			// (get) Token: 0x06001808 RID: 6152
			public extern PropertyDouble FilletRadiusAtAlignmentIntersections { get; }

			// Token: 0x17000AFE RID: 2814
			// (get) Token: 0x06001809 RID: 6153
			public extern PropertyEnum<ROWCleanupType> CleanupMethodFillet { get; }
		}
	}
}
