using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x0200012D RID: 301
	public class SettingsPressureNetwork : SettingsAmbient
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600015D RID: 349
		public extern SettingsPressureNetwork.SettingsStyles Styles { get; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600015E RID: 350
		public extern SettingsPressureNetwork.SettingsNameFormat NameFormat { get; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600015F RID: 351
		public extern SettingsPressureNetwork.SettingsProfileLabelPlacement ProfileLabelPlacement { get; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000160 RID: 352
		public extern SettingsPressureNetwork.SettingsSectionLabelPlacement SectionLabelPlacement { get; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000161 RID: 353
		public extern SettingsPressureNetwork.SettingsDepthOfCover Cover { get; }

		// Token: 0x020001C4 RID: 452
		public class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17000124 RID: 292
			// (get) Token: 0x060001F6 RID: 502
			public extern PropertyString AppurtenanceStyle { get; }

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x060001F7 RID: 503
			public extern PropertyObjectId AppurtenanceStyleId { get; }

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x060001F8 RID: 504
			public extern PropertyString FittingStyle { get; }

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x060001F9 RID: 505
			public extern PropertyObjectId FittingStyleId { get; }

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x060001FA RID: 506
			public extern PropertyString PressurePipeStyle { get; }

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x060001FB RID: 507
			public extern PropertyObjectId PressurePipeStyleId { get; }

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x060001FC RID: 508
			public extern PropertyString FittingPlanLabelStyle { get; }

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x060001FD RID: 509
			public extern PropertyObjectId FittingPlanLabelStyleId { get; }

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x060001FE RID: 510
			public extern PropertyString AppurtenancePlanLabelStyle { get; }

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x060001FF RID: 511
			public extern PropertyObjectId AppurtenancePlanLabelStyleId { get; }

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x06000200 RID: 512
			public extern PropertyString PressurePipePlanLabelStyle { get; }

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000201 RID: 513
			public extern PropertyObjectId PressurePipePlanLabelStyleId { get; }

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000202 RID: 514
			public extern PropertyString FittingProfileLabelStyle { get; }

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000203 RID: 515
			public extern PropertyObjectId FittingProfileLabelStyleId { get; }

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000204 RID: 516
			public extern PropertyString AppurtenanceProfileLabelStyle { get; }

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x06000205 RID: 517
			public extern PropertyObjectId AppurtenanceProfileLabelStyleId { get; }

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x06000206 RID: 518
			public extern PropertyString PressurePipeProfileLabelStyle { get; }

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x06000207 RID: 519
			public extern PropertyObjectId PressurePipeProfileLabelStyleId { get; }

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x06000208 RID: 520
			public extern PropertyString CrossingPressurePipeProfileLabelStyle { get; }

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000209 RID: 521
			public extern PropertyObjectId CrossingPressurePipeProfileLabelStyleId { get; }

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x0600020A RID: 522
			public extern PropertyString CrossingPressurePipeSectionLabelStyle { get; }

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x0600020B RID: 523
			public extern PropertyObjectId CrossingPressurePipeSectionLabelStyleId { get; }

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x0600020C RID: 524
			public extern PropertyString RenderMaterial { get; }

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x0600020D RID: 525
			public extern PropertyString PartsList { get; }

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x0600020E RID: 526
			public extern PropertyObjectId PartsListId { get; }
		}

		// Token: 0x020001C5 RID: 453
		public class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x1700012A RID: 298
			// (get) Token: 0x0600020F RID: 527
			public extern PropertyString AppurtenanceNameTemplate { get; }

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000210 RID: 528
			public extern PropertyString FittingNameTemplate { get; }

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000211 RID: 529
			public extern PropertyString PressureNetworkNameTemplate { get; }

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x06000212 RID: 530
			public extern PropertyString PressurePipeNameTemplate { get; }

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x06000213 RID: 531
			public extern PropertyString AlignmentFromPressureNetworkNameTemplate { get; }

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000214 RID: 532
			public extern PropertyString PipeRunNameTemplate { get; }
		}

		// Token: 0x020001C6 RID: 454
		public class SettingsProfileLabelPlacement : TreeOidWrapper
		{
			// Token: 0x17000133 RID: 307
			// (get) Token: 0x06000215 RID: 533
			public extern PropertyEnum<DimensionAnchorType> DimensionAnchorOptionForPressurePipes { get; }

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000216 RID: 534
			public extern PropertyDouble DimensionAnchorElevationValueForPressurePipes { get; }

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x06000217 RID: 535
			public extern PropertyDouble DimensionAnchorPlotHeightValueForPressurePipes { get; }

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000218 RID: 536
			public extern PropertyEnum<DimensionAnchorType> DimensionAnchorOptionForFittings { get; }

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x06000219 RID: 537
			public extern PropertyDouble DimensionAnchorElevationValueForFittings { get; }

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x0600021A RID: 538
			public extern PropertyDouble DimensionAnchorPlotHeightValueForFittings { get; }

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x0600021B RID: 539
			public extern PropertyEnum<DimensionAnchorType> DimensionAnchorOptionForAppurtenances { get; }

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x0600021C RID: 540
			public extern PropertyDouble DimensionAnchorElevationValueForAppurtenances { get; }

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x0600021D RID: 541
			public extern PropertyDouble DimensionAnchorPlotHeightValueForAppurtenances { get; }
		}

		// Token: 0x020001C7 RID: 455
		public class SettingsSectionLabelPlacement : TreeOidWrapper
		{
			// Token: 0x1700013F RID: 319
			// (get) Token: 0x0600021E RID: 542
			public extern PropertyEnum<DimensionAnchorType> DimensionAnchorOptionForPressurePipes { get; }

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x0600021F RID: 543
			public extern PropertyDouble DimensionAnchorElevationValueForPressurePipes { get; }

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x06000220 RID: 544
			public extern PropertyDouble DimensionAnchorPlotHeightValueForPressurePipes { get; }

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x06000221 RID: 545
			public extern PropertyInt PressurePipeSectionLabelPlacement { get; }

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x06000222 RID: 546
			public extern PropertyEnum<DimensionAnchorType> DimensionAnchorOptionForFittings { get; }

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000223 RID: 547
			public extern PropertyDouble DimensionAnchorElevationValueForFittings { get; }

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x06000224 RID: 548
			public extern PropertyDouble DimensionAnchorPlotHeightValueForFittings { get; }

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x06000225 RID: 549
			public extern PropertyInt FittingSectionLabelPlacement { get; }

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x06000226 RID: 550
			public extern PropertyEnum<DimensionAnchorType> DimensionAnchorOptionForAppurtenances { get; }

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x06000227 RID: 551
			public extern PropertyDouble DimensionAnchorElevationValueForAppurtenances { get; }

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x06000228 RID: 552
			public extern PropertyDouble DimensionAnchorPlotHeightValueForAppurtenances { get; }

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x06000229 RID: 553
			public extern PropertyInt AppurtenanceSectionLabelPlacement { get; }
		}

		// Token: 0x020001C8 RID: 456
		public sealed class SettingsDepthOfCover : TreeOidWrapper
		{
			// Token: 0x17000140 RID: 320
			// (get) Token: 0x0600022A RID: 554
			public extern PropertyDouble DepthBelowSurface { get; }
		}
	}
}
