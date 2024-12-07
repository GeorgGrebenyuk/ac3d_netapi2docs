using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D43 RID: 3395
	public sealed class SettingsCmdAddAlignmentSegmentTable : SettingsAlignment
	{
		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06001866 RID: 6246
		public extern SettingsCmdAddAlignmentSegmentTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x02000D44 RID: 3396
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x17000B63 RID: 2915
			// (get) Token: 0x06001867 RID: 6247
			public extern PropertyString TableStyle { get; }

			// Token: 0x17000B62 RID: 2914
			// (get) Token: 0x06001868 RID: 6248
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x17000B61 RID: 2913
			// (get) Token: 0x06001869 RID: 6249
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x17000B60 RID: 2912
			// (get) Token: 0x0600186A RID: 6250
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x17000B5F RID: 2911
			// (get) Token: 0x0600186B RID: 6251
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x17000B5E RID: 2910
			// (get) Token: 0x0600186C RID: 6252
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x17000B5D RID: 2909
			// (get) Token: 0x0600186D RID: 6253
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
