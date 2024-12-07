using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000B28 RID: 2856
	public sealed class SettingsCmdVolumesDashboard : SettingsSurface
	{
		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x0600155E RID: 5470
		public extern SettingsCmdVolumesDashboard.SettingsCmdVolumeSurfaceCreation VolumeSurfaceCreation { get; }

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x0600155F RID: 5471
		public extern SettingsCmdVolumesDashboard.SettingsCmdBuildOptions BuildOptions { get; }

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001560 RID: 5472
		public extern SettingsCmdVolumesDashboard.SettingsCmdBoundedVolumeCreation BoundedVolumeCreation { get; }

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001561 RID: 5473
		public extern SettingsCmdVolumesDashboard.SettingsCmdDynamicHighlightOptions DynamicHighlightOptions { get; }

		// Token: 0x02000B29 RID: 2857
		public sealed class SettingsCmdVolumeSurfaceCreation : TreeOidWrapper
		{
			// Token: 0x17000951 RID: 2385
			// (get) Token: 0x06001562 RID: 5474
			public extern PropertyEnum<VolumeSurfaceType> DefaultType { get; }

			// Token: 0x17000950 RID: 2384
			// (get) Token: 0x06001563 RID: 5475
			public extern PropertyNameTemplate VolumeSurfaceNameTemplate { get; }

			// Token: 0x1700094F RID: 2383
			// (get) Token: 0x06001564 RID: 5476
			public extern PropertyDouble CutFactor { get; }

			// Token: 0x1700094E RID: 2382
			// (get) Token: 0x06001565 RID: 5477
			public extern PropertyDouble FillFactor { get; }

			// Token: 0x1700094D RID: 2381
			// (get) Token: 0x06001566 RID: 5478
			public extern PropertyDouble GridSurfaceXSpacing { get; }

			// Token: 0x1700094C RID: 2380
			// (get) Token: 0x06001567 RID: 5479
			public extern PropertyDouble GridSurfaceYSpacing { get; }

			// Token: 0x1700094B RID: 2379
			// (get) Token: 0x06001568 RID: 5480
			public extern PropertyDouble GridSurfaceOrientation { get; }
		}

		// Token: 0x02000B2A RID: 2858
		public sealed class SettingsCmdBuildOptions : TreeOidWrapper
		{
			// Token: 0x1700095B RID: 2395
			// (get) Token: 0x06001569 RID: 5481
			public extern PropertyBoolean CopyDeletedDependentObjects { get; }

			// Token: 0x1700095A RID: 2394
			// (get) Token: 0x0600156A RID: 5482
			public extern PropertyBoolean ExcludeElevationsLessThan { get; }

			// Token: 0x17000959 RID: 2393
			// (get) Token: 0x0600156B RID: 5483
			public extern PropertyDouble ElevationLessThan { get; }

			// Token: 0x17000958 RID: 2392
			// (get) Token: 0x0600156C RID: 5484
			public extern PropertyBoolean ExcludeElevationsGreaterThan { get; }

			// Token: 0x17000957 RID: 2391
			// (get) Token: 0x0600156D RID: 5485
			public extern PropertyDouble ElevationGreaterThan { get; }

			// Token: 0x17000956 RID: 2390
			// (get) Token: 0x0600156E RID: 5486
			public extern PropertyBoolean UseMaximumTriangleSideLength { get; }

			// Token: 0x17000955 RID: 2389
			// (get) Token: 0x0600156F RID: 5487
			public extern PropertyDouble MaximumTriangleLength { get; }

			// Token: 0x17000954 RID: 2388
			// (get) Token: 0x06001570 RID: 5488
			public extern PropertyBoolean ConvertProximityBreaklinesToStandard { get; }

			// Token: 0x17000953 RID: 2387
			// (get) Token: 0x06001571 RID: 5489
			public extern PropertyBoolean AllowCrossingBreaklines { get; }

			// Token: 0x17000952 RID: 2386
			// (get) Token: 0x06001572 RID: 5490
			public extern PropertyEnum<CrossingBreaklinesElevationType> ElevationToUse { get; }
		}

		// Token: 0x02000B2B RID: 2859
		public sealed class SettingsCmdBoundedVolumeCreation : TreeOidWrapper
		{
			// Token: 0x1700095C RID: 2396
			// (get) Token: 0x06001573 RID: 5491
			public extern PropertyDouble MidOrdinateDistance { get; }
		}

		// Token: 0x02000B2C RID: 2860
		public sealed class SettingsCmdDynamicHighlightOptions : TreeOidWrapper
		{
			// Token: 0x17000960 RID: 2400
			// (get) Token: 0x06001574 RID: 5492
			public extern PropertyColor SurfaceBorderColor { get; }

			// Token: 0x1700095F RID: 2399
			// (get) Token: 0x06001575 RID: 5493
			public extern PropertyEnum<LineWeight> SurfaceBorderLineweight { get; }

			// Token: 0x1700095E RID: 2398
			// (get) Token: 0x06001576 RID: 5494
			public extern PropertyColor BoundaryPolygonColor { get; }

			// Token: 0x1700095D RID: 2397
			// (get) Token: 0x06001577 RID: 5495
			public extern PropertyEnum<LineWeight> BoundaryPolygonlineweight { get; }
		}
	}
}
