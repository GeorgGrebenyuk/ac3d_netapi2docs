using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.Settings
{
	// Token: 0x0200108F RID: 4239
	public class SettingsLandXMLExport : TreeOidWrapper
	{
		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x060021E5 RID: 8677
		public extern SettingsLandXMLExport.SettingsIdentification Identification { get; }

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x060021E6 RID: 8678
		public extern SettingsLandXMLExport.SettingsData Data { get; }

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x060021E7 RID: 8679
		public extern SettingsLandXMLExport.SettingsPointExport PointExport { get; }

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x060021E8 RID: 8680
		public extern SettingsLandXMLExport.SettingsSurfaceExport SurfaceExport { get; }

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x060021E9 RID: 8681
		public extern SettingsLandXMLExport.SettingsParcelExport ParcelExport { get; }

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x060021EA RID: 8682
		public extern SettingsLandXMLExport.SettingsAlignmentExport AlignmentExport { get; }

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x060021EB RID: 8683
		public extern SettingsLandXMLExport.SettingsFeatureLineExport FeatureLineExport { get; }

		// Token: 0x02001090 RID: 4240
		public sealed class SettingsIdentification : TreeOidWrapper
		{
			// Token: 0x1700112E RID: 4398
			// (get) Token: 0x060021EC RID: 8684
			// (set) Token: 0x060021ED RID: 8685
			public extern bool WriteIdentificationElements { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

			// Token: 0x1700112D RID: 4397
			// (get) Token: 0x060021EE RID: 8686
			// (set) Token: 0x060021EF RID: 8687
			public extern string Creator { get; set; }

			// Token: 0x1700112C RID: 4396
			// (get) Token: 0x060021F0 RID: 8688
			// (set) Token: 0x060021F1 RID: 8689
			public extern string EmailAddress { get; set; }

			// Token: 0x1700112B RID: 4395
			// (get) Token: 0x060021F2 RID: 8690
			// (set) Token: 0x060021F3 RID: 8691
			public extern string Company { get; set; }

			// Token: 0x1700112A RID: 4394
			// (get) Token: 0x060021F4 RID: 8692
			// (set) Token: 0x060021F5 RID: 8693
			public extern string CompanyURL { get; set; }
		}

		// Token: 0x02001091 RID: 4241
		public sealed class SettingsData : TreeOidWrapper
		{
			// Token: 0x17001131 RID: 4401
			// (get) Token: 0x060021F6 RID: 8694
			// (set) Token: 0x060021F7 RID: 8695
			public extern LandXMLLinearUnits ImperialUnits { get; set; }

			// Token: 0x17001130 RID: 4400
			// (get) Token: 0x060021F8 RID: 8696
			// (set) Token: 0x060021F9 RID: 8697
			public extern LandXMLAngularUnits AngleDirectionFormat { get; set; }

			// Token: 0x1700112F RID: 4399
			// (get) Token: 0x060021FA RID: 8698
			// (set) Token: 0x060021FB RID: 8699
			public extern bool CreateReadOnlyFile { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
		}

		// Token: 0x02001092 RID: 4242
		public sealed class SettingsPointExport : TreeOidWrapper
		{
			// Token: 0x17001137 RID: 4407
			// (get) Token: 0x060021FC RID: 8700
			// (set) Token: 0x060021FD RID: 8701
			public extern LandXMLAttributeExportType CodeAttribute { get; set; }

			// Token: 0x17001136 RID: 4406
			// (get) Token: 0x060021FE RID: 8702
			// (set) Token: 0x060021FF RID: 8703
			public extern LandXMLAttributeExportType DescAttribute { get; set; }

			// Token: 0x17001135 RID: 4405
			// (get) Token: 0x06002200 RID: 8704
			// (set) Token: 0x06002201 RID: 8705
			public extern bool SkipFullWhenSameAsRaw { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

			// Token: 0x17001134 RID: 4404
			// (get) Token: 0x06002202 RID: 8706
			// (set) Token: 0x06002203 RID: 8707
			public extern bool ExportPointReferences { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

			// Token: 0x17001133 RID: 4403
			// (get) Token: 0x06002204 RID: 8708
			// (set) Token: 0x06002205 RID: 8709
			public extern double PointReferenceTolerance { get; set; }

			// Token: 0x17001132 RID: 4402
			// (get) Token: 0x06002206 RID: 8710
			// (set) Token: 0x06002207 RID: 8711
			public extern bool ExportDescriptionKeys { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
		}

		// Token: 0x02001093 RID: 4243
		public sealed class SettingsSurfaceExport : TreeOidWrapper
		{
			// Token: 0x17001139 RID: 4409
			// (get) Token: 0x06002208 RID: 8712
			// (set) Token: 0x06002209 RID: 8713
			public extern LandXMLSurfaceDataExportType SurfaceData { get; set; }

			// Token: 0x17001138 RID: 4408
			// (get) Token: 0x0600220A RID: 8714
			// (set) Token: 0x0600220B RID: 8715
			public extern bool Watersheds { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
		}

		// Token: 0x02001094 RID: 4244
		public sealed class SettingsParcelExport : TreeOidWrapper
		{
			// Token: 0x1700113A RID: 4410
			// (get) Token: 0x0600220C RID: 8716
			// (set) Token: 0x0600220D RID: 8717
			public extern RotationDirType ParcelDirection { get; set; }
		}

		// Token: 0x02001095 RID: 4245
		public sealed class SettingsAlignmentExport : TreeOidWrapper
		{
			// Token: 0x1700113B RID: 4411
			// (get) Token: 0x0600220E RID: 8718
			// (set) Token: 0x0600220F RID: 8719
			public extern bool ExportCrossSections { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }
		}

		// Token: 0x02001096 RID: 4246
		public sealed class SettingsFeatureLineExport : TreeOidWrapper
		{
			// Token: 0x1700113D RID: 4413
			// (get) Token: 0x06002210 RID: 8720
			// (set) Token: 0x06002211 RID: 8721
			public extern bool FeatureLineAddNameToUnNamed { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

			// Token: 0x1700113C RID: 4412
			// (get) Token: 0x06002212 RID: 8722
			public extern PropertyString NewNameTemplate { get; }
		}
	}
}
