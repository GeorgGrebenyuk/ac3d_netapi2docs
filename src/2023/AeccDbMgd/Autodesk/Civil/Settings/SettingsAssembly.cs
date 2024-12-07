using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010F4 RID: 4340
	public class SettingsAssembly : SettingsAmbient
	{
		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x0600235D RID: 9053
		public extern SettingsAssembly.SettingsStyles Styles { get; }

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x0600235E RID: 9054
		public extern SettingsAssembly.SettingsNameFormat NameFormat { get; }

		// Token: 0x02001108 RID: 4360
		public sealed class SettingsStyles : TreeOidWrapper
		{
			// Token: 0x17001273 RID: 4723
			// (get) Token: 0x0600238F RID: 9103
			public extern PropertyString Assembly { get; }

			// Token: 0x17001272 RID: 4722
			// (get) Token: 0x06002390 RID: 9104
			public extern PropertyObjectId AssemblyStyleId { get; }

			// Token: 0x17001271 RID: 4721
			// (get) Token: 0x06002391 RID: 9105
			public extern PropertyString CodeSet { get; }

			// Token: 0x17001270 RID: 4720
			// (get) Token: 0x06002392 RID: 9106
			public extern PropertyObjectId CodeSetStyleId { get; }
		}

		// Token: 0x02001109 RID: 4361
		public sealed class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x17001276 RID: 4726
			// (get) Token: 0x06002393 RID: 9107
			public extern PropertyString Assembly { get; }

			// Token: 0x17001275 RID: 4725
			// (get) Token: 0x06002394 RID: 9108
			public extern PropertyString Offset { get; }

			// Token: 0x17001274 RID: 4724
			// (get) Token: 0x06002395 RID: 9109
			public extern PropertyString Group { get; }
		}
	}
}
