using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D36 RID: 3382
	public sealed class SettingsCmdGradingTools : SettingsGrading
	{
		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06001844 RID: 6212
		public extern SettingsCmdGradingTools.SettingsCmdGradingLayoutTools GradingLayoutTools { get; }

		// Token: 0x02000D37 RID: 3383
		public sealed class SettingsCmdGradingLayoutTools : TreeOidWrapper
		{
			// Token: 0x17000B3E RID: 2878
			// (get) Token: 0x06001845 RID: 6213
			public extern PropertyString GradingCriteriaSet { get; }

			// Token: 0x17000B3D RID: 2877
			// (get) Token: 0x06001846 RID: 6214
			public extern PropertyObjectId GradingCriteriaSetId { get; }

			// Token: 0x17000B3C RID: 2876
			// (get) Token: 0x06001847 RID: 6215
			public extern PropertyString Criteria { get; }

			// Token: 0x17000B3B RID: 2875
			// (get) Token: 0x06001848 RID: 6216
			public extern PropertyObjectId CriteriaId { get; }
		}
	}
}
