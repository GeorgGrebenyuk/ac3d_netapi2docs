using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CD2 RID: 3282
	public sealed class SettingsCmdAddPointTable : SettingsPoint
	{
		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001751 RID: 5969
		public extern SettingsCmdAddPointTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x02000CD3 RID: 3283
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x17000A4E RID: 2638
			// (get) Token: 0x06001752 RID: 5970
			public extern PropertyString TableStyle { get; }

			// Token: 0x17000A4D RID: 2637
			// (get) Token: 0x06001753 RID: 5971
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x17000A4C RID: 2636
			// (get) Token: 0x06001754 RID: 5972
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x17000A4B RID: 2635
			// (get) Token: 0x06001755 RID: 5973
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x17000A4A RID: 2634
			// (get) Token: 0x06001756 RID: 5974
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x17000A49 RID: 2633
			// (get) Token: 0x06001757 RID: 5975
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x17000A48 RID: 2632
			// (get) Token: 0x06001758 RID: 5976
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
