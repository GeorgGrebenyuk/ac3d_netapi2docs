using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010FA RID: 4346
	public sealed class SettingsCmdCreateSubFromPline : SettingsSubassembly
	{
		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06002368 RID: 9064
		public extern SettingsCmdCreateSubFromPline.SettingsCmdCreateFromEntities CreateFromEntities { get; }

		// Token: 0x020010FB RID: 4347
		public sealed class SettingsCmdCreateFromEntities : TreeOidWrapper
		{
			// Token: 0x1700124B RID: 4683
			// (get) Token: 0x06002369 RID: 9065
			public extern PropertyDouble MidOrdinateDistance { get; }

			// Token: 0x1700124A RID: 4682
			// (get) Token: 0x0600236A RID: 9066
			public extern PropertyEnum<LinkCreationType> LinkCreation { get; }
		}
	}
}
