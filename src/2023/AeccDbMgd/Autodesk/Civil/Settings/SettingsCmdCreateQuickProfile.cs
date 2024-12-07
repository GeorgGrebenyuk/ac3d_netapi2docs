using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D62 RID: 3426
	public sealed class SettingsCmdCreateQuickProfile : SettingsProfile
	{
		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x060018AC RID: 6316
		public extern SettingsCmdCreateQuickProfile.SettingsCmdQuickProfile QuickProfile { get; }

		// Token: 0x02000D63 RID: 3427
		public sealed class SettingsCmdQuickProfile : TreeOidWrapper
		{
			// Token: 0x17000BA4 RID: 2980
			// (get) Token: 0x060018AD RID: 6317
			public extern PropertyBoolean SelectAllSurfaces { get; }

			// Token: 0x17000BA3 RID: 2979
			// (get) Token: 0x060018AE RID: 6318
			public extern PropertyBoolean Draw3DEntityProfile { get; }
		}
	}
}
