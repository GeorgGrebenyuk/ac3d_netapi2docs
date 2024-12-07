using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010FF RID: 4351
	public sealed class SettingsCmdAddTotalVolumeTable : SettingsQuantityTakeoff
	{
		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x06002375 RID: 9077
		public extern SettingsCmdAddTotalVolumeTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x02001100 RID: 4352
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x1700125D RID: 4701
			// (get) Token: 0x06002376 RID: 9078
			public extern PropertyString TableStyle { get; }

			// Token: 0x1700125C RID: 4700
			// (get) Token: 0x06002377 RID: 9079
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x1700125B RID: 4699
			// (get) Token: 0x06002378 RID: 9080
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x1700125A RID: 4698
			// (get) Token: 0x06002379 RID: 9081
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x17001259 RID: 4697
			// (get) Token: 0x0600237A RID: 9082
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x17001258 RID: 4696
			// (get) Token: 0x0600237B RID: 9083
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x17001257 RID: 4695
			// (get) Token: 0x0600237C RID: 9084
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
