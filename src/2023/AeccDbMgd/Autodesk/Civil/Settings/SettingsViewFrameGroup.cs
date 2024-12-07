using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CCA RID: 3274
	public class SettingsViewFrameGroup : SettingsAmbient
	{
		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001734 RID: 5940
		public extern SettingsViewFrameGroup.SettingsStyles Styles { get; }

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001735 RID: 5941
		public extern SettingsViewFrameGroup.SettingsNameFormat NameFormat { get; }

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001736 RID: 5942
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Property has been removed.", false)]
		public extern SettingsViewFrameGroup.SettingsInformation Information { get; }

		// Token: 0x02000DB5 RID: 3509
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17000D0A RID: 3338
			// (get) Token: 0x06001A04 RID: 6660
			public extern PropertyString MatchLine { get; }

			// Token: 0x17000D09 RID: 3337
			// (get) Token: 0x06001A05 RID: 6661
			public extern PropertyObjectId MatchLineStyleId { get; }

			// Token: 0x17000D08 RID: 3336
			// (get) Token: 0x06001A06 RID: 6662
			public extern PropertyString ViewFrame { get; }

			// Token: 0x17000D07 RID: 3335
			// (get) Token: 0x06001A07 RID: 6663
			public extern PropertyObjectId ViewFrameStyleId { get; }

			// Token: 0x17000D06 RID: 3334
			// (get) Token: 0x06001A08 RID: 6664
			public extern PropertyString ViewFrameLabel { get; }

			// Token: 0x17000D05 RID: 3333
			// (get) Token: 0x06001A09 RID: 6665
			public extern PropertyObjectId ViewFrameLabelStyleId { get; }

			// Token: 0x17000D04 RID: 3332
			// (get) Token: 0x06001A0A RID: 6666
			public extern PropertyString MatchLineLabelLeft { get; }

			// Token: 0x17000D03 RID: 3331
			// (get) Token: 0x06001A0B RID: 6667
			public extern PropertyObjectId MatchLineLabelStyleIdLeft { get; }

			// Token: 0x17000D02 RID: 3330
			// (get) Token: 0x06001A0C RID: 6668
			public extern PropertyEnum<ViewFrameLabelLocationType> ViewFrameLabelLocation { get; }

			// Token: 0x17000D01 RID: 3329
			// (get) Token: 0x06001A0D RID: 6669
			public extern PropertyString MatchLineLabelRight { get; }

			// Token: 0x17000D00 RID: 3328
			// (get) Token: 0x06001A0E RID: 6670
			public extern PropertyObjectId MatchLineLabelStyleIdRight { get; }

			// Token: 0x17000CFF RID: 3327
			// (get) Token: 0x06001A0F RID: 6671
			public extern PropertyString ProfileView { get; }

			// Token: 0x17000CFE RID: 3326
			// (get) Token: 0x06001A10 RID: 6672
			public extern PropertyObjectId ProfileViewStyleId { get; }

			// Token: 0x17000CFD RID: 3325
			// (get) Token: 0x06001A11 RID: 6673
			public extern PropertyString ProfileViewBandSet { get; }

			// Token: 0x17000CFC RID: 3324
			// (get) Token: 0x06001A12 RID: 6674
			public extern PropertyObjectId ProfileViewBandSetId { get; }

			// Token: 0x17000CFB RID: 3323
			// (get) Token: 0x06001A13 RID: 6675
			public extern PropertyEnum<MatchLineLabelLocationType> MatchLineLeftLabelLocation { get; }

			// Token: 0x17000CFA RID: 3322
			// (get) Token: 0x06001A14 RID: 6676
			public extern PropertyEnum<MatchLineLabelLocationType> MatchLineRightLabelLocation { get; }
		}

		// Token: 0x02000DB6 RID: 3510
		public sealed class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x17000D0F RID: 3343
			// (get) Token: 0x06001A15 RID: 6677
			public extern PropertyString ViewFrameGroup { get; }

			// Token: 0x17000D0E RID: 3342
			// (get) Token: 0x06001A16 RID: 6678
			public extern PropertyString ViewFrame { get; }

			// Token: 0x17000D0D RID: 3341
			// (get) Token: 0x06001A17 RID: 6679
			public extern PropertyString MatchLine { get; }

			// Token: 0x17000D0C RID: 3340
			// (get) Token: 0x06001A18 RID: 6680
			public extern PropertyString Layout { get; }

			// Token: 0x17000D0B RID: 3339
			// (get) Token: 0x06001A19 RID: 6681
			public extern PropertyString SheetFile { get; }
		}

		// Token: 0x02000DB7 RID: 3511
		public sealed class SettingsInformation : TreeOidWrapper
		{
		}
	}
}
