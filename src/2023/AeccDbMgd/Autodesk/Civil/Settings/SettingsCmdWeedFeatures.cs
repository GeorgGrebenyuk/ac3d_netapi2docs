using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D3B RID: 3387
	public sealed class SettingsCmdWeedFeatures : SettingsGrading
	{
		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x0600184D RID: 6221
		public extern SettingsCmdWeedFeatures.SettingsCmdFeatureLineWeed FeatureLineWeed { get; }

		// Token: 0x02000D3C RID: 3388
		public sealed class SettingsCmdFeatureLineWeed : TreeOidWrapper
		{
			// Token: 0x17000B4B RID: 2891
			// (get) Token: 0x0600184E RID: 6222
			public extern PropertyBoolean ApplyAngleFactor { get; }

			// Token: 0x17000B4A RID: 2890
			// (get) Token: 0x0600184F RID: 6223
			public extern PropertyDouble AngleFactor { get; }

			// Token: 0x17000B49 RID: 2889
			// (get) Token: 0x06001850 RID: 6224
			public extern PropertyBoolean ApplyGradeFactor { get; }

			// Token: 0x17000B48 RID: 2888
			// (get) Token: 0x06001851 RID: 6225
			public extern PropertyDouble GradeFactor { get; }

			// Token: 0x17000B47 RID: 2887
			// (get) Token: 0x06001852 RID: 6226
			public extern PropertyBoolean ApplyLengthFactor { get; }

			// Token: 0x17000B46 RID: 2886
			// (get) Token: 0x06001853 RID: 6227
			public extern PropertyDouble LengthFactor { get; }

			// Token: 0x17000B45 RID: 2885
			// (get) Token: 0x06001854 RID: 6228
			public extern PropertyBoolean ClosePointRemoval { get; }

			// Token: 0x17000B44 RID: 2884
			// (get) Token: 0x06001855 RID: 6229
			public extern PropertyDouble ClosePoint3DDistance { get; }
		}
	}
}
