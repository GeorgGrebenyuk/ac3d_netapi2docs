using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CD4 RID: 3284
	public sealed class SettingsCmdConvertPointstoSdskPoints : SettingsPoint
	{
		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001759 RID: 5977
		public extern SettingsCmdConvertPointstoSdskPoints.SettingsCmdLayer Layer { get; }

		// Token: 0x02000CD5 RID: 3285
		public sealed class SettingsCmdLayer : TreeOidWrapper
		{
			// Token: 0x17000A50 RID: 2640
			// (get) Token: 0x0600175A RID: 5978
			public extern PropertyLayer Layer { get; }
		}
	}
}
