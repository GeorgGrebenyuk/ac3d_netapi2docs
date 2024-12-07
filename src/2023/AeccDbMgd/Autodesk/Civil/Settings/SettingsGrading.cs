using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D27 RID: 3367
	public class SettingsGrading : SettingsAmbient
	{
		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x0600181E RID: 6174
		public extern SettingsGrading.SettingsStyles Styles { get; }

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x0600181F RID: 6175
		public extern SettingsGrading.SettingsNameFormat NameFormat { get; }

		// Token: 0x02000D97 RID: 3479
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17000C58 RID: 3160
			// (get) Token: 0x0600195B RID: 6491
			public extern PropertyString CutSlopeGrading { get; }

			// Token: 0x17000C57 RID: 3159
			// (get) Token: 0x0600195C RID: 6492
			public extern PropertyObjectId CutSlopeGradingStyleId { get; }

			// Token: 0x17000C56 RID: 3158
			// (get) Token: 0x0600195D RID: 6493
			public extern PropertyString FillSlopeGrading { get; }

			// Token: 0x17000C55 RID: 3157
			// (get) Token: 0x0600195E RID: 6494
			public extern PropertyObjectId FillSlopeGradingStyleId { get; }

			// Token: 0x17000C54 RID: 3156
			// (get) Token: 0x0600195F RID: 6495
			public extern PropertyString GradingStyle { get; }

			// Token: 0x17000C53 RID: 3155
			// (get) Token: 0x06001960 RID: 6496
			public extern PropertyObjectId GradingStyleId { get; }

			// Token: 0x17000C52 RID: 3154
			// (get) Token: 0x06001961 RID: 6497
			public extern PropertyString FeatureLineStyle { get; }

			// Token: 0x17000C51 RID: 3153
			// (get) Token: 0x06001962 RID: 6498
			public extern PropertyObjectId FeatureLineStyleId { get; }
		}

		// Token: 0x02000D98 RID: 3480
		public sealed class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x17000C5A RID: 3162
			// (get) Token: 0x06001963 RID: 6499
			public extern PropertyString FeatureLine { get; }

			// Token: 0x17000C59 RID: 3161
			// (get) Token: 0x06001964 RID: 6500
			public extern PropertyString GradingGroup { get; }
		}
	}
}
