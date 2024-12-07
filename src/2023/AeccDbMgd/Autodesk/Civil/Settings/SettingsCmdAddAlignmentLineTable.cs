using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D3F RID: 3391
	public sealed class SettingsCmdAddAlignmentLineTable : SettingsAlignment
	{
		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x0600185E RID: 6238
		public extern SettingsCmdAddAlignmentLineTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x02000D40 RID: 3392
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x17000B5B RID: 2907
			// (get) Token: 0x0600185F RID: 6239
			public extern PropertyString TableStyle { get; }

			// Token: 0x17000B5A RID: 2906
			// (get) Token: 0x06001860 RID: 6240
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x17000B59 RID: 2905
			// (get) Token: 0x06001861 RID: 6241
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x17000B58 RID: 2904
			// (get) Token: 0x06001862 RID: 6242
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x17000B57 RID: 2903
			// (get) Token: 0x06001863 RID: 6243
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x17000B56 RID: 2902
			// (get) Token: 0x06001864 RID: 6244
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x17000B55 RID: 2901
			// (get) Token: 0x06001865 RID: 6245
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
