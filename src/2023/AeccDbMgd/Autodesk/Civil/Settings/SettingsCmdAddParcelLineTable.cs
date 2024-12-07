using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D0C RID: 3340
	public sealed class SettingsCmdAddParcelLineTable : SettingsParcel
	{
		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x060017CE RID: 6094
		public extern SettingsCmdAddParcelLineTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x02000D0D RID: 3341
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x17000ACB RID: 2763
			// (get) Token: 0x060017CF RID: 6095
			public extern PropertyString TableStyle { get; }

			// Token: 0x17000ACA RID: 2762
			// (get) Token: 0x060017D0 RID: 6096
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x17000AC9 RID: 2761
			// (get) Token: 0x060017D1 RID: 6097
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x17000AC8 RID: 2760
			// (get) Token: 0x060017D2 RID: 6098
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x17000AC7 RID: 2759
			// (get) Token: 0x060017D3 RID: 6099
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x17000AC6 RID: 2758
			// (get) Token: 0x060017D4 RID: 6100
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x17000AC5 RID: 2757
			// (get) Token: 0x060017D5 RID: 6101
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
