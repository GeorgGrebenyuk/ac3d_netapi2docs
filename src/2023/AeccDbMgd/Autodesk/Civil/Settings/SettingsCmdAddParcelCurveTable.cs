using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D09 RID: 3337
	public sealed class SettingsCmdAddParcelCurveTable : SettingsParcel
	{
		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x060017C6 RID: 6086
		public extern SettingsCmdAddParcelCurveTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x02000D0A RID: 3338
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x17000AC3 RID: 2755
			// (get) Token: 0x060017C7 RID: 6087
			public extern PropertyString TableStyle { get; }

			// Token: 0x17000AC2 RID: 2754
			// (get) Token: 0x060017C8 RID: 6088
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x17000AC1 RID: 2753
			// (get) Token: 0x060017C9 RID: 6089
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x17000AC0 RID: 2752
			// (get) Token: 0x060017CA RID: 6090
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x17000ABF RID: 2751
			// (get) Token: 0x060017CB RID: 6091
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x17000ABE RID: 2750
			// (get) Token: 0x060017CC RID: 6092
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x17000ABD RID: 2749
			// (get) Token: 0x060017CD RID: 6093
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
