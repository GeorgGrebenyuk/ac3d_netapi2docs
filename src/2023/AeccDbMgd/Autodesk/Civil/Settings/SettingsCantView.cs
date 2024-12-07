using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000AFE RID: 2814
	public class SettingsCantView : SettingsAmbient
	{
		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001503 RID: 5379
		public extern SettingsCantView.SettingsStyles Styles { get; }

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001504 RID: 5380
		public extern SettingsCantView.SettingsNameFormat NameFormat { get; }

		// Token: 0x02000AFF RID: 2815
		public class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x170008EF RID: 2287
			// (get) Token: 0x06001505 RID: 5381
			public extern PropertyString CantViewStyle { get; }

			// Token: 0x170008EE RID: 2286
			// (get) Token: 0x06001506 RID: 5382
			public extern PropertyObjectId CantViewStyleId { get; }
		}

		// Token: 0x02000B00 RID: 2816
		public class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x170008F0 RID: 2288
			// (get) Token: 0x06001507 RID: 5383
			public extern PropertyString CantView { get; }
		}
	}
}
