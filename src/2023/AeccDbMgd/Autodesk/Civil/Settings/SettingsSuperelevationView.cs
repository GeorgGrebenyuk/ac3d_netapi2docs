using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000B21 RID: 2849
	public class SettingsSuperelevationView : SettingsAmbient
	{
		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001552 RID: 5458
		public extern SettingsSuperelevationView.SettingsStyles Styles { get; }

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001553 RID: 5459
		public extern SettingsSuperelevationView.SettingsNameFormat NameFormat { get; }

		// Token: 0x02000B24 RID: 2852
		public class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x1700093E RID: 2366
			// (get) Token: 0x06001554 RID: 5460
			public extern PropertyObjectId SuperelevationViewStyleId { get; }

			// Token: 0x1700093D RID: 2365
			// (get) Token: 0x06001555 RID: 5461
			public extern PropertyObjectName SuperelevationViewStyle { get; }
		}

		// Token: 0x02000B25 RID: 2853
		public class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x1700093F RID: 2367
			// (get) Token: 0x06001556 RID: 5462
			public extern PropertyString SuperelevationView { get; }
		}
	}
}
