using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.Settings
{
	// Token: 0x0200108E RID: 4238
	public class SettingsLandXMLImport : TreeOidWrapper
	{
		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x060021DB RID: 8667
		public extern SettingsLandXMLImport.SettingsTranslation Translation { get; }

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x060021DC RID: 8668
		public extern SettingsLandXMLImport.SettingsRotation Rotation { get; }

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x060021DD RID: 8669
		public extern SettingsLandXMLImport.SettingsPointImport PointImport { get; }

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x060021DE RID: 8670
		public extern SettingsLandXMLImport.SettingsSurfaceImport SurfaceImport { get; }

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x060021DF RID: 8671
		public extern SettingsLandXMLImport.SettingsPipeNetwork PipeNetwork { get; }

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x060021E0 RID: 8672
		public extern SettingsLandXMLImport.SettingsConflictResolution ConflictResolution { get; }

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x060021E1 RID: 8673
		public extern SettingsLandXMLImport.SettingsDiameterUnits DiameterUnits { get; }

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x060021E2 RID: 8674
		public extern SettingsLandXMLImport.SettingsAlignmentImport AlignmentImport { get; }

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x060021E3 RID: 8675
		public extern SettingsLandXMLImport.SettingsPropertySetData PropertySetData { get; }

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x060021E4 RID: 8676
		public extern SettingsLandXMLImport.SettingsFeatureLineImport FeatureLineImport { get; }

		// Token: 0x0200109B RID: 4251
		public sealed class SettingsTranslation : TreeOidWrapper
		{
			// Token: 0x17001144 RID: 4420
			// (get) Token: 0x06002213 RID: 8723
			// (set) Token: 0x06002214 RID: 8724
			public extern bool Translate { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

			// Token: 0x17001143 RID: 4419
			// (get) Token: 0x06002215 RID: 8725
			// (set) Token: 0x06002216 RID: 8726
			public extern double BasePointNorthing { get; set; }

			// Token: 0x17001142 RID: 4418
			// (get) Token: 0x06002217 RID: 8727
			// (set) Token: 0x06002218 RID: 8728
			public extern double BasePointEasting { get; set; }

			// Token: 0x17001141 RID: 4417
			// (get) Token: 0x06002219 RID: 8729
			// (set) Token: 0x0600221A RID: 8730
			public extern double BasePointElevation { get; set; }

			// Token: 0x17001140 RID: 4416
			// (get) Token: 0x0600221B RID: 8731
			// (set) Token: 0x0600221C RID: 8732
			public extern double TranslatedCoordinateNorthing { get; set; }

			// Token: 0x1700113F RID: 4415
			// (get) Token: 0x0600221D RID: 8733
			// (set) Token: 0x0600221E RID: 8734
			public extern double TranslatedCoordinateEasting { get; set; }

			// Token: 0x1700113E RID: 4414
			// (get) Token: 0x0600221F RID: 8735
			// (set) Token: 0x06002220 RID: 8736
			public extern double TranslatedCoordinateElevation { get; set; }
		}

		// Token: 0x0200109C RID: 4252
		public sealed class SettingsRotation : TreeOidWrapper
		{
			// Token: 0x17001147 RID: 4423
			// (get) Token: 0x06002221 RID: 8737
			// (set) Token: 0x06002222 RID: 8738
			public extern bool Rotate { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

			// Token: 0x17001146 RID: 4422
			// (get) Token: 0x06002223 RID: 8739
			// (set) Token: 0x06002224 RID: 8740
			public extern double Angle { get; set; }

			// Token: 0x17001145 RID: 4421
			// (get) Token: 0x06002225 RID: 8741
			// (set) Token: 0x06002226 RID: 8742
			public extern RotationDirType Direction { get; set; }
		}

		// Token: 0x0200109D RID: 4253
		public sealed class SettingsPointImport : TreeOidWrapper
		{
			// Token: 0x17001148 RID: 4424
			// (get) Token: 0x06002227 RID: 8743
			// (set) Token: 0x06002228 RID: 8744
			public extern LandXMLPointDescriptionType PointDescription { get; set; }
		}

		// Token: 0x0200109E RID: 4254
		public sealed class SettingsSurfaceImport : TreeOidWrapper
		{
			// Token: 0x17001150 RID: 4432
			// (get) Token: 0x06002229 RID: 8745
			// (set) Token: 0x0600222A RID: 8746
			public extern LandXMLSurfaceDataImportType SurfaceData { get; set; }

			// Token: 0x1700114F RID: 4431
			// (get) Token: 0x0600222B RID: 8747
			// (set) Token: 0x0600222C RID: 8748
			public extern bool CreateSnapshotAfterImport { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

			// Token: 0x1700114E RID: 4430
			// (get) Token: 0x0600222D RID: 8749
			// (set) Token: 0x0600222E RID: 8750
			public extern bool CreateSourceDataInDrawing { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

			// Token: 0x1700114D RID: 4429
			// (get) Token: 0x0600222F RID: 8751
			public extern PropertyString BreakLineAsFeatureLineSiteCreation { get; }

			// Token: 0x1700114C RID: 4428
			// (get) Token: 0x06002230 RID: 8752
			public extern PropertyObjectId BreakLineAsFeatureLineSiteCreationId { get; }

			// Token: 0x1700114B RID: 4427
			// (get) Token: 0x06002231 RID: 8753
			// (set) Token: 0x06002232 RID: 8754
			public extern bool CreateBreakLinesPropertySetData { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

			// Token: 0x1700114A RID: 4426
			// (get) Token: 0x06002233 RID: 8755
			// (set) Token: 0x06002234 RID: 8756
			public extern bool AddOperationForBreakLines { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

			// Token: 0x17001149 RID: 4425
			// (get) Token: 0x06002235 RID: 8757
			// (set) Token: 0x06002236 RID: 8758
			public extern bool ConvertSurveyFootToInternationalFoot { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
		}

		// Token: 0x0200109F RID: 4255
		public sealed class SettingsPropertySetData : TreeOidWrapper
		{
			// Token: 0x17001151 RID: 4433
			// (get) Token: 0x06002237 RID: 8759
			// (set) Token: 0x06002238 RID: 8760
			public extern bool CreateAllPropertySetData { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
		}

		// Token: 0x020010A0 RID: 4256
		public sealed class SettingsPipeNetwork : TreeOidWrapper
		{
			// Token: 0x1700115B RID: 4443
			// (get) Token: 0x06002239 RID: 8761
			// (set) Token: 0x0600223A RID: 8762
			public extern string PartsListForPartFamilySizeMatching { get; set; }

			// Token: 0x1700115A RID: 4442
			// (get) Token: 0x0600223B RID: 8763
			// (set) Token: 0x0600223C RID: 8764
			public extern string MatchCircularPipesWith { get; set; }

			// Token: 0x17001159 RID: 4441
			// (get) Token: 0x0600223D RID: 8765
			// (set) Token: 0x0600223E RID: 8766
			public extern string MatchEggShapedPipesWith { get; set; }

			// Token: 0x17001158 RID: 4440
			// (get) Token: 0x0600223F RID: 8767
			// (set) Token: 0x06002240 RID: 8768
			public extern string MatchEllipticalShapedPipesWith { get; set; }

			// Token: 0x17001157 RID: 4439
			// (get) Token: 0x06002241 RID: 8769
			// (set) Token: 0x06002242 RID: 8770
			public extern string MatchRectangleShapedPipesWith { get; set; }

			// Token: 0x17001156 RID: 4438
			// (get) Token: 0x06002243 RID: 8771
			// (set) Token: 0x06002244 RID: 8772
			public extern string MatchChannelShapedPipesWith { get; set; }

			// Token: 0x17001155 RID: 4437
			// (get) Token: 0x06002245 RID: 8773
			// (set) Token: 0x06002246 RID: 8774
			public extern string MatchCircularStructuresWith { get; set; }

			// Token: 0x17001154 RID: 4436
			// (get) Token: 0x06002247 RID: 8775
			// (set) Token: 0x06002248 RID: 8776
			public extern string MatchRectangleStructuresWith { get; set; }

			// Token: 0x17001153 RID: 4435
			// (get) Token: 0x06002249 RID: 8777
			// (set) Token: 0x0600224A RID: 8778
			public extern string MatchInletOutletStructuresWith { get; set; }

			// Token: 0x17001152 RID: 4434
			// (get) Token: 0x0600224B RID: 8779
			// (set) Token: 0x0600224C RID: 8780
			public extern string MatchConnectionStructuresWith { get; set; }
		}

		// Token: 0x020010A1 RID: 4257
		public sealed class SettingsConflictResolution : TreeOidWrapper
		{
			// Token: 0x1700115C RID: 4444
			// (get) Token: 0x0600224D RID: 8781
			// (set) Token: 0x0600224E RID: 8782
			public extern LandXMLConflictResolutionType ConflictResolution { get; set; }
		}

		// Token: 0x020010A2 RID: 4258
		public sealed class SettingsDiameterUnits : TreeOidWrapper
		{
			// Token: 0x1700115E RID: 4446
			// (get) Token: 0x0600224F RID: 8783
			// (set) Token: 0x06002250 RID: 8784
			public extern LandXMLImperialUnitType Imperial { get; set; }

			// Token: 0x1700115D RID: 4445
			// (get) Token: 0x06002251 RID: 8785
			// (set) Token: 0x06002252 RID: 8786
			public extern LandXMLMetricUnitType Metric { get; set; }
		}

		// Token: 0x020010A3 RID: 4259
		public sealed class SettingsAlignmentImport : TreeOidWrapper
		{
			// Token: 0x1700115F RID: 4447
			// (get) Token: 0x06002253 RID: 8787
			// (set) Token: 0x06002254 RID: 8788
			public extern LandXMLImportAlignmentType ElementConstraintAssignment { get; set; }
		}

		// Token: 0x020010A4 RID: 4260
		public sealed class SettingsFeatureLineImport : TreeOidWrapper
		{
			// Token: 0x17001160 RID: 4448
			// (get) Token: 0x06002255 RID: 8789
			// (set) Token: 0x06002256 RID: 8790
			public extern LandXMLImportFeatureLineSite FeatureLineSiteSource { get; set; }
		}
	}
}
