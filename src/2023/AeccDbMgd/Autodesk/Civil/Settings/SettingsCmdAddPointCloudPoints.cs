using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000B1B RID: 2843
	public sealed class SettingsCmdAddPointCloudPoints : SettingsPointCloud
	{
		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001548 RID: 5448
		public extern PropertyEnum<PointCloudDefaultFileExtensionType> DefaultFileFormat { get; }
	}
}
