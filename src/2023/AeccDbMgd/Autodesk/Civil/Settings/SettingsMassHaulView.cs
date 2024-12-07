using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D86 RID: 3462
	public class SettingsMassHaulView : SettingsAmbient
	{
		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06001902 RID: 6402
		public extern SettingsMassHaulView.SettingsStyles Styles { get; }

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06001903 RID: 6403
		public extern SettingsMassHaulView.SettingsNameFormat NameFormat { get; }

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06001904 RID: 6404
		public extern SettingsMassHaulView.SettingsMassHaulCreation MassHaulCreation { get; }

		// Token: 0x02000D99 RID: 3481
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17000C5E RID: 3166
			// (get) Token: 0x06001965 RID: 6501
			public extern PropertyString MassHaulLine { get; }

			// Token: 0x17000C5D RID: 3165
			// (get) Token: 0x06001966 RID: 6502
			public extern PropertyObjectId MassHaulLineStyleId { get; }

			// Token: 0x17000C5C RID: 3164
			// (get) Token: 0x06001967 RID: 6503
			public extern PropertyString MassHaulView { get; }

			// Token: 0x17000C5B RID: 3163
			// (get) Token: 0x06001968 RID: 6504
			public extern PropertyObjectId MassHaulViewStyleId { get; }
		}

		// Token: 0x02000D9A RID: 3482
		public sealed class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x17000C60 RID: 3168
			// (get) Token: 0x06001969 RID: 6505
			public extern PropertyString MassHaulLine { get; }

			// Token: 0x17000C5F RID: 3167
			// (get) Token: 0x0600196A RID: 6506
			public extern PropertyString MassHaulView { get; }
		}

		// Token: 0x02000D9B RID: 3483
		public sealed class SettingsMassHaulCreation : TreeOidWrapper
		{
			// Token: 0x17000C62 RID: 3170
			// (get) Token: 0x0600196B RID: 6507
			public extern PropertyDouble BorrowPitCapacity { get; }

			// Token: 0x17000C61 RID: 3169
			// (get) Token: 0x0600196C RID: 6508
			public extern PropertyDouble DumpSiteCapacity { get; }
		}
	}
}
