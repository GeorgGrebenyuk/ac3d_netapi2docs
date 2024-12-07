using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000B0B RID: 2827
	public sealed class SettingsCmdCreateCatchmentFromSurface : SettingsCatchment
	{
		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001524 RID: 5412
		public extern SettingsCmdCreateCatchmentFromSurface.SettingsCmdCatchment Catchment { get; }

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001525 RID: 5413
		public extern SettingsCmdCreateCatchmentFromSurface.SettingsCmdHydrologicalProperties HydrologicalProperties { get; }

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001526 RID: 5414
		public extern SettingsCmdCreateCatchmentFromSurface.SettingsCmdSheetFlow SheetFlow { get; }

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001527 RID: 5415
		public extern SettingsCmdCreateCatchmentFromSurface.SettingsCmdShallowConcentratedFlow ShallowConcentratedFlow { get; }

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001528 RID: 5416
		public extern SettingsCmdCreateCatchmentFromSurface.SettingsCmdChannelFlow ChannelFlow { get; }

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001529 RID: 5417
		public extern PropertyEnum<CatchmentTimeOfConcentrationMethodType> TimeOfConcentrationMethod { get; }

		// Token: 0x02000B0C RID: 2828
		public sealed class SettingsCmdCatchment : TreeOidWrapper
		{
			// Token: 0x17000913 RID: 2323
			// (get) Token: 0x0600152A RID: 5418
			public extern PropertyObjectId Style { get; }
		}

		// Token: 0x02000B0D RID: 2829
		public sealed class SettingsCmdHydrologicalProperties : TreeOidWrapper
		{
			// Token: 0x17000914 RID: 2324
			// (get) Token: 0x0600152B RID: 5419
			public extern PropertyDouble RunoffCoefficient { get; }
		}

		// Token: 0x02000B0E RID: 2830
		public sealed class SettingsCmdSheetFlow : TreeOidWrapper
		{
			// Token: 0x17000918 RID: 2328
			// (get) Token: 0x0600152C RID: 5420
			public extern PropertyInt Segments { get; }

			// Token: 0x17000917 RID: 2327
			// (get) Token: 0x0600152D RID: 5421
			public extern PropertyDouble Length { get; }

			// Token: 0x17000916 RID: 2326
			// (get) Token: 0x0600152E RID: 5422
			public extern PropertyDouble ManningCoefficient { get; }

			// Token: 0x17000915 RID: 2325
			// (get) Token: 0x0600152F RID: 5423
			public extern PropertyDouble RainIntensity { get; }
		}

		// Token: 0x02000B0F RID: 2831
		public sealed class SettingsCmdShallowConcentratedFlow : TreeOidWrapper
		{
			// Token: 0x1700091B RID: 2331
			// (get) Token: 0x06001530 RID: 5424
			public extern PropertyInt Segments { get; }

			// Token: 0x1700091A RID: 2330
			// (get) Token: 0x06001531 RID: 5425
			public extern PropertyDouble Length { get; }

			// Token: 0x17000919 RID: 2329
			// (get) Token: 0x06001532 RID: 5426
			public extern PropertyEnum<CatchmentShallowConcentratedFlowSurfaceType> SurfaceType { get; }
		}

		// Token: 0x02000B10 RID: 2832
		public sealed class SettingsCmdChannelFlow : TreeOidWrapper
		{
			// Token: 0x17000920 RID: 2336
			// (get) Token: 0x06001533 RID: 5427
			public extern PropertyInt Segments { get; }

			// Token: 0x1700091F RID: 2335
			// (get) Token: 0x06001534 RID: 5428
			public extern PropertyDouble Length { get; }

			// Token: 0x1700091E RID: 2334
			// (get) Token: 0x06001535 RID: 5429
			public extern PropertyDouble ManningCoefficient { get; }

			// Token: 0x1700091D RID: 2333
			// (get) Token: 0x06001536 RID: 5430
			public extern PropertyDouble CrossSectionalArea { get; }

			// Token: 0x1700091C RID: 2332
			// (get) Token: 0x06001537 RID: 5431
			public extern PropertyDouble WetPerimeter { get; }
		}
	}
}
