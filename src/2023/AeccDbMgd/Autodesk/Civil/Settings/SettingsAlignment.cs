using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000AFB RID: 2811
	public class SettingsAlignment : SettingsAmbient
	{
		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060014F7 RID: 5367
		public extern SettingsAlignment.SettingsStyles StyleSettings { get; }

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060014F8 RID: 5368
		public extern SettingsAlignment.SettingsDefaultNameFormat DefaultNameFormat { get; }

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060014F9 RID: 5369
		public extern SettingsAlignment.SettingsStationIndexing StationIndexing { get; }

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060014FA RID: 5370
		public extern SettingsAlignment.SettingsSuperelevationOptions SuperelevationOptions { get; }

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060014FB RID: 5371
		public extern SettingsAlignment.SettingsCantOptions CantOptions { get; }

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060014FC RID: 5372
		public extern SettingsAlignment.SettingsRailAlignmentOptions RailOptions { get; }

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060014FD RID: 5373
		public extern SettingsAlignment.SettingsCriteriaBasedDesignOptions CriteriaBasedDesignOptions { get; }

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060014FE RID: 5374
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use the Autodesk.Civil.Settings.SettingsAlignment.CriteriaBasedDesignOptions instead.", false)]
		public extern SettingsAlignment.SettingsData Data { get; }

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060014FF RID: 5375
		public extern SettingsAlignment.SettingsDynamicAlignmentHighlight DynamicAlignmentHighlight { get; }

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001500 RID: 5376
		public extern SettingsAlignment.SettingsImpliedPointOfIntersection ImpliedPointOfIntersection { get; }

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001501 RID: 5377
		public extern SettingsAlignment.SettingsConstraintEditing ConstraintEditing { get; }

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001502 RID: 5378
		public extern SettingsAlignment.SettingsAutomaticWideningAroundCurves AutomaticWideningAroundCurves { get; }

		// Token: 0x02000D89 RID: 3465
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17000C0E RID: 3086
			// (get) Token: 0x06001909 RID: 6409
			public extern PropertyString AlignmentStyle { get; }

			// Token: 0x17000C0D RID: 3085
			// (get) Token: 0x0600190A RID: 6410
			public extern PropertyObjectId AlignmentStyleId { get; }

			// Token: 0x17000C0C RID: 3084
			// (get) Token: 0x0600190B RID: 6411
			public extern PropertyString MarkerStyle { get; }

			// Token: 0x17000C0B RID: 3083
			// (get) Token: 0x0600190C RID: 6412
			public extern PropertyObjectId MarkerStyleId { get; }

			// Token: 0x17000C0A RID: 3082
			// (get) Token: 0x0600190D RID: 6413
			public extern PropertyString AlignmentLabelSet { get; }

			// Token: 0x17000C09 RID: 3081
			// (get) Token: 0x0600190E RID: 6414
			public extern PropertyObjectId AlignmentLabelSetId { get; }

			// Token: 0x17000C08 RID: 3080
			// (get) Token: 0x0600190F RID: 6415
			[Obsolete("Use Autodesk.Civil.Settings.SettingsAlignment.SettingsStyles.LineLabelStyleId instead.", false)]
			[DeprecatedVersion(CivilVersion.Civil2013)]
			public extern PropertyString LineLabelStyle { get; }

			// Token: 0x17000C07 RID: 3079
			// (get) Token: 0x06001910 RID: 6416
			public extern PropertyObjectId LineLabelStyleId { get; }

			// Token: 0x17000C06 RID: 3078
			// (get) Token: 0x06001911 RID: 6417
			[Obsolete("Use Autodesk.Civil.Settings.SettingsAlignment.SettingsStyles.CurveLabelStyleId instead.", false)]
			[DeprecatedVersion(CivilVersion.Civil2013)]
			public extern PropertyString CurveLabelStyle { get; }

			// Token: 0x17000C05 RID: 3077
			// (get) Token: 0x06001912 RID: 6418
			public extern PropertyObjectId CurveLabelStyleId { get; }

			// Token: 0x17000C04 RID: 3076
			// (get) Token: 0x06001913 RID: 6419
			public extern PropertyString SpiralLabelStyle { get; }

			// Token: 0x17000C03 RID: 3075
			// (get) Token: 0x06001914 RID: 6420
			public extern PropertyObjectId SpiralLabelStyleId { get; }

			// Token: 0x17000C02 RID: 3074
			// (get) Token: 0x06001915 RID: 6421
			public extern PropertyString StationOffsetLabelStyle { get; }

			// Token: 0x17000C01 RID: 3073
			// (get) Token: 0x06001916 RID: 6422
			public extern PropertyObjectId StationOffsetLabelStyleId { get; }

			// Token: 0x17000C00 RID: 3072
			// (get) Token: 0x06001917 RID: 6423
			[DeprecatedVersion(CivilVersion.Civil2012)]
			[Obsolete("Use Autodesk.Civil.Settings.SettingsAlignment.SettingsStyles.PointOfIntersectLabelStyle instead.", true)]
			public extern PropertyString TangentIntersectLabelStyle { get; }

			// Token: 0x17000BFF RID: 3071
			// (get) Token: 0x06001918 RID: 6424
			public extern PropertyObjectId PointOfIntersectLabelStyle { get; }
		}

		// Token: 0x02000D8A RID: 3466
		public sealed class SettingsDefaultNameFormat : TreeOidWrapper
		{
			// Token: 0x17000C10 RID: 3088
			// (get) Token: 0x06001919 RID: 6425
			public extern PropertyString AlignmentNameTemplate { get; }

			// Token: 0x17000C0F RID: 3087
			// (get) Token: 0x0600191A RID: 6426
			public extern PropertyString OffsetAlignmentNameTemplate { get; }
		}

		// Token: 0x02000D8B RID: 3467
		public sealed class SettingsStationIndexing : TreeOidWrapper
		{
			// Token: 0x17000C11 RID: 3089
			// (get) Token: 0x0600191B RID: 6427
			public extern PropertyDouble DefaultStationIndexIncrement { get; }
		}

		// Token: 0x02000D8C RID: 3468
		public sealed class SettingsSuperelevationOptions : TreeOidWrapper
		{
			// Token: 0x17000C25 RID: 3109
			// (get) Token: 0x0600191C RID: 6428
			public extern PropertyEnum<SuperelevationCorridorType> CorridorType { get; }

			// Token: 0x17000C24 RID: 3108
			// (get) Token: 0x0600191D RID: 6429
			public extern PropertyEnum<CrossSectionShapeType> CrossSectionShape { get; }

			// Token: 0x17000C23 RID: 3107
			// (get) Token: 0x0600191E RID: 6430
			public extern PropertyEnum<HighsideLocationType> HighsideLocation { get; }

			// Token: 0x17000C22 RID: 3106
			// (get) Token: 0x0600191F RID: 6431
			public extern PropertyEnum<AlignmentUndividedPivotType> UndividedCrownedPivotMethod { get; }

			// Token: 0x17000C21 RID: 3105
			// (get) Token: 0x06001920 RID: 6432
			public extern PropertyEnum<AlignmentUndividedPivotType> UndividedPlanarPivotMethod { get; }

			// Token: 0x17000C20 RID: 3104
			// (get) Token: 0x06001921 RID: 6433
			public extern PropertyEnum<AlignmentDividedPivotType> DividedCrownedPivotMethod { get; }

			// Token: 0x17000C1F RID: 3103
			// (get) Token: 0x06001922 RID: 6434
			public extern PropertyEnum<AlignmentDividedPivotType> DividedPlanarPivotMethod { get; }

			// Token: 0x17000C1E RID: 3102
			// (get) Token: 0x06001923 RID: 6435
			public extern PropertyEnum<AlignmentMedianTreatmentType> DividedCrownedMedianTreatment { get; }

			// Token: 0x17000C1D RID: 3101
			// (get) Token: 0x06001924 RID: 6436
			public extern PropertyEnum<AlignmentMedianTreatmentType> DividedPlanarMedianTreatment { get; }

			// Token: 0x17000C1C RID: 3100
			// (get) Token: 0x06001925 RID: 6437
			public extern PropertyDouble NominalWidth { get; }

			// Token: 0x17000C1B RID: 3099
			// (get) Token: 0x06001926 RID: 6438
			public extern PropertyDouble NormalLaneSlope { get; }

			// Token: 0x17000C1A RID: 3098
			// (get) Token: 0x06001927 RID: 6439
			public extern PropertyDouble NormalShoulderSlope { get; }

			// Token: 0x17000C19 RID: 3097
			// (get) Token: 0x06001928 RID: 6440
			public extern PropertyDouble MaximumShoulderRollover { get; }

			// Token: 0x17000C18 RID: 3096
			// (get) Token: 0x06001929 RID: 6441
			public extern PropertyEnum<SuperelevationStationRoundingType> StationRoundingOption { get; }

			// Token: 0x17000C17 RID: 3095
			// (get) Token: 0x0600192A RID: 6442
			[Obsolete("Use Autodesk.Civil.Settings.SettingsAlignment.SettingsSuperelevationOptions.OutsideEdgeShoulderTreatmentInHighSide instead.", false)]
			[DeprecatedVersion(CivilVersion.Civil2012)]
			public extern PropertyEnum<ShoulderMethodType> OutsideShoulderMethod { get; }

			// Token: 0x17000C16 RID: 3094
			// (get) Token: 0x0600192B RID: 6443
			[Obsolete("Use Autodesk.Civil.Settings.SettingsAlignment.SettingsSuperelevationOptions.InsideEdgeShoulderTreatmentInHighSide instead.", false)]
			[DeprecatedVersion(CivilVersion.Civil2012)]
			public extern PropertyEnum<ShoulderMethodType> InsideShoulderMethod { get; }

			// Token: 0x17000C15 RID: 3093
			// (get) Token: 0x0600192C RID: 6444
			public extern PropertyEnum<LowSideShoulderMethodType> OutsideEdgeShoulderTreatmentInLowSide { get; }

			// Token: 0x17000C14 RID: 3092
			// (get) Token: 0x0600192D RID: 6445
			public extern PropertyEnum<HighSideShoulderMethodType> OutsideEdgeShoulderTreatmentInHighSide { get; }

			// Token: 0x17000C13 RID: 3091
			// (get) Token: 0x0600192E RID: 6446
			public extern PropertyEnum<LowSideShoulderMethodType> InsideEdgeShoulderTreatmentInLowSide { get; }

			// Token: 0x17000C12 RID: 3090
			// (get) Token: 0x0600192F RID: 6447
			public extern PropertyEnum<HighSideShoulderMethodType> InsideEdgeShoulderTreatmentInHighSide { get; }
		}

		// Token: 0x02000D8D RID: 3469
		public sealed class SettingsCantOptions : TreeOidWrapper
		{
			// Token: 0x17000C2F RID: 3119
			// (get) Token: 0x06001930 RID: 6448
			public extern PropertyExpression EquilibriumCantFormula { get; }

			// Token: 0x17000C2E RID: 3118
			// (get) Token: 0x06001931 RID: 6449
			public extern PropertyExpression MaxDeficiencyFormula { get; }

			// Token: 0x17000C2D RID: 3117
			// (get) Token: 0x06001932 RID: 6450
			public extern PropertyEnum<CantPivotMethodType> PivotMethod { get; }

			// Token: 0x17000C2C RID: 3116
			// (get) Token: 0x06001933 RID: 6451
			public extern PropertyDouble TangentTangentCurve { get; }

			// Token: 0x17000C2B RID: 3115
			// (get) Token: 0x06001934 RID: 6452
			public extern PropertyDouble SpiralSpiralCurve { get; }

			// Token: 0x17000C2A RID: 3114
			// (get) Token: 0x06001935 RID: 6453
			public extern PropertyDouble MaxAppliedCantOnTangent { get; }

			// Token: 0x17000C29 RID: 3113
			// (get) Token: 0x06001936 RID: 6454
			public extern PropertyEnum<CantStationRoundingType> StationRoundingOption { get; }

			// Token: 0x17000C28 RID: 3112
			// (get) Token: 0x06001937 RID: 6455
			public extern PropertyDouble EquationRoundingOption { get; }

			// Token: 0x17000C27 RID: 3111
			// (get) Token: 0x06001938 RID: 6456
			public extern PropertyEnum<DesignSpeedLookupMethodType> DesignSpeedLookupMethod { get; }

			// Token: 0x17000C26 RID: 3110
			// (get) Token: 0x06001939 RID: 6457
			public extern PropertyEnum<RadiusLookupMethodType> RadiusLookupMethod { get; }
		}

		// Token: 0x02000D8E RID: 3470
		public sealed class SettingsRailAlignmentOptions : TreeOidWrapper
		{
			// Token: 0x17000C31 RID: 3121
			// (get) Token: 0x0600193A RID: 6458
			public extern PropertyDouble TrackWidth { get; }

			// Token: 0x17000C30 RID: 3120
			// (get) Token: 0x0600193B RID: 6459
			public extern PropertyBoolean MeasureRailCurvesAlongChords { get; }
		}

		// Token: 0x02000D8F RID: 3471
		public sealed class SettingsCriteriaBasedDesignOptions : TreeOidWrapper
		{
			// Token: 0x17000C39 RID: 3129
			// (get) Token: 0x0600193C RID: 6460
			public extern PropertyBoolean UseCriteriaBasedDesignOption { get; }

			// Token: 0x17000C38 RID: 3128
			// (get) Token: 0x0600193D RID: 6461
			public extern PropertyBoolean UseDesignCriteriaFileOption { get; }

			// Token: 0x17000C37 RID: 3127
			// (get) Token: 0x0600193E RID: 6462
			public extern PropertyBoolean UseDesignChecksOption { get; }

			// Token: 0x17000C36 RID: 3126
			// (get) Token: 0x0600193F RID: 6463
			public extern PropertyString DefaultDesignCheckSet { get; }

			// Token: 0x17000C35 RID: 3125
			// (get) Token: 0x06001940 RID: 6464
			public extern PropertyObjectId DefaultDesignCheckSetId { get; }

			// Token: 0x17000C34 RID: 3124
			// (get) Token: 0x06001941 RID: 6465
			public extern PropertyEnum<DesignSpeedLookupMethodType> DesignSpeedLookupMethod { get; }

			// Token: 0x17000C33 RID: 3123
			// (get) Token: 0x06001942 RID: 6466
			public extern PropertyEnum<RadiusLookupMethodType> RadiusLookupMethod { get; }

			// Token: 0x17000C32 RID: 3122
			// (get) Token: 0x06001943 RID: 6467
			public extern PropertyDouble DesignSpeed { get; }
		}

		// Token: 0x02000D90 RID: 3472
		public sealed class SettingsData : TreeOidWrapper
		{
			// Token: 0x17000C3A RID: 3130
			// (get) Token: 0x06001944 RID: 6468
			[DeprecatedVersion(CivilVersion.Civil2010)]
			[Obsolete("Use the Autodesk.Civil.Settings.SettingsAlignment.SettingsCriteriaBasedDesignOptions.UseDefaultDesignCheckSet instead.", false)]
			public extern PropertyBoolean CriteriaBasedDesignOption { get; }
		}

		// Token: 0x02000D91 RID: 3473
		public sealed class SettingsDynamicAlignmentHighlight : TreeOidWrapper
		{
			// Token: 0x17000C44 RID: 3140
			// (get) Token: 0x06001945 RID: 6469
			public extern PropertyColor OffsetRegionColor { get; }

			// Token: 0x17000C43 RID: 3139
			// (get) Token: 0x06001946 RID: 6470
			public extern PropertyColor TransitionRegionColor { get; }

			// Token: 0x17000C42 RID: 3138
			// (get) Token: 0x06001947 RID: 6471
			public extern PropertyColor CurbReturnFilletRegionColor { get; }

			// Token: 0x17000C41 RID: 3137
			// (get) Token: 0x06001948 RID: 6472
			public extern PropertyColor ParentAlignmentColor { get; }

			// Token: 0x17000C40 RID: 3136
			// (get) Token: 0x06001949 RID: 6473
			public extern PropertyColor ParentAlignmentTrackerColor { get; }

			// Token: 0x17000C3F RID: 3135
			// (get) Token: 0x0600194A RID: 6474
			public extern PropertyEnum<LineWeight> OffsetRegionLineweight { get; }

			// Token: 0x17000C3E RID: 3134
			// (get) Token: 0x0600194B RID: 6475
			public extern PropertyEnum<LineWeight> TransitionRegionLineweight { get; }

			// Token: 0x17000C3D RID: 3133
			// (get) Token: 0x0600194C RID: 6476
			public extern PropertyEnum<LineWeight> CurbReturnFilletRegionLineweight { get; }

			// Token: 0x17000C3C RID: 3132
			// (get) Token: 0x0600194D RID: 6477
			public extern PropertyEnum<LineWeight> ParentAlignmentLineweight { get; }

			// Token: 0x17000C3B RID: 3131
			// (get) Token: 0x0600194E RID: 6478
			public extern PropertyEnum<LineWeight> ParentAlignmentTrackerLineweight { get; }
		}

		// Token: 0x02000D92 RID: 3474
		public sealed class SettingsImpliedPointOfIntersection : TreeOidWrapper
		{
			// Token: 0x17000C45 RID: 3141
			// (get) Token: 0x0600194F RID: 6479
			public extern PropertyEnum<ImpliedPointOfIntersectionDisplayType> DisplayMethod { get; }
		}

		// Token: 0x02000D93 RID: 3475
		public sealed class SettingsConstraintEditing : TreeOidWrapper
		{
			// Token: 0x17000C47 RID: 3143
			// (get) Token: 0x06001950 RID: 6480
			public extern PropertyBoolean AlwaysPerformImpliedSwapping { get; }

			// Token: 0x17000C46 RID: 3142
			// (get) Token: 0x06001951 RID: 6481
			public extern PropertyBoolean LockInitialParameters { get; }
		}

		// Token: 0x02000D94 RID: 3476
		public sealed class SettingsAutomaticWideningAroundCurves : TreeOidWrapper
		{
			// Token: 0x17000C4D RID: 3149
			// (get) Token: 0x06001952 RID: 6482
			public extern PropertyEnum<WideningSide> WideningApplySide { get; }

			// Token: 0x17000C4C RID: 3148
			// (get) Token: 0x06001953 RID: 6483
			public extern PropertyDouble WheelbaseLength { get; }

			// Token: 0x17000C4B RID: 3147
			// (get) Token: 0x06001954 RID: 6484
			public extern PropertyBoolean AutomaticWideningAtCurves { get; }

			// Token: 0x17000C4A RID: 3146
			// (get) Token: 0x06001955 RID: 6485
			public extern PropertyEnum<WideningByMethod> WideningMethod { get; }

			// Token: 0x17000C49 RID: 3145
			// (get) Token: 0x06001956 RID: 6486
			public extern PropertyDouble ManualWideningWidth { get; }

			// Token: 0x17000C48 RID: 3144
			// (get) Token: 0x06001957 RID: 6487
			public extern PropertyDouble ManualTransitionLength { get; }
		}
	}
}
