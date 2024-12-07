using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D2C RID: 3372
	public sealed class SettingsCmdCreateGrading : SettingsGrading
	{
		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06001831 RID: 6193
		public extern SettingsCmdCreateGrading.SettingsCmdGradingCreation GradingCreation { get; }

		// Token: 0x02000D2D RID: 3373
		public sealed class SettingsCmdGradingCreation : TreeOidWrapper
		{
			// Token: 0x17000B28 RID: 2856
			// (get) Token: 0x06001832 RID: 6194
			public extern PropertyDouble TransitionRegionLength { get; }
		}
	}
}
