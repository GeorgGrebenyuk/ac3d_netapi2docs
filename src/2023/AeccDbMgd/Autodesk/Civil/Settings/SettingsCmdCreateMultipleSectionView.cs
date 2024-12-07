using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D76 RID: 3446
	public sealed class SettingsCmdCreateMultipleSectionView : SettingsSectionView
	{
		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x060018D8 RID: 6360
		public extern SettingsCmdCreateMultipleSectionView.SettingsCmdTableCreation TableCreation { get; }

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x060018D9 RID: 6361
		public extern SettingsCmdCreateMultipleSectionView.SettingsCmdMultipleSectionViewCreation MultipleSectionViewCreation { get; }

		// Token: 0x02000D77 RID: 3447
		public sealed class SettingsCmdTableCreation : TreeOidWrapper
		{
			// Token: 0x17000BDD RID: 3037
			// (get) Token: 0x060018DA RID: 6362
			public extern PropertyBoolean SplitTable { get; }

			// Token: 0x17000BDC RID: 3036
			// (get) Token: 0x060018DB RID: 6363
			public extern PropertyInt MaximumNumberOfRows { get; }

			// Token: 0x17000BDB RID: 3035
			// (get) Token: 0x060018DC RID: 6364
			public extern PropertyInt MaximumTablesPerStack { get; }

			// Token: 0x17000BDA RID: 3034
			// (get) Token: 0x060018DD RID: 6365
			public extern PropertyDouble TableSpacing { get; }

			// Token: 0x17000BD9 RID: 3033
			// (get) Token: 0x060018DE RID: 6366
			public extern PropertyString TotalVolumeTableStyle { get; }

			// Token: 0x17000BD8 RID: 3032
			// (get) Token: 0x060018DF RID: 6367
			public extern PropertyObjectId TotalVolumeTableStyleId { get; }

			// Token: 0x17000BD7 RID: 3031
			// (get) Token: 0x060018E0 RID: 6368
			public extern PropertyString MaterialVolumeTableStyle { get; }

			// Token: 0x17000BD6 RID: 3030
			// (get) Token: 0x060018E1 RID: 6369
			public extern PropertyObjectId MaterialVolumeTableStyleId { get; }

			// Token: 0x17000BD5 RID: 3029
			// (get) Token: 0x060018E2 RID: 6370
			public extern PropertyDouble XOffset { get; }

			// Token: 0x17000BD4 RID: 3028
			// (get) Token: 0x060018E3 RID: 6371
			public extern PropertyDouble YOffset { get; }

			// Token: 0x17000BD3 RID: 3027
			// (get) Token: 0x060018E4 RID: 6372
			public extern PropertyEnum<TileDirectionType> TileDirection { get; }

			// Token: 0x17000BD2 RID: 3026
			// (get) Token: 0x060018E5 RID: 6373
			public extern PropertyEnum<SectionViewAnchorType> SectionViewAnchor { get; }

			// Token: 0x17000BD1 RID: 3025
			// (get) Token: 0x060018E6 RID: 6374
			public extern PropertyEnum<TableAnchorType> TableAnchor { get; }

			// Token: 0x17000BD0 RID: 3024
			// (get) Token: 0x060018E7 RID: 6375
			public extern PropertyEnum<TableLayoutType> TableLayout { get; }
		}

		// Token: 0x02000D78 RID: 3448
		public sealed class SettingsCmdMultipleSectionViewCreation : TreeOidWrapper
		{
			// Token: 0x17000BE0 RID: 3040
			// (get) Token: 0x060018E8 RID: 6376
			public extern PropertyBoolean SpecifyMultipleSectionViewStationRange { get; }

			// Token: 0x17000BDF RID: 3039
			// (get) Token: 0x060018E9 RID: 6377
			public extern PropertyDouble SectionViewHeight { get; }

			// Token: 0x17000BDE RID: 3038
			// (get) Token: 0x060018EA RID: 6378
			public extern PropertyEnum<PlacementOptionType> PlacementOption { get; }
		}
	}
}
