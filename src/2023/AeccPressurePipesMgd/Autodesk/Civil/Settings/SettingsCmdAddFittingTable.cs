using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020001AF RID: 431
	public sealed class SettingsCmdAddFittingTable : SettingsPressureNetwork
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060001CF RID: 463
		public extern SettingsCmdAddFittingTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x020001B0 RID: 432
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x170000EC RID: 236
			// (get) Token: 0x060001D0 RID: 464
			public extern PropertyString TableStyle { get; }

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x060001D1 RID: 465
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x060001D2 RID: 466
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x060001D3 RID: 467
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x060001D4 RID: 468
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060001D5 RID: 469
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x060001D6 RID: 470
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
