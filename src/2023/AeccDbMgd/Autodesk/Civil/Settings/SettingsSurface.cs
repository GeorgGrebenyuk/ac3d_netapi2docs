using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000B26 RID: 2854
	public class SettingsSurface : SettingsAmbient
	{
		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001557 RID: 5463
		public extern SettingsSurface.SettingsStyles Styles { get; }

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001558 RID: 5464
		public extern SettingsSurface.SettingsContourLabeling ContourLabeling { get; }

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001559 RID: 5465
		public extern SettingsSurface.SettingsDefaults Defaults { get; }

		// Token: 0x02000DB2 RID: 3506
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17000CF0 RID: 3312
			// (get) Token: 0x060019F2 RID: 6642
			public extern PropertyString Surface { get; }

			// Token: 0x17000CEF RID: 3311
			// (get) Token: 0x060019F3 RID: 6643
			public extern PropertyObjectId SurfaceStyleId { get; }

			// Token: 0x17000CEE RID: 3310
			// (get) Token: 0x060019F4 RID: 6644
			public extern PropertyString Marker { get; }

			// Token: 0x17000CED RID: 3309
			// (get) Token: 0x060019F5 RID: 6645
			public extern PropertyObjectId MarkerStyleId { get; }

			// Token: 0x17000CEC RID: 3308
			// (get) Token: 0x060019F6 RID: 6646
			public extern PropertyString SurfaceSpotElevationLabel { get; }

			// Token: 0x17000CEB RID: 3307
			// (get) Token: 0x060019F7 RID: 6647
			public extern PropertyObjectId SurfaceSpotElevationLabelStyleId { get; }

			// Token: 0x17000CEA RID: 3306
			// (get) Token: 0x060019F8 RID: 6648
			public extern PropertyString SurfaceSlopeLabel { get; }

			// Token: 0x17000CE9 RID: 3305
			// (get) Token: 0x060019F9 RID: 6649
			public extern PropertyObjectId SurfaceSlopeLabelStyleId { get; }

			// Token: 0x17000CE8 RID: 3304
			// (get) Token: 0x060019FA RID: 6650
			public extern PropertyString RenderMaterial { get; }
		}

		// Token: 0x02000DB3 RID: 3507
		public sealed class SettingsContourLabeling : TreeOidWrapper
		{
			// Token: 0x17000CF8 RID: 3320
			// (get) Token: 0x060019FB RID: 6651
			public extern PropertyBoolean DisplayContourLabelLine { get; }

			// Token: 0x17000CF7 RID: 3319
			// (get) Token: 0x060019FC RID: 6652
			public extern PropertyEnum<LabelMaskType> LabelMask { get; }

			// Token: 0x17000CF6 RID: 3318
			// (get) Token: 0x060019FD RID: 6653
			public extern PropertyString SurfaceContourLabelStyleMajor { get; }

			// Token: 0x17000CF5 RID: 3317
			// (get) Token: 0x060019FE RID: 6654
			public extern PropertyObjectId SurfaceContourLabelStyleIdMajor { get; }

			// Token: 0x17000CF4 RID: 3316
			// (get) Token: 0x060019FF RID: 6655
			public extern PropertyString SurfaceContourLabelStyleMinor { get; }

			// Token: 0x17000CF3 RID: 3315
			// (get) Token: 0x06001A00 RID: 6656
			public extern PropertyObjectId SurfaceContourLabelStyleIdMinor { get; }

			// Token: 0x17000CF2 RID: 3314
			// (get) Token: 0x06001A01 RID: 6657
			public extern PropertyString SurfaceContourLabelStyleUserDefined { get; }

			// Token: 0x17000CF1 RID: 3313
			// (get) Token: 0x06001A02 RID: 6658
			public extern PropertyObjectId SurfaceContourLabelStyleIdUserDefined { get; }
		}

		// Token: 0x02000DB4 RID: 3508
		public sealed class SettingsDefaults : TreeOidWrapper
		{
			// Token: 0x17000CF9 RID: 3321
			// (get) Token: 0x06001A03 RID: 6659
			public extern PropertyBoolean AutoRebuild { get; }
		}
	}
}
