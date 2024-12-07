using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D38 RID: 3384
	public sealed class SettingsCmdGradingVolumeTools : SettingsGrading
	{
		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06001849 RID: 6217
		public extern PropertyDouble RaiseLowerElevationIncrement { get; }

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x0600184A RID: 6218
		public extern PropertyBoolean LimitFeatureSelectionToCurrentGroup { get; }
	}
}
