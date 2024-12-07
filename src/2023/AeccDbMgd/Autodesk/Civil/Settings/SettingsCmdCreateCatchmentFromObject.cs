using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000B05 RID: 2821
	public sealed class SettingsCmdCreateCatchmentFromObject : SettingsCatchment
	{
		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001510 RID: 5392
		public extern SettingsCmdCreateCatchmentFromObject.SettingsCmdCatchment Catchment { get; }

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001511 RID: 5393
		public extern SettingsCmdCreateCatchmentFromObject.SettingsCmdHydrologicalProperties HydrologicalProperties { get; }

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001512 RID: 5394
		public extern SettingsCmdCreateCatchmentFromObject.SettingsCmdSheetFlow SheetFlow { get; }

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001513 RID: 5395
		public extern SettingsCmdCreateCatchmentFromObject.SettingsCmdShallowConcentratedFlow ShallowConcentratedFlow { get; }

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001514 RID: 5396
		public extern SettingsCmdCreateCatchmentFromObject.SettingsCmdChannelFlow ChannelFlow { get; }

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001515 RID: 5397
		public extern PropertyEnum<CatchmentTimeOfConcentrationMethodType> TimeOfConcentrationMethod { get; }

		// Token: 0x02000B06 RID: 2822
		public sealed class SettingsCmdCatchment : TreeOidWrapper
		{
			// Token: 0x170008FF RID: 2303
			// (get) Token: 0x06001516 RID: 5398
			public extern PropertyObjectId Style { get; }
		}

		// Token: 0x02000B07 RID: 2823
		public sealed class SettingsCmdHydrologicalProperties : TreeOidWrapper
		{
			// Token: 0x17000900 RID: 2304
			// (get) Token: 0x06001517 RID: 5399
			public extern PropertyDouble RunoffCoefficient { get; }
		}

		// Token: 0x02000B08 RID: 2824
		public sealed class SettingsCmdSheetFlow : TreeOidWrapper
		{
			// Token: 0x17000904 RID: 2308
			// (get) Token: 0x06001518 RID: 5400
			public extern PropertyInt Segments { get; }

			// Token: 0x17000903 RID: 2307
			// (get) Token: 0x06001519 RID: 5401
			public extern PropertyDouble Length { get; }

			// Token: 0x17000902 RID: 2306
			// (get) Token: 0x0600151A RID: 5402
			public extern PropertyDouble ManningCoefficient { get; }

			// Token: 0x17000901 RID: 2305
			// (get) Token: 0x0600151B RID: 5403
			public extern PropertyDouble RainIntensity { get; }
		}

		// Token: 0x02000B09 RID: 2825
		public sealed class SettingsCmdShallowConcentratedFlow : TreeOidWrapper
		{
			// Token: 0x17000907 RID: 2311
			// (get) Token: 0x0600151C RID: 5404
			public extern PropertyInt Segments { get; }

			// Token: 0x17000906 RID: 2310
			// (get) Token: 0x0600151D RID: 5405
			public extern PropertyDouble Length { get; }

			// Token: 0x17000905 RID: 2309
			// (get) Token: 0x0600151E RID: 5406
			public extern PropertyEnum<CatchmentShallowConcentratedFlowSurfaceType> SurfaceType { get; }
		}

		// Token: 0x02000B0A RID: 2826
		public sealed class SettingsCmdChannelFlow : TreeOidWrapper
		{
			// Token: 0x1700090C RID: 2316
			// (get) Token: 0x0600151F RID: 5407
			public extern PropertyInt Segments { get; }

			// Token: 0x1700090B RID: 2315
			// (get) Token: 0x06001520 RID: 5408
			public extern PropertyDouble Length { get; }

			// Token: 0x1700090A RID: 2314
			// (get) Token: 0x06001521 RID: 5409
			public extern PropertyDouble ManningCoefficient { get; }

			// Token: 0x17000909 RID: 2313
			// (get) Token: 0x06001522 RID: 5410
			public extern PropertyDouble CrossSectionalArea { get; }

			// Token: 0x17000908 RID: 2312
			// (get) Token: 0x06001523 RID: 5411
			public extern PropertyDouble WetPerimeter { get; }
		}
	}
}
