using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D3D RID: 3389
	public sealed class SettingsCmdAddAlignmentCurveTable : SettingsAlignment
	{
		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06001856 RID: 6230
		public extern SettingsCmdAddAlignmentCurveTable.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x02000D3E RID: 3390
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x17000B53 RID: 2899
			// (get) Token: 0x06001857 RID: 6231
			public extern PropertyString TableStyle { get; }

			// Token: 0x17000B52 RID: 2898
			// (get) Token: 0x06001858 RID: 6232
			public extern PropertyObjectId TableStyleId { get; }

			// Token: 0x17000B51 RID: 2897
			// (get) Token: 0x06001859 RID: 6233
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x17000B50 RID: 2896
			// (get) Token: 0x0600185A RID: 6234
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x17000B4F RID: 2895
			// (get) Token: 0x0600185B RID: 6235
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x17000B4E RID: 2894
			// (get) Token: 0x0600185C RID: 6236
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x17000B4D RID: 2893
			// (get) Token: 0x0600185D RID: 6237
			public extern PropertyEnum<TableTitleDirectionType> TileDirection { get; }
		}
	}
}
