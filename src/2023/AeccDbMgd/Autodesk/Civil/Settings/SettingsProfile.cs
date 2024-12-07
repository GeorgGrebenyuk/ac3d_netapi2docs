using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D5A RID: 3418
	public class SettingsProfile : SettingsAmbient
	{
		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060018A1 RID: 6305
		public extern SettingsProfile.SettingsStyles StyleSettings { get; }

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060018A2 RID: 6306
		public extern SettingsProfile.SettingsDefaultNameFormat DefaultNameFormat { get; }

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060018A3 RID: 6307
		public extern SettingsProfile.SettingsProfileCreation ProfilesCreation { get; }

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060018A4 RID: 6308
		public extern SettingsProfile.SettingsCriteriaBasedDesignOptions CriteriaBasedDesignOptions { get; }

		// Token: 0x02000DA2 RID: 3490
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17000C75 RID: 3189
			// (get) Token: 0x0600197C RID: 6524
			public extern PropertyString ProfileStyle { get; }

			// Token: 0x17000C74 RID: 3188
			// (get) Token: 0x0600197D RID: 6525
			public extern PropertyObjectId ProfileStyleId { get; }

			// Token: 0x17000C73 RID: 3187
			// (get) Token: 0x0600197E RID: 6526
			public extern PropertyString ProfileLabelSet { get; }

			// Token: 0x17000C72 RID: 3186
			// (get) Token: 0x0600197F RID: 6527
			public extern PropertyObjectId ProfileLabelSetId { get; }
		}

		// Token: 0x02000DA3 RID: 3491
		public sealed class SettingsDefaultNameFormat : TreeOidWrapper
		{
			// Token: 0x17000C79 RID: 3193
			// (get) Token: 0x06001980 RID: 6528
			public extern PropertyString ProfileNameTemplate { get; }

			// Token: 0x17000C78 RID: 3192
			// (get) Token: 0x06001981 RID: 6529
			public extern PropertyString OffsetProfileNameTemplate { get; }

			// Token: 0x17000C77 RID: 3191
			// (get) Token: 0x06001982 RID: 6530
			public extern PropertyString SuperimposedProfileNameTemplate { get; }

			// Token: 0x17000C76 RID: 3190
			// (get) Token: 0x06001983 RID: 6531
			public extern PropertyString ThreeDEntityProfileNameTemplate { get; }
		}

		// Token: 0x02000DA4 RID: 3492
		public sealed class SettingsProfileCreation : TreeOidWrapper
		{
			// Token: 0x17000C90 RID: 3216
			// (get) Token: 0x06001984 RID: 6532
			public extern PropertyEnum<ProfileCurveType> DefaultVerticalCurve { get; }

			// Token: 0x17000C8F RID: 3215
			// (get) Token: 0x06001985 RID: 6533
			public extern PropertyEnum<ProfileParabolicVerticalConstraintType> ParabolicCrestVerticalConstraint { get; }

			// Token: 0x17000C8E RID: 3214
			// (get) Token: 0x06001986 RID: 6534
			public extern PropertyEnum<ProfileParabolicVerticalConstraintType> ParabolicSagVerticalConstraint { get; }

			// Token: 0x17000C8D RID: 3213
			// (get) Token: 0x06001987 RID: 6535
			public extern PropertyDouble ParabolicCrestCurveLength { get; }

			// Token: 0x17000C8C RID: 3212
			// (get) Token: 0x06001988 RID: 6536
			public extern PropertyDouble ParabolicCrestCurveKValue { get; }

			// Token: 0x17000C8B RID: 3211
			// (get) Token: 0x06001989 RID: 6537
			public extern PropertyDouble ParabolicSagCurveLength { get; }

			// Token: 0x17000C8A RID: 3210
			// (get) Token: 0x0600198A RID: 6538
			public extern PropertyDouble ParabolicSagCurveKValue { get; }

			// Token: 0x17000C89 RID: 3209
			// (get) Token: 0x0600198B RID: 6539
			public extern PropertyEnum<ProfileCircularVerticalConstraintType> CircularCrestCurveConstraint { get; }

			// Token: 0x17000C88 RID: 3208
			// (get) Token: 0x0600198C RID: 6540
			public extern PropertyEnum<ProfileCircularVerticalConstraintType> CircularSagCurveConstraint { get; }

			// Token: 0x17000C87 RID: 3207
			// (get) Token: 0x0600198D RID: 6541
			public extern PropertyDouble CircularCrestCurveLength { get; }

			// Token: 0x17000C86 RID: 3206
			// (get) Token: 0x0600198E RID: 6542
			public extern PropertyDouble CircularCrestCurveRadius { get; }

			// Token: 0x17000C85 RID: 3205
			// (get) Token: 0x0600198F RID: 6543
			public extern PropertyDouble CircularSagCurveLength { get; }

			// Token: 0x17000C84 RID: 3204
			// (get) Token: 0x06001990 RID: 6544
			public extern PropertyDouble CircularSagCurveRadius { get; }

			// Token: 0x17000C83 RID: 3203
			// (get) Token: 0x06001991 RID: 6545
			public extern PropertyDouble AsymmetricalCrestCurveLength1 { get; }

			// Token: 0x17000C82 RID: 3202
			// (get) Token: 0x06001992 RID: 6546
			public extern PropertyDouble AsymmetricalCrestCurveLength2 { get; }

			// Token: 0x17000C81 RID: 3201
			// (get) Token: 0x06001993 RID: 6547
			public extern PropertyDouble AsymmetricalSagCurveLength1 { get; }

			// Token: 0x17000C80 RID: 3200
			// (get) Token: 0x06001994 RID: 6548
			public extern PropertyDouble AsymmetricalSagCurveLength2 { get; }

			// Token: 0x17000C7F RID: 3199
			// (get) Token: 0x06001995 RID: 6549
			public extern PropertyDouble PassingEyeHeight { get; }

			// Token: 0x17000C7E RID: 3198
			// (get) Token: 0x06001996 RID: 6550
			public extern PropertyDouble PassingObjectHeight { get; }

			// Token: 0x17000C7D RID: 3197
			// (get) Token: 0x06001997 RID: 6551
			public extern PropertyDouble StopEyeHeight { get; }

			// Token: 0x17000C7C RID: 3196
			// (get) Token: 0x06001998 RID: 6552
			public extern PropertyDouble StopObjectHeight { get; }

			// Token: 0x17000C7B RID: 3195
			// (get) Token: 0x06001999 RID: 6553
			public extern PropertyDouble HeadlightAngle { get; }

			// Token: 0x17000C7A RID: 3194
			// (get) Token: 0x0600199A RID: 6554
			public extern PropertyDouble HeadlightHeight { get; }
		}

		// Token: 0x02000DA5 RID: 3493
		public sealed class SettingsCriteriaBasedDesignOptions : TreeOidWrapper
		{
			// Token: 0x17000C94 RID: 3220
			// (get) Token: 0x0600199B RID: 6555
			public extern PropertyString DefaultDesignCheckSet { get; }

			// Token: 0x17000C93 RID: 3219
			// (get) Token: 0x0600199C RID: 6556
			public extern PropertyObjectId DefaultDesignCheckSetId { get; }

			// Token: 0x17000C92 RID: 3218
			// (get) Token: 0x0600199D RID: 6557
			public extern PropertyBoolean UseDesignCriteriaFileOption { get; }

			// Token: 0x17000C91 RID: 3217
			// (get) Token: 0x0600199E RID: 6558
			public extern PropertyBoolean UseDesignChecksOption { get; }
		}
	}
}
