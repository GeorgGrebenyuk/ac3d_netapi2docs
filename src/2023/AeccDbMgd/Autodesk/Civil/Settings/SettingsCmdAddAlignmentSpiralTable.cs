using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D45 RID: 3397
	public sealed class SettingsCmdAddAlignmentSpiralTable : SettingsAlignment
	{
		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x0600186E RID: 6254
		public extern SettingsCmdAddAlignmentSpiralTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x02000D46 RID: 3398
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x17000B6B RID: 2923
			// (get) Token: 0x0600186F RID: 6255
			public extern PropertyString TableStyle { get; }

			// Token: 0x17000B6A RID: 2922
			// (get) Token: 0x06001870 RID: 6256
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x17000B69 RID: 2921
			// (get) Token: 0x06001871 RID: 6257
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x17000B68 RID: 2920
			// (get) Token: 0x06001872 RID: 6258
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x17000B67 RID: 2919
			// (get) Token: 0x06001873 RID: 6259
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x17000B66 RID: 2918
			// (get) Token: 0x06001874 RID: 6260
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x17000B65 RID: 2917
			// (get) Token: 0x06001875 RID: 6261
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
