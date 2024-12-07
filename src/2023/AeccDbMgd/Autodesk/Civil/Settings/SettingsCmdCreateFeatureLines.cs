using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D2A RID: 3370
	public sealed class SettingsCmdCreateFeatureLines : SettingsGrading
	{
		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06001828 RID: 6184
		public extern SettingsCmdCreateFeatureLines.SettingsCmdFeatureLineCreation FeatureLineCreation { get; }

		// Token: 0x02000D2B RID: 3371
		public sealed class SettingsCmdFeatureLineCreation : TreeOidWrapper
		{
			// Token: 0x17000B26 RID: 2854
			// (get) Token: 0x06001829 RID: 6185
			public extern PropertyBoolean UseFeatureLineName { get; }

			// Token: 0x17000B25 RID: 2853
			// (get) Token: 0x0600182A RID: 6186
			public extern PropertyBoolean UseFeatureLineStyle { get; }

			// Token: 0x17000B24 RID: 2852
			// (get) Token: 0x0600182B RID: 6187
			public extern PropertyEnum<FeatureLineLayerSettingType> LayerSetting { get; }

			// Token: 0x17000B23 RID: 2851
			// (get) Token: 0x0600182C RID: 6188
			public extern PropertyBoolean EraseExistingEntities { get; }

			// Token: 0x17000B22 RID: 2850
			// (get) Token: 0x0600182D RID: 6189
			public extern PropertyBoolean WeedPoints { get; }

			// Token: 0x17000B21 RID: 2849
			// (get) Token: 0x0600182E RID: 6190
			public extern PropertyBoolean AssignElevations { get; }

			// Token: 0x17000B20 RID: 2848
			// (get) Token: 0x0600182F RID: 6191
			public extern PropertyEnum<ElevationSourceType> ElevationSource { get; }

			// Token: 0x17000B1F RID: 2847
			// (get) Token: 0x06001830 RID: 6192
			public extern PropertyBoolean IncludeMidElevationBreaks { get; }
		}
	}
}
