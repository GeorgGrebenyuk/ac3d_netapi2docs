using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000B1A RID: 2842
	public class SettingsPointCloud : SettingsAmbient
	{
		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001546 RID: 5446
		public extern SettingsPointCloud.SettingsStyles StyleSettings { get; }

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001547 RID: 5447
		public extern SettingsPointCloud.SettingsDefaultNameFormat DefaultNameFormat { get; }

		// Token: 0x02000B1F RID: 2847
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17000939 RID: 2361
			// (get) Token: 0x0600154F RID: 5455
			public extern PropertyString PointCloudStyle { get; }

			// Token: 0x17000938 RID: 2360
			// (get) Token: 0x06001550 RID: 5456
			public extern PropertyObjectId PointCloudStyleId { get; }
		}

		// Token: 0x02000B20 RID: 2848
		public sealed class SettingsDefaultNameFormat : TreeOidWrapper
		{
			// Token: 0x1700093A RID: 2362
			// (get) Token: 0x06001551 RID: 5457
			public extern PropertyString PointCloudNameTemplate { get; }
		}
	}
}
