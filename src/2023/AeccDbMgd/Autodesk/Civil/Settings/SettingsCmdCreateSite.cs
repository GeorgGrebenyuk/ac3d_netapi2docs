using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D1F RID: 3359
	public sealed class SettingsCmdCreateSite : SettingsParcel
	{
		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x0600180A RID: 6154
		public extern SettingsCmdCreateSite.SettingsCmdParcel Parcel { get; }

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x0600180B RID: 6155
		public extern SettingsCmdCreateSite.SettingsCmdAlignment Alignment { get; }

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x0600180C RID: 6156
		public extern SettingsCmdCreateSite.SettingsCmdFeatureLine FeatureLine { get; }

		// Token: 0x02000D20 RID: 3360
		public sealed class SettingsCmdParcel : TreeOidWrapper
		{
			// Token: 0x17000B08 RID: 2824
			// (get) Token: 0x0600180D RID: 6157
			public extern PropertyInt ParcelNextAutomaticAreaCounter { get; }

			// Token: 0x17000B07 RID: 2823
			// (get) Token: 0x0600180E RID: 6158
			public extern PropertyInt ParcelNextManualAreaCounter { get; }

			// Token: 0x17000B06 RID: 2822
			// (get) Token: 0x0600180F RID: 6159
			public extern PropertyInt ParcelLineNextAutomaticTagCounter { get; }

			// Token: 0x17000B05 RID: 2821
			// (get) Token: 0x06001810 RID: 6160
			public extern PropertyInt ParcelLineNextManualTagCounter { get; }

			// Token: 0x17000B04 RID: 2820
			// (get) Token: 0x06001811 RID: 6161
			public extern PropertyInt ParcelCurveNextAutomaticTagCounter { get; }

			// Token: 0x17000B03 RID: 2819
			// (get) Token: 0x06001812 RID: 6162
			public extern PropertyInt ParcelCurveNextManualTagCounter { get; }
		}

		// Token: 0x02000D21 RID: 3361
		public sealed class SettingsCmdAlignment : TreeOidWrapper
		{
			// Token: 0x17000B0E RID: 2830
			// (get) Token: 0x06001813 RID: 6163
			public extern PropertyInt AlignmentSpiralNextManualTagCounter { get; }

			// Token: 0x17000B0D RID: 2829
			// (get) Token: 0x06001814 RID: 6164
			public extern PropertyInt AlignmentSpiralNextAutomaticTagCounter { get; }

			// Token: 0x17000B0C RID: 2828
			// (get) Token: 0x06001815 RID: 6165
			public extern PropertyInt AlignmentCurveNextManualTagCounter { get; }

			// Token: 0x17000B0B RID: 2827
			// (get) Token: 0x06001816 RID: 6166
			public extern PropertyInt AlignmentCurveNextAutomaticTagCounter { get; }

			// Token: 0x17000B0A RID: 2826
			// (get) Token: 0x06001817 RID: 6167
			public extern PropertyInt AlignmentLineNextManualTagCounter { get; }

			// Token: 0x17000B09 RID: 2825
			// (get) Token: 0x06001818 RID: 6168
			public extern PropertyInt AlignmentLineNextAutomaticTagCounter { get; }
		}

		// Token: 0x02000D22 RID: 3362
		public sealed class SettingsCmdFeatureLine : TreeOidWrapper
		{
			// Token: 0x17000B0F RID: 2831
			// (get) Token: 0x06001819 RID: 6169
			public extern PropertyFeatureLineStylePriority FeatureLineStyle { get; }
		}
	}
}
