using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D7F RID: 3455
	public sealed class SettingsCmdCreateSectionView : SettingsSectionView
	{
		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060018ED RID: 6381
		public extern SettingsCmdCreateSectionView.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x02000D80 RID: 3456
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x17000BF1 RID: 3057
			// (get) Token: 0x060018EE RID: 6382
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x17000BF0 RID: 3056
			// (get) Token: 0x060018EF RID: 6383
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x17000BEF RID: 3055
			// (get) Token: 0x060018F0 RID: 6384
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x17000BEE RID: 3054
			// (get) Token: 0x060018F1 RID: 6385
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x17000BED RID: 3053
			// (get) Token: 0x060018F2 RID: 6386
			public extern PropertyString TotalVolumeTableStyle { get; }

			// Token: 0x17000BEC RID: 3052
			// (get) Token: 0x060018F3 RID: 6387
			public extern PropertyObjectId TotalVolumeTableStyleId { get; }

			// Token: 0x17000BEB RID: 3051
			// (get) Token: 0x060018F4 RID: 6388
			public extern PropertyString MaterialVolumeTableStyle { get; }

			// Token: 0x17000BEA RID: 3050
			// (get) Token: 0x060018F5 RID: 6389
			public extern PropertyObjectId MaterialVolumeTableStyleId { get; }

			// Token: 0x17000BE9 RID: 3049
			// (get) Token: 0x060018F6 RID: 6390
			public extern PropertyDouble XOffset { get; }

			// Token: 0x17000BE8 RID: 3048
			// (get) Token: 0x060018F7 RID: 6391
			public extern PropertyDouble YOffset { get; }

			// Token: 0x17000BE7 RID: 3047
			// (get) Token: 0x060018F8 RID: 6392
			public extern PropertyEnum<TileDirectionType> TileDirection { get; }

			// Token: 0x17000BE6 RID: 3046
			// (get) Token: 0x060018F9 RID: 6393
			public extern PropertyEnum<SectionViewAnchorType> SectionViewAnchor { get; }

			// Token: 0x17000BE5 RID: 3045
			// (get) Token: 0x060018FA RID: 6394
			public extern PropertyEnum<TableAnchorType> TableAnchor { get; }

			// Token: 0x17000BE4 RID: 3044
			// (get) Token: 0x060018FB RID: 6395
			public extern PropertyEnum<TableLayoutType> TableLayout { get; }
		}
	}
}
