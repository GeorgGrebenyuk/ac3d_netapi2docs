using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D66 RID: 3430
	public class SettingsProfileView : SettingsAmbient
	{
		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x060018B2 RID: 6322
		public extern SettingsProfileView.SettingsStyles Styles { get; }

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x060018B3 RID: 6323
		public extern SettingsProfileView.SettingsNameFormat NameFormat { get; }

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x060018B4 RID: 6324
		public extern SettingsProfileView.SettingsCreation Creation { get; }

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x060018B5 RID: 6325
		public extern SettingsProfileView.SettingsSplitOptions SplitOptions { get; }

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x060018B6 RID: 6326
		public extern SettingsProfileView.SettingsStackedOptions StackedOptions { get; }

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x060018B7 RID: 6327
		public extern SettingsProfileView.SettingsProjectionLabelPlacement ProjectionLabelPlacement { get; }

		// Token: 0x02000DA6 RID: 3494
		public class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17000CB7 RID: 3255
			// (get) Token: 0x0600199F RID: 6559
			public extern PropertyString MarkerStyle { get; }

			// Token: 0x17000CB6 RID: 3254
			// (get) Token: 0x060019A0 RID: 6560
			public extern PropertyObjectId MarkerStyleId { get; }

			// Token: 0x17000CB5 RID: 3253
			// (get) Token: 0x060019A1 RID: 6561
			public extern PropertyString ProfileViewStyle { get; }

			// Token: 0x17000CB4 RID: 3252
			// (get) Token: 0x060019A2 RID: 6562
			public extern PropertyObjectId ProfileViewStyleId { get; }

			// Token: 0x17000CB3 RID: 3251
			// (get) Token: 0x060019A3 RID: 6563
			public extern PropertyString ProfileViewBandStyle { get; }

			// Token: 0x17000CB2 RID: 3250
			// (get) Token: 0x060019A4 RID: 6564
			public extern PropertyObjectId ProfileViewBandStyleId { get; }

			// Token: 0x17000CB1 RID: 3249
			// (get) Token: 0x060019A5 RID: 6565
			[DeprecatedVersion(CivilVersion.Civil2010)]
			[Obsolete("Use Autodesk.Civil.Settings.SettingsProfileView.SettingsStyles.ProfileLabelSet instead.", false)]
			public extern PropertyString ProfileLabelStyle { get; }

			// Token: 0x17000CB0 RID: 3248
			// (get) Token: 0x060019A6 RID: 6566
			public extern PropertyString ProfileLabelSet { get; }

			// Token: 0x17000CAF RID: 3247
			// (get) Token: 0x060019A7 RID: 6567
			public extern PropertyObjectId ProfileLabelSetId { get; }

			// Token: 0x17000CAE RID: 3246
			// (get) Token: 0x060019A8 RID: 6568
			public extern PropertyString FirstSplitViewStyle { get; }

			// Token: 0x17000CAD RID: 3245
			// (get) Token: 0x060019A9 RID: 6569
			public extern PropertyObjectId FirstSplitViewStyleId { get; }

			// Token: 0x17000CAC RID: 3244
			// (get) Token: 0x060019AA RID: 6570
			public extern PropertyString IntermediateSplitViewStyle { get; }

			// Token: 0x17000CAB RID: 3243
			// (get) Token: 0x060019AB RID: 6571
			public extern PropertyObjectId IntermediateSplitViewStyleId { get; }

			// Token: 0x17000CAA RID: 3242
			// (get) Token: 0x060019AC RID: 6572
			public extern PropertyString LastSplitViewStyle { get; }

			// Token: 0x17000CA9 RID: 3241
			// (get) Token: 0x060019AD RID: 6573
			public extern PropertyObjectId LastSplitViewStyleId { get; }

			// Token: 0x17000CA8 RID: 3240
			// (get) Token: 0x060019AE RID: 6574
			public extern PropertyString TopStackViewStyle { get; }

			// Token: 0x17000CA7 RID: 3239
			// (get) Token: 0x060019AF RID: 6575
			public extern PropertyObjectId TopStackViewStyleId { get; }

			// Token: 0x17000CA6 RID: 3238
			// (get) Token: 0x060019B0 RID: 6576
			public extern PropertyString MiddleStackViewStyle { get; }

			// Token: 0x17000CA5 RID: 3237
			// (get) Token: 0x060019B1 RID: 6577
			public extern PropertyObjectId MiddleStackViewStyleId { get; }

			// Token: 0x17000CA4 RID: 3236
			// (get) Token: 0x060019B2 RID: 6578
			public extern PropertyString BottomStackViewStyle { get; }

			// Token: 0x17000CA3 RID: 3235
			// (get) Token: 0x060019B3 RID: 6579
			public extern PropertyObjectId BottomStackViewStyleId { get; }

			// Token: 0x17000CA2 RID: 3234
			// (get) Token: 0x060019B4 RID: 6580
			public extern PropertyString ProjectionStyle { get; }

			// Token: 0x17000CA1 RID: 3233
			// (get) Token: 0x060019B5 RID: 6581
			public extern PropertyObjectId ProjectionStyleId { get; }

			// Token: 0x17000CA0 RID: 3232
			// (get) Token: 0x060019B6 RID: 6582
			public extern PropertyString CutAreaShapeStyle { get; }

			// Token: 0x17000C9F RID: 3231
			// (get) Token: 0x060019B7 RID: 6583
			public extern PropertyObjectId CutAreaShapeStyleId { get; }

			// Token: 0x17000C9E RID: 3230
			// (get) Token: 0x060019B8 RID: 6584
			public extern PropertyString FillAreaShapeStyle { get; }

			// Token: 0x17000C9D RID: 3229
			// (get) Token: 0x060019B9 RID: 6585
			public extern PropertyObjectId FillAreaShapeStyleId { get; }

			// Token: 0x17000C9C RID: 3228
			// (get) Token: 0x060019BA RID: 6586
			public extern PropertyString MultipleBoundaryAreaShapeStyle { get; }

			// Token: 0x17000C9B RID: 3227
			// (get) Token: 0x060019BB RID: 6587
			public extern PropertyObjectId MultipleBoundaryAreaShapeStyleId { get; }

			// Token: 0x17000C9A RID: 3226
			// (get) Token: 0x060019BC RID: 6588
			public extern PropertyString ProfileStationAndElevationLabelStyle { get; }

			// Token: 0x17000C99 RID: 3225
			// (get) Token: 0x060019BD RID: 6589
			public extern PropertyObjectId ProfileStationAndElevationLabelStyleId { get; }

			// Token: 0x17000C98 RID: 3224
			// (get) Token: 0x060019BE RID: 6590
			public extern PropertyString ProfileDepthLabelStyle { get; }

			// Token: 0x17000C97 RID: 3223
			// (get) Token: 0x060019BF RID: 6591
			public extern PropertyObjectId ProfileDepthLabelStyleId { get; }

			// Token: 0x17000C96 RID: 3222
			// (get) Token: 0x060019C0 RID: 6592
			public extern PropertyString ProfileProjectionLabelStyle { get; }

			// Token: 0x17000C95 RID: 3221
			// (get) Token: 0x060019C1 RID: 6593
			public extern PropertyObjectId ProfileProjectionLabelStyleId { get; }
		}

		// Token: 0x02000DA7 RID: 3495
		public class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x17000CBB RID: 3259
			// (get) Token: 0x060019C2 RID: 6594
			public extern PropertyString ProfileView { get; }

			// Token: 0x17000CBA RID: 3258
			// (get) Token: 0x060019C3 RID: 6595
			public extern PropertyString CutArea { get; }

			// Token: 0x17000CB9 RID: 3257
			// (get) Token: 0x060019C4 RID: 6596
			public extern PropertyString FillArea { get; }

			// Token: 0x17000CB8 RID: 3256
			// (get) Token: 0x060019C5 RID: 6597
			public extern PropertyString MultipleBoundaryArea { get; }
		}

		// Token: 0x02000DA8 RID: 3496
		public class SettingsCreation : TreeOidWrapper
		{
			// Token: 0x17000CBE RID: 3262
			// (get) Token: 0x060019C6 RID: 6598
			public extern PropertyBoolean SpecifyProfileStationRange { get; }

			// Token: 0x17000CBD RID: 3261
			// (get) Token: 0x060019C7 RID: 6599
			public extern PropertyBoolean SpecifyProfileElevationRange { get; }

			// Token: 0x17000CBC RID: 3260
			// (get) Token: 0x060019C8 RID: 6600
			public extern PropertyEnum<PipeNetworkPartDisplayType> PipeNetworkParts { get; }
		}

		// Token: 0x02000DA9 RID: 3497
		public class SettingsSplitOptions : TreeOidWrapper
		{
			// Token: 0x17000CC1 RID: 3265
			// (get) Token: 0x060019C9 RID: 6601
			public extern PropertyBoolean SplitProfileViews { get; }

			// Token: 0x17000CC0 RID: 3264
			// (get) Token: 0x060019CA RID: 6602
			public extern PropertyEnum<ProfileViewSplitStationType> SplitStationOption { get; }

			// Token: 0x17000CBF RID: 3263
			// (get) Token: 0x060019CB RID: 6603
			public extern PropertyEnum<ProfileViewSplitDatumType> SplitDatumOption { get; }
		}

		// Token: 0x02000DAA RID: 3498
		public class SettingsStackedOptions : TreeOidWrapper
		{
			// Token: 0x17000CC4 RID: 3268
			// (get) Token: 0x060019CC RID: 6604
			public extern PropertyBoolean StackedViews { get; }

			// Token: 0x17000CC3 RID: 3267
			// (get) Token: 0x060019CD RID: 6605
			public extern PropertyInt NumberOfStackedViews { get; }

			// Token: 0x17000CC2 RID: 3266
			// (get) Token: 0x060019CE RID: 6606
			public extern PropertyDouble GapBetweenViews { get; }
		}

		// Token: 0x02000DAB RID: 3499
		public class SettingsProjectionLabelPlacement : TreeOidWrapper
		{
			// Token: 0x17000CC7 RID: 3271
			// (get) Token: 0x060019CF RID: 6607
			public extern PropertyEnum<DimensionAnchorType> DimensionAnchorOption { get; }

			// Token: 0x17000CC6 RID: 3270
			// (get) Token: 0x060019D0 RID: 6608
			public extern PropertyDouble DimensionAnchorElevationValueForProjections { get; }

			// Token: 0x17000CC5 RID: 3269
			// (get) Token: 0x060019D1 RID: 6609
			public extern PropertyDouble DimensionAnchorPlotHeightValueForProjections { get; }
		}
	}
}
