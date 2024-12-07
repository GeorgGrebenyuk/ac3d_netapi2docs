using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000B1C RID: 2844
	public sealed class SettingsCmdAddPointsToSurface : SettingsPointCloud
	{
		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001549 RID: 5449
		public extern PropertyEnum<PointCloudSurfaceType> SurfaceOption { get; }

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x0600154A RID: 5450
		public extern PropertyEnum<PointCloudRegionType> RegionOption { get; }

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x0600154B RID: 5451
		public extern PropertyDouble MidOrdinateDistance { get; }
	}
}
