using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000FD4 RID: 4052
	public sealed class SettingsCmdCreateInterferenceCheck : SettingsPipeNetwork
	{
		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x0600201E RID: 8222
		public extern SettingsCmdCreateInterferenceCheck.SettingsCmdInterferenceCriteria InterferenceCriteria { get; }

		// Token: 0x02000FD5 RID: 4053
		public sealed class SettingsCmdInterferenceCriteria : TreeOidWrapper
		{
			// Token: 0x17001012 RID: 4114
			// (get) Token: 0x0600201F RID: 8223
			public extern PropertyBoolean Apply3DProximityCheck { get; }

			// Token: 0x17001011 RID: 4113
			// (get) Token: 0x06002020 RID: 8224
			public extern PropertyDouble Distance { get; }

			// Token: 0x17001010 RID: 4112
			// (get) Token: 0x06002021 RID: 8225
			public extern PropertyDouble ScaleFactor { get; }

			// Token: 0x1700100F RID: 4111
			// (get) Token: 0x06002022 RID: 8226
			public extern PropertyEnum<DistanceScaleFactorType> UseDistanceOrScaleFactor { get; }
		}
	}
}
