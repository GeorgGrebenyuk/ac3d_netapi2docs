using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020001B1 RID: 433
	public sealed class SettingsCmdAddPressurePipeTable : SettingsPressureNetwork
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060001D7 RID: 471
		public extern SettingsCmdAddPressurePipeTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x020001B2 RID: 434
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x060001D8 RID: 472
			public extern PropertyString TableStyle { get; }

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x060001D9 RID: 473
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x060001DA RID: 474
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x060001DB RID: 475
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x060001DC RID: 476
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x060001DD RID: 477
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x060001DE RID: 478
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
