using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CCF RID: 3279
	public class SettingsBuildingSite : SettingsAmbient
	{
		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x0600174C RID: 5964
		public extern SettingsBuildingSite.SettingsStyles Styles { get; }

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x0600174D RID: 5965
		public extern SettingsBuildingSite.SettingsNameFormat NameFormat { get; }

		// Token: 0x02000D95 RID: 3477
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17000C4F RID: 3151
			// (get) Token: 0x06001958 RID: 6488
			public extern PropertyString BuildingSite { get; }

			// Token: 0x17000C4E RID: 3150
			// (get) Token: 0x06001959 RID: 6489
			public extern PropertyObjectId BuildingSiteStyleId { get; }
		}

		// Token: 0x02000D96 RID: 3478
		public sealed class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x17000C50 RID: 3152
			// (get) Token: 0x0600195A RID: 6490
			public extern PropertyString BuildingSite { get; }
		}
	}
}
