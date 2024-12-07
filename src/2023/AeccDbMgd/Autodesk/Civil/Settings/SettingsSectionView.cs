using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D73 RID: 3443
	public class SettingsSectionView : SettingsAmbient
	{
		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x060018D4 RID: 6356
		public extern SettingsSectionView.SettingsStyles Styles { get; }

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x060018D5 RID: 6357
		public extern SettingsSectionView.SettingsNameFormat NameFormat { get; }

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x060018D6 RID: 6358
		public extern SettingsSectionView.SettingsSectionViewCreation SectionViewCreation { get; }

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x060018D7 RID: 6359
		public extern SettingsSectionView.SettingsProjectionLabelPlacement ProjectionLabelPlacement { get; }

		// Token: 0x02000DAE RID: 3502
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17000CDF RID: 3295
			// (get) Token: 0x060019D8 RID: 6616
			public extern PropertyString SectionView { get; }

			// Token: 0x17000CDE RID: 3294
			// (get) Token: 0x060019D9 RID: 6617
			public extern PropertyObjectId SectionViewStyleId { get; }

			// Token: 0x17000CDD RID: 3293
			// (get) Token: 0x060019DA RID: 6618
			public extern PropertyString Marker { get; }

			// Token: 0x17000CDC RID: 3292
			// (get) Token: 0x060019DB RID: 6619
			public extern PropertyObjectId MarkerStyleId { get; }

			// Token: 0x17000CDB RID: 3291
			// (get) Token: 0x060019DC RID: 6620
			public extern PropertyString SectionViewOffsetElevationLabel { get; }

			// Token: 0x17000CDA RID: 3290
			// (get) Token: 0x060019DD RID: 6621
			public extern PropertyObjectId SectionViewOffsetElevationLabelStyleId { get; }

			// Token: 0x17000CD9 RID: 3289
			// (get) Token: 0x060019DE RID: 6622
			public extern PropertyString SectionViewDepthGradeLabel { get; }

			// Token: 0x17000CD8 RID: 3288
			// (get) Token: 0x060019DF RID: 6623
			public extern PropertyObjectId SectionViewDepthGradeLabelStyleId { get; }

			// Token: 0x17000CD7 RID: 3287
			// (get) Token: 0x060019E0 RID: 6624
			public extern PropertyString Projection { get; }

			// Token: 0x17000CD6 RID: 3286
			// (get) Token: 0x060019E1 RID: 6625
			public extern PropertyObjectId ProjectionStyleId { get; }

			// Token: 0x17000CD5 RID: 3285
			// (get) Token: 0x060019E2 RID: 6626
			public extern PropertyString SectionViewBandSet { get; }

			// Token: 0x17000CD4 RID: 3284
			// (get) Token: 0x060019E3 RID: 6627
			public extern PropertyObjectId SectionViewBandSetId { get; }

			// Token: 0x17000CD3 RID: 3283
			// (get) Token: 0x060019E4 RID: 6628
			public extern PropertyString SectionLabelSet { get; }

			// Token: 0x17000CD2 RID: 3282
			// (get) Token: 0x060019E5 RID: 6629
			public extern PropertyObjectId SectionLabelSetId { get; }

			// Token: 0x17000CD1 RID: 3281
			// (get) Token: 0x060019E6 RID: 6630
			public extern PropertyString GroupPlot { get; }

			// Token: 0x17000CD0 RID: 3280
			// (get) Token: 0x060019E7 RID: 6631
			public extern PropertyObjectId GroupPlotStyleId { get; }

			// Token: 0x17000CCF RID: 3279
			// (get) Token: 0x060019E8 RID: 6632
			public extern PropertyString SectionProjectionLabel { get; }

			// Token: 0x17000CCE RID: 3278
			// (get) Token: 0x060019E9 RID: 6633
			public extern PropertyObjectId SectionProjectionLabelStyleId { get; }
		}

		// Token: 0x02000DAF RID: 3503
		public sealed class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x17000CE1 RID: 3297
			// (get) Token: 0x060019EA RID: 6634
			public extern PropertyString SectionView { get; }

			// Token: 0x17000CE0 RID: 3296
			// (get) Token: 0x060019EB RID: 6635
			public extern PropertyString CrossSectionSheetLayout { get; }
		}

		// Token: 0x02000DB0 RID: 3504
		public sealed class SettingsSectionViewCreation : TreeOidWrapper
		{
			// Token: 0x17000CE4 RID: 3300
			// (get) Token: 0x060019EC RID: 6636
			public extern PropertyBoolean SpecifySectionViewOffsetRange { get; }

			// Token: 0x17000CE3 RID: 3299
			// (get) Token: 0x060019ED RID: 6637
			public extern PropertyBoolean SpecifySectionViewHeight { get; }

			// Token: 0x17000CE2 RID: 3298
			// (get) Token: 0x060019EE RID: 6638
			public extern PropertyEnum<SectionViewElevationRangeType> SectionGroupElevationRange { get; }
		}

		// Token: 0x02000DB1 RID: 3505
		public sealed class SettingsProjectionLabelPlacement : TreeOidWrapper
		{
			// Token: 0x17000CE7 RID: 3303
			// (get) Token: 0x060019EF RID: 6639
			public extern PropertyEnum<DimensionAnchorType> DimensionAnchorOption { get; }

			// Token: 0x17000CE6 RID: 3302
			// (get) Token: 0x060019F0 RID: 6640
			public extern PropertyDouble DimensionAnchorElevationValueForProjections { get; }

			// Token: 0x17000CE5 RID: 3301
			// (get) Token: 0x060019F1 RID: 6641
			public extern PropertyDouble DimensionAnchorPlotHeightValueForProjections { get; }
		}
	}
}
