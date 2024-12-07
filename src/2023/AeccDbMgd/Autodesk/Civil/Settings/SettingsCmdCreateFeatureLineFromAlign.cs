using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D28 RID: 3368
	public sealed class SettingsCmdCreateFeatureLineFromAlign : SettingsGrading
	{
		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06001820 RID: 6176
		public extern SettingsCmdCreateFeatureLineFromAlign.SettingsCmdFeatureLineCreation FeatureLineCreation { get; }

		// Token: 0x02000D29 RID: 3369
		public sealed class SettingsCmdFeatureLineCreation : TreeOidWrapper
		{
			// Token: 0x17000B1D RID: 2845
			// (get) Token: 0x06001821 RID: 6177
			public extern PropertyBoolean UseFeatureLineName { get; }

			// Token: 0x17000B1C RID: 2844
			// (get) Token: 0x06001822 RID: 6178
			public extern PropertyBoolean UseFeatureLineStyle { get; }

			// Token: 0x17000B1B RID: 2843
			// (get) Token: 0x06001823 RID: 6179
			public extern PropertyEnum<FeatureLineLayerSettingType> LayerSetting { get; }

			// Token: 0x17000B1A RID: 2842
			// (get) Token: 0x06001824 RID: 6180
			public extern PropertyBoolean WeedPoints { get; }

			// Token: 0x17000B19 RID: 2841
			// (get) Token: 0x06001825 RID: 6181
			public extern PropertyBoolean CreateDynamicLink { get; }

			// Token: 0x17000B18 RID: 2840
			// (get) Token: 0x06001826 RID: 6182
			public extern PropertyDouble MidOrdinateDistance { get; }

			// Token: 0x17000B17 RID: 2839
			// (get) Token: 0x06001827 RID: 6183
			public extern PropertyDouble SpiralTessellationFactor { get; }
		}
	}
}
