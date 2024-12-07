using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D12 RID: 3346
	public sealed class SettingsCmdAddParcelTable : SettingsParcel
	{
		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x060017E0 RID: 6112
		public extern SettingsCmdAddParcelTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x02000D13 RID: 3347
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x17000ADD RID: 2781
			// (get) Token: 0x060017E1 RID: 6113
			public extern PropertyString TableStyle { get; }

			// Token: 0x17000ADC RID: 2780
			// (get) Token: 0x060017E2 RID: 6114
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x17000ADB RID: 2779
			// (get) Token: 0x060017E3 RID: 6115
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x17000ADA RID: 2778
			// (get) Token: 0x060017E4 RID: 6116
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x17000AD9 RID: 2777
			// (get) Token: 0x060017E5 RID: 6117
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x17000AD8 RID: 2776
			// (get) Token: 0x060017E6 RID: 6118
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x17000AD7 RID: 2775
			// (get) Token: 0x060017E7 RID: 6119
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
