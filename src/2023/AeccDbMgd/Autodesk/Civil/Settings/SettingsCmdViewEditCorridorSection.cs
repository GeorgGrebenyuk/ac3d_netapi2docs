using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010E4 RID: 4324
	public sealed class SettingsCmdViewEditCorridorSection : SettingsCorridor
	{
		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x06002303 RID: 8963
		public extern SettingsCmdViewEditCorridorSection.SettingsCmdViewEditOptions ViewEditOptions { get; }

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x06002304 RID: 8964
		public extern SettingsCmdViewEditCorridorSection.SettingsCmdGridSettings GridSettings { get; }

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x06002305 RID: 8965
		public extern SettingsCmdViewEditCorridorSection.SettingsCmdGridTextSettings GridTextSettings { get; }

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06002306 RID: 8966
		public extern SettingsCmdViewEditCorridorSection.SettingsCmdSectionSliderInMultipleViewports SectionSliderInMultipleViewports { get; }

		// Token: 0x020010E5 RID: 4325
		public sealed class SettingsCmdViewEditOptions : TreeOidWrapper
		{
			// Token: 0x170011EF RID: 4591
			// (get) Token: 0x06002307 RID: 8967
			public extern PropertyDouble DefaultViewScale { get; }

			// Token: 0x170011EE RID: 4590
			// (get) Token: 0x06002308 RID: 8968
			public extern PropertyBoolean TurnOffUnassociatedLayers { get; }

			// Token: 0x170011ED RID: 4589
			// (get) Token: 0x06002309 RID: 8969
			public extern PropertyBoolean RebuildOnEdit { get; }

			// Token: 0x170011EC RID: 4588
			// (get) Token: 0x0600230A RID: 8970
			public extern PropertyDouble FrontClip { get; }

			// Token: 0x170011EB RID: 4587
			// (get) Token: 0x0600230B RID: 8971
			public extern PropertyDouble BackClip { get; }

			// Token: 0x170011EA RID: 4586
			// (get) Token: 0x0600230C RID: 8972
			[DeprecatedVersion(CivilVersion.Civil2012)]
			[Obsolete("Removed in IPANEMA.", false)]
			public extern PropertyBoolean StationTrackerInMultipleViewports { get; }

			// Token: 0x170011E9 RID: 4585
			// (get) Token: 0x0600230D RID: 8973
			public extern PropertyDouble UndefinedSectionWidth { get; }

			// Token: 0x170011E8 RID: 4584
			// (get) Token: 0x0600230E RID: 8974
			public extern PropertyBoolean ApplyViewportConfiguration { get; }
		}

		// Token: 0x020010E6 RID: 4326
		public sealed class SettingsCmdGridSettings : TreeOidWrapper
		{
			// Token: 0x170011F6 RID: 4598
			// (get) Token: 0x0600230F RID: 8975
			public extern PropertyBoolean DisplayHorizontalGrid { get; }

			// Token: 0x170011F5 RID: 4597
			// (get) Token: 0x06002310 RID: 8976
			public extern PropertyBoolean DisplayVerticalGrid { get; }

			// Token: 0x170011F4 RID: 4596
			// (get) Token: 0x06002311 RID: 8977
			public extern PropertyDouble HorizontalGridInterval { get; }

			// Token: 0x170011F3 RID: 4595
			// (get) Token: 0x06002312 RID: 8978
			public extern PropertyDouble VerticalGridInterval { get; }

			// Token: 0x170011F2 RID: 4594
			// (get) Token: 0x06002313 RID: 8979
			public extern PropertyColor GridColor { get; }

			// Token: 0x170011F1 RID: 4593
			// (get) Token: 0x06002314 RID: 8980
			public extern PropertyBoolean DisplayCenterAxis { get; }

			// Token: 0x170011F0 RID: 4592
			// (get) Token: 0x06002315 RID: 8981
			public extern PropertyColor CenterAxisColor { get; }
		}

		// Token: 0x020010E7 RID: 4327
		public sealed class SettingsCmdGridTextSettings : TreeOidWrapper
		{
			// Token: 0x170011FA RID: 4602
			// (get) Token: 0x06002316 RID: 8982
			public extern PropertyString TextStyle { get; }

			// Token: 0x170011F9 RID: 4601
			// (get) Token: 0x06002317 RID: 8983
			public extern PropertyColor TextColor { get; }

			// Token: 0x170011F8 RID: 4600
			// (get) Token: 0x06002318 RID: 8984
			public extern PropertyDouble TextHeightRelativeToScreen { get; }

			// Token: 0x170011F7 RID: 4599
			// (get) Token: 0x06002319 RID: 8985
			public extern PropertyBoolean AnnotateCenterAxis { get; }
		}

		// Token: 0x020010E8 RID: 4328
		public sealed class SettingsCmdSectionSliderInMultipleViewports : TreeOidWrapper
		{
			// Token: 0x170011FD RID: 4605
			// (get) Token: 0x0600231A RID: 8986
			public extern PropertyBoolean NeedSlider { get; }

			// Token: 0x170011FC RID: 4604
			// (get) Token: 0x0600231B RID: 8987
			public extern PropertyColor AlignmentSliderColor { get; }

			// Token: 0x170011FB RID: 4603
			// (get) Token: 0x0600231C RID: 8988
			public extern PropertyColor ProfileViewSliderColor { get; }
		}
	}
}
