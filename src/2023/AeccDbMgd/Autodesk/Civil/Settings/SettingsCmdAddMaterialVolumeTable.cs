using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010FD RID: 4349
	public sealed class SettingsCmdAddMaterialVolumeTable : SettingsQuantityTakeoff
	{
		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x0600236D RID: 9069
		public extern SettingsCmdAddMaterialVolumeTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x020010FE RID: 4350
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x17001255 RID: 4693
			// (get) Token: 0x0600236E RID: 9070
			public extern PropertyString TableStyle { get; }

			// Token: 0x17001254 RID: 4692
			// (get) Token: 0x0600236F RID: 9071
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x17001253 RID: 4691
			// (get) Token: 0x06002370 RID: 9072
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x17001252 RID: 4690
			// (get) Token: 0x06002371 RID: 9073
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x17001251 RID: 4689
			// (get) Token: 0x06002372 RID: 9074
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x17001250 RID: 4688
			// (get) Token: 0x06002373 RID: 9075
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x1700124F RID: 4687
			// (get) Token: 0x06002374 RID: 9076
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
