using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D7D RID: 3453
	public sealed class SettingsCmdCreateSectionSheets : SettingsSectionView
	{
		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x060018EB RID: 6379
		public extern SettingsCmdCreateSectionSheets.SettingsCmdSheetCreation SheetCreation { get; }

		// Token: 0x02000D7E RID: 3454
		public sealed class SettingsCmdSheetCreation : TreeOidWrapper
		{
			// Token: 0x17000BE2 RID: 3042
			// (get) Token: 0x060018EC RID: 6380
			public extern PropertyBoolean SheetSetUse { get; }
		}
	}
}
