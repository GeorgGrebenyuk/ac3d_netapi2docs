using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020001AD RID: 429
	public sealed class SettingsCmdAddAppurtTable : SettingsPressureNetwork
	{
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001C7 RID: 455
		public extern SettingsCmdAddAppurtTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x020001AE RID: 430
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x060001C8 RID: 456
			public extern PropertyString TableStyle { get; }

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060001C9 RID: 457
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060001CA RID: 458
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060001CB RID: 459
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060001CC RID: 460
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x060001CD RID: 461
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x060001CE RID: 462
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
