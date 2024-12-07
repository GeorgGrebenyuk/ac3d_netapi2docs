using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000B1D RID: 2845
	public sealed class SettingsCmdCreatePointCloud : SettingsPointCloud
	{
		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x0600154C RID: 5452
		public extern PropertyEnum<PointCloudDefaultFileExtensionType> FileFormat { get; }

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x0600154D RID: 5453
		public extern SettingsCmdCreatePointCloud.SettingsCmdDefaultLayer DefaultLayer { get; }

		// Token: 0x02000B1E RID: 2846
		public sealed class SettingsCmdDefaultLayer : TreeOidWrapper
		{
			// Token: 0x17000937 RID: 2359
			// (get) Token: 0x0600154E RID: 5454
			public extern PropertyLayer LayerName { get; }
		}
	}
}
