using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D10 RID: 3344
	public sealed class SettingsCmdAddParcelSegmentTable : SettingsParcel
	{
		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x060017D8 RID: 6104
		public extern SettingsCmdAddParcelSegmentTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x02000D11 RID: 3345
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x17000AD5 RID: 2773
			// (get) Token: 0x060017D9 RID: 6105
			public extern PropertyString TableStyle { get; }

			// Token: 0x17000AD4 RID: 2772
			// (get) Token: 0x060017DA RID: 6106
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x17000AD3 RID: 2771
			// (get) Token: 0x060017DB RID: 6107
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x17000AD2 RID: 2770
			// (get) Token: 0x060017DC RID: 6108
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x17000AD1 RID: 2769
			// (get) Token: 0x060017DD RID: 6109
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x17000AD0 RID: 2768
			// (get) Token: 0x060017DE RID: 6110
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x17000ACF RID: 2767
			// (get) Token: 0x060017DF RID: 6111
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
