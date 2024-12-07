using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020001BF RID: 447
	public sealed class SettingsCmdRunDepthCheck : SettingsPressureNetwork
	{
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060001EC RID: 492
		public extern SettingsCmdRunDepthCheck.SettingsCmdDepthCheckOption DepthCheckOption { get; }

		// Token: 0x020001C0 RID: 448
		public sealed class SettingsCmdDepthCheckOption : TreeOidWrapper
		{
			// Token: 0x17000106 RID: 262
			// (get) Token: 0x060001ED RID: 493
			public extern PropertyBoolean UseMinDepthOfCoverValidation { get; }

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x060001EE RID: 494
			public extern PropertyDouble MinimumDepthOfCover { get; }

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x060001EF RID: 495
			public extern PropertyBoolean UseMaxDepthOfCoverValidation { get; }

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x060001F0 RID: 496
			public extern PropertyDouble MaximumDepthOfCover { get; }
		}
	}
}
