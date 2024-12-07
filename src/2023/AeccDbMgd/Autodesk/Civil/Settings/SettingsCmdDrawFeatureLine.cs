using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D30 RID: 3376
	public sealed class SettingsCmdDrawFeatureLine : SettingsGrading
	{
		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x0600183A RID: 6202
		public extern SettingsCmdDrawFeatureLine.SettingsCmdFeatureLineCreation FeatureLineCreation { get; }

		// Token: 0x02000D31 RID: 3377
		public sealed class SettingsCmdFeatureLineCreation : TreeOidWrapper
		{
			// Token: 0x17000B33 RID: 2867
			// (get) Token: 0x0600183B RID: 6203
			public extern PropertyBoolean UseFeatureLineName { get; }

			// Token: 0x17000B32 RID: 2866
			// (get) Token: 0x0600183C RID: 6204
			public extern PropertyBoolean UseFeatureLineStyle { get; }

			// Token: 0x17000B31 RID: 2865
			// (get) Token: 0x0600183D RID: 6205
			public extern PropertyEnum<FeatureLineLayerSettingType> LayerSetting { get; }
		}
	}
}
