using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CCD RID: 3277
	public sealed class SettingsCmdCreateViewFrames : SettingsViewFrameGroup
	{
		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001741 RID: 5953
		public extern SettingsCmdCreateViewFrames.SettingsCmdViewFrameCreation ViewFrameCreation { get; }

		// Token: 0x02000CCE RID: 3278
		public sealed class SettingsCmdViewFrameCreation : TreeOidWrapper
		{
			// Token: 0x17000A41 RID: 2625
			// (get) Token: 0x06001742 RID: 5954
			public extern PropertyBoolean AlignmentStationRangeSpecifiedByUser { get; }

			// Token: 0x17000A40 RID: 2624
			// (get) Token: 0x06001743 RID: 5955
			public extern PropertyEnum<SheetSetType> SheetType { get; }

			// Token: 0x17000A3F RID: 2623
			// (get) Token: 0x06001744 RID: 5956
			public extern PropertyEnum<ViewFrameAngleType> ViewFrameOrientation { get; }

			// Token: 0x17000A3E RID: 2622
			// (get) Token: 0x06001745 RID: 5957
			public extern PropertyBoolean EnableFirstViewFrameOffset { get; }

			// Token: 0x17000A3D RID: 2621
			// (get) Token: 0x06001746 RID: 5958
			public extern PropertyDouble FirstViewFrameOffsetDistance { get; }

			// Token: 0x17000A3C RID: 2620
			// (get) Token: 0x06001747 RID: 5959
			public extern PropertyBoolean InsertMatchLines { get; }

			// Token: 0x17000A3B RID: 2619
			// (get) Token: 0x06001748 RID: 5960
			public extern PropertyBoolean MatchLineSnapStation { get; }

			// Token: 0x17000A3A RID: 2618
			// (get) Token: 0x06001749 RID: 5961
			public extern PropertyInt MatchLineSnapStationValue { get; }

			// Token: 0x17000A39 RID: 2617
			// (get) Token: 0x0600174A RID: 5962
			public extern PropertyBoolean MatchLineRepositioning { get; }

			// Token: 0x17000A38 RID: 2616
			// (get) Token: 0x0600174B RID: 5963
			public extern PropertyDouble MatchLineRepositioningValue { get; }
		}
	}
}
