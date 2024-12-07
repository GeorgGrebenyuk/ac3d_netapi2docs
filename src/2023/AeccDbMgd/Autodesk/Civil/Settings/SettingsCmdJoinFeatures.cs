using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D39 RID: 3385
	public sealed class SettingsCmdJoinFeatures : SettingsGrading
	{
		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x0600184B RID: 6219
		public extern SettingsCmdJoinFeatures.SettingsCmdFeatureLineJoin FeatureLineJoin { get; }

		// Token: 0x02000D3A RID: 3386
		public sealed class SettingsCmdFeatureLineJoin : TreeOidWrapper
		{
			// Token: 0x17000B42 RID: 2882
			// (get) Token: 0x0600184C RID: 6220
			public extern PropertyDouble Tolerance { get; }
		}
	}
}
