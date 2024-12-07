using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000FC9 RID: 4041
	public sealed class SettingsCmdAddNetworkPipeTable : SettingsPipeNetwork
	{
		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x0600200C RID: 8204
		public extern SettingsCmdAddNetworkPipeTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x02000FCA RID: 4042
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x17001003 RID: 4099
			// (get) Token: 0x0600200D RID: 8205
			public extern PropertyString TableStyle { get; }

			// Token: 0x17001002 RID: 4098
			// (get) Token: 0x0600200E RID: 8206
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x17001001 RID: 4097
			// (get) Token: 0x0600200F RID: 8207
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x17001000 RID: 4096
			// (get) Token: 0x06002010 RID: 8208
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x17000FFF RID: 4095
			// (get) Token: 0x06002011 RID: 8209
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x17000FFE RID: 4094
			// (get) Token: 0x06002012 RID: 8210
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x17000FFD RID: 4093
			// (get) Token: 0x06002013 RID: 8211
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
