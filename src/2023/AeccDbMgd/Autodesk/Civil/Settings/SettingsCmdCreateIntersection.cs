using System;
using Autodesk.Civil.DatabaseServices;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010EB RID: 4331
	public sealed class SettingsCmdCreateIntersection : SettingsIntersection
	{
		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x0600231F RID: 8991
		public extern SettingsCmdCreateIntersection.SettingsCmdAssemblyInsertion AssemblyInsertion { get; }

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x06002320 RID: 8992
		public extern SettingsCmdCreateIntersection.SettingsCmdIntersectionOptions IntersectionOptions { get; }

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x06002321 RID: 8993
		public extern SettingsCmdCreateIntersection.SettingsCmdOffsets Offsets { get; }

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x06002322 RID: 8994
		public extern SettingsCmdCreateIntersection.SettingsCmdCrossSlopes CrossSlopes { get; }

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x06002323 RID: 8995
		public extern SettingsCmdCreateIntersection.SettingsCmdCurbReturnParameters CurbReturnParameters { get; }

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06002324 RID: 8996
		public extern SettingsCmdCreateIntersection.SettingsCmdWideningParameters WideningParameters { get; }

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06002325 RID: 8997
		public extern SettingsCmdCreateIntersection.SettingsCmdSecondaryRoadProfileRules SecondaryRoadProfileRules { get; }

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x06002326 RID: 8998
		public extern SettingsCmdCreateIntersection.SettingsCmdCurbReturnProfileRules CurbReturnProfileRules { get; }

		// Token: 0x020010EC RID: 4332
		public sealed class SettingsCmdAssemblyInsertion : TreeOidWrapper
		{
			// Token: 0x17001210 RID: 4624
			// (get) Token: 0x06002327 RID: 8999
			public extern PropertyEnum<CorridorRegionLockType> CorridorRegionLockMode { get; }

			// Token: 0x1700120F RID: 4623
			// (get) Token: 0x06002328 RID: 9000
			public extern PropertyDouble FrequencyAlongTangents { get; }

			// Token: 0x1700120E RID: 4622
			// (get) Token: 0x06002329 RID: 9001
			public extern PropertyDouble FrequencyAlongCurves { get; }

			// Token: 0x1700120D RID: 4621
			// (get) Token: 0x0600232A RID: 9002
			public extern PropertyDouble FrequencyAlongSpirals { get; }

			// Token: 0x1700120C RID: 4620
			// (get) Token: 0x0600232B RID: 9003
			public extern PropertyBoolean HorizontalGeometryPoints { get; }

			// Token: 0x1700120B RID: 4619
			// (get) Token: 0x0600232C RID: 9004
			public extern PropertyBoolean SuperelevationCriticalPoints { get; }

			// Token: 0x1700120A RID: 4618
			// (get) Token: 0x0600232D RID: 9005
			public extern PropertyBoolean ProfileGeometryPoints { get; }

			// Token: 0x17001209 RID: 4617
			// (get) Token: 0x0600232E RID: 9006
			public extern PropertyBoolean ProfileHighLowPoints { get; }

			// Token: 0x17001208 RID: 4616
			// (get) Token: 0x0600232F RID: 9007
			public extern PropertyDouble FrequencyAlongProfileCurves { get; }
		}

		// Token: 0x020010ED RID: 4333
		public sealed class SettingsCmdIntersectionOptions : TreeOidWrapper
		{
			// Token: 0x17001216 RID: 4630
			// (get) Token: 0x06002330 RID: 9008
			public extern PropertyEnum<IntersectionCorridorType> IntersectionType { get; }

			// Token: 0x17001215 RID: 4629
			// (get) Token: 0x06002331 RID: 9009
			public extern PropertyDouble PrimaryRoadDefaultExitAndEntryLength { get; }

			// Token: 0x17001214 RID: 4628
			// (get) Token: 0x06002332 RID: 9010
			public extern PropertyDouble SecondaryRoadDefaultExitAndEntryLength { get; }

			// Token: 0x17001213 RID: 4627
			// (get) Token: 0x06002333 RID: 9011
			public extern PropertyBoolean CreateCurbReturnAlignments { get; }

			// Token: 0x17001212 RID: 4626
			// (get) Token: 0x06002334 RID: 9012
			public extern PropertyBoolean CreateCurbReturnProfiles { get; }

			// Token: 0x17001211 RID: 4625
			// (get) Token: 0x06002335 RID: 9013
			public extern PropertyBoolean CreateIntersectionCorridors { get; }
		}

		// Token: 0x020010EE RID: 4334
		public sealed class SettingsCmdOffsets : TreeOidWrapper
		{
			// Token: 0x1700121B RID: 4635
			// (get) Token: 0x06002336 RID: 9014
			public extern PropertyDouble PrimaryRoadLeftOffset { get; }

			// Token: 0x1700121A RID: 4634
			// (get) Token: 0x06002337 RID: 9015
			public extern PropertyDouble PrimaryRoadRightOffset { get; }

			// Token: 0x17001219 RID: 4633
			// (get) Token: 0x06002338 RID: 9016
			public extern PropertyDouble SecondaryRoadLeftOffset { get; }

			// Token: 0x17001218 RID: 4632
			// (get) Token: 0x06002339 RID: 9017
			public extern PropertyDouble SecondaryRoadRightOffset { get; }

			// Token: 0x17001217 RID: 4631
			// (get) Token: 0x0600233A RID: 9018
			public extern PropertyEnum<OffsetLengthOption> OffsetLengthOptions { get; }
		}

		// Token: 0x020010EF RID: 4335
		public sealed class SettingsCmdCrossSlopes : TreeOidWrapper
		{
			// Token: 0x1700121F RID: 4639
			// (get) Token: 0x0600233B RID: 9019
			public extern PropertyDouble PrimaryRoadLeftCrossSlope { get; }

			// Token: 0x1700121E RID: 4638
			// (get) Token: 0x0600233C RID: 9020
			public extern PropertyDouble PrimaryRoadRightCrossSlope { get; }

			// Token: 0x1700121D RID: 4637
			// (get) Token: 0x0600233D RID: 9021
			public extern PropertyDouble SecondaryRoadLeftCrossSlope { get; }

			// Token: 0x1700121C RID: 4636
			// (get) Token: 0x0600233E RID: 9022
			public extern PropertyDouble SecondaryRoadRightCrossSlope { get; }
		}

		// Token: 0x020010F0 RID: 4336
		public sealed class SettingsCmdCurbReturnParameters : TreeOidWrapper
		{
			// Token: 0x17001228 RID: 4648
			// (get) Token: 0x0600233F RID: 9023
			public extern PropertyEnum<CurbReturnType> CurbReturnType { get; }

			// Token: 0x17001227 RID: 4647
			// (get) Token: 0x06002340 RID: 9024
			public extern PropertyDouble CircularFilletRadius { get; }

			// Token: 0x17001226 RID: 4646
			// (get) Token: 0x06002341 RID: 9025
			public extern PropertyDouble RadiusOfCurve1 { get; }

			// Token: 0x17001225 RID: 4645
			// (get) Token: 0x06002342 RID: 9026
			public extern PropertyDouble RadiusOfCurve2 { get; }

			// Token: 0x17001224 RID: 4644
			// (get) Token: 0x06002343 RID: 9027
			public extern PropertyDouble RadiusOfCurve3 { get; }

			// Token: 0x17001223 RID: 4643
			// (get) Token: 0x06002344 RID: 9028
			public extern PropertyDouble LengthOfCurve1 { get; }

			// Token: 0x17001222 RID: 4642
			// (get) Token: 0x06002345 RID: 9029
			public extern PropertyDouble LengthOfCurve3 { get; }

			// Token: 0x17001221 RID: 4641
			// (get) Token: 0x06002346 RID: 9030
			public extern PropertyDouble ChamferFilletLengthAlongIncomingLane { get; }

			// Token: 0x17001220 RID: 4640
			// (get) Token: 0x06002347 RID: 9031
			public extern PropertyDouble ChamferFilletLengthAlongOutgoingLane { get; }
		}

		// Token: 0x020010F1 RID: 4337
		public sealed class SettingsCmdWideningParameters : TreeOidWrapper
		{
			// Token: 0x17001233 RID: 4659
			// (get) Token: 0x06002348 RID: 9032
			public extern PropertyBoolean WideningAtIncomingLane { get; }

			// Token: 0x17001232 RID: 4658
			// (get) Token: 0x06002349 RID: 9033
			public extern PropertyBoolean WideningAtOutgoingLane { get; }

			// Token: 0x17001231 RID: 4657
			// (get) Token: 0x0600234A RID: 9034
			public extern PropertyDouble WidenedOffset { get; }

			// Token: 0x17001230 RID: 4656
			// (get) Token: 0x0600234B RID: 9035
			public extern PropertyDouble WideningSegmentLength { get; }

			// Token: 0x1700122F RID: 4655
			// (get) Token: 0x0600234C RID: 9036
			public extern PropertyEnum<TransitionType> TransitionType { get; }

			// Token: 0x1700122E RID: 4654
			// (get) Token: 0x0600234D RID: 9037
			public extern PropertyEnum<TransitionInputType> LinearTransitionType { get; }

			// Token: 0x1700122D RID: 4653
			// (get) Token: 0x0600234E RID: 9038
			public extern PropertyDouble TransitionLength { get; }

			// Token: 0x1700122C RID: 4652
			// (get) Token: 0x0600234F RID: 9039
			public extern PropertyDouble TaperRation { get; }

			// Token: 0x1700122B RID: 4651
			// (get) Token: 0x06002350 RID: 9040
			public extern PropertyDouble RadiusofCurve1 { get; }

			// Token: 0x1700122A RID: 4650
			// (get) Token: 0x06002351 RID: 9041
			public extern PropertyDouble RadiusofCurve2 { get; }

			// Token: 0x17001229 RID: 4649
			// (get) Token: 0x06002352 RID: 9042
			public extern PropertyDouble RadiusOfReverseCurve { get; }
		}

		// Token: 0x020010F2 RID: 4338
		public sealed class SettingsCmdSecondaryRoadProfileRules : TreeOidWrapper
		{
			// Token: 0x17001238 RID: 4664
			// (get) Token: 0x06002353 RID: 9043
			public extern PropertyBoolean ApplyGradeRules { get; }

			// Token: 0x17001237 RID: 4663
			// (get) Token: 0x06002354 RID: 9044
			public extern PropertyDouble MaximumGrade { get; }

			// Token: 0x17001236 RID: 4662
			// (get) Token: 0x06002355 RID: 9045
			public extern PropertyDouble MaximumGradeChange { get; }

			// Token: 0x17001235 RID: 4661
			// (get) Token: 0x06002356 RID: 9046
			public extern PropertyEnum<SideRoadProfileDistanceRuleType> DistanceRuleToAdjusttheGrade { get; }

			// Token: 0x17001234 RID: 4660
			// (get) Token: 0x06002357 RID: 9047
			public extern PropertyDouble DistanceValue { get; }
		}

		// Token: 0x020010F3 RID: 4339
		public sealed class SettingsCmdCurbReturnProfileRules : TreeOidWrapper
		{
			// Token: 0x1700123D RID: 4669
			// (get) Token: 0x06002358 RID: 9048
			public extern PropertyEnum<CurbReturnJoiningType> DefineCurbReturnProfileBy { get; }

			// Token: 0x1700123C RID: 4668
			// (get) Token: 0x06002359 RID: 9049
			public extern PropertyBoolean ExtendProfileAlongIncomingLane { get; }

			// Token: 0x1700123B RID: 4667
			// (get) Token: 0x0600235A RID: 9050
			public extern PropertyDouble LengthToExtendAlongIncomingLane { get; }

			// Token: 0x1700123A RID: 4666
			// (get) Token: 0x0600235B RID: 9051
			public extern PropertyBoolean ExtendProfileAlongOutgoingLane { get; }

			// Token: 0x17001239 RID: 4665
			// (get) Token: 0x0600235C RID: 9052
			public extern PropertyDouble LengthToExtendAlongOutgoingLane { get; }
		}
	}
}
