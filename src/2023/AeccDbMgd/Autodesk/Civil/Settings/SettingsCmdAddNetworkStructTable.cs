using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000FCE RID: 4046
	public sealed class SettingsCmdAddNetworkStructTable : SettingsPipeNetwork
	{
		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06002014 RID: 8212
		public extern SettingsCmdAddNetworkStructTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x02000FCF RID: 4047
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x1700100B RID: 4107
			// (get) Token: 0x06002015 RID: 8213
			public extern PropertyString TableStyle { get; }

			// Token: 0x1700100A RID: 4106
			// (get) Token: 0x06002016 RID: 8214
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x17001009 RID: 4105
			// (get) Token: 0x06002017 RID: 8215
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x17001008 RID: 4104
			// (get) Token: 0x06002018 RID: 8216
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x17001007 RID: 4103
			// (get) Token: 0x06002019 RID: 8217
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x17001006 RID: 4102
			// (get) Token: 0x0600201A RID: 8218
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x17001005 RID: 4101
			// (get) Token: 0x0600201B RID: 8219
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
