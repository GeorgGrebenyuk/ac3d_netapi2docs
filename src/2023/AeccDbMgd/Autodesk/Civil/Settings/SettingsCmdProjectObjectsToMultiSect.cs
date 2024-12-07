using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D83 RID: 3459
	public sealed class SettingsCmdProjectObjectsToMultiSect : SettingsSectionView
	{
		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x060018FC RID: 6396
		public extern SettingsCmdProjectObjectsToMultiSect.SettingsCmdObjectSelectionOptions ObjectSelectionOptions { get; }

		// Token: 0x02000D84 RID: 3460
		public sealed class SettingsCmdObjectSelectionOptions : TreeOidWrapper
		{
			// Token: 0x17000BF7 RID: 3063
			// (get) Token: 0x060018FD RID: 6397
			public extern PropertyEnum<ProjecitonRule> ProjecitonRuleType { get; }

			// Token: 0x17000BF6 RID: 3062
			// (get) Token: 0x060018FE RID: 6398
			public extern PropertyEnum<ProjecitonPercentageType> PercentageBeforeCurrentSampleLine { get; }

			// Token: 0x17000BF5 RID: 3061
			// (get) Token: 0x060018FF RID: 6399
			public extern PropertyEnum<ProjecitonPercentageType> PercentageAfterCurrentSampleLine { get; }

			// Token: 0x17000BF4 RID: 3060
			// (get) Token: 0x06001900 RID: 6400
			public extern PropertyDouble DistanceBeforeCurrentSampleLine { get; }

			// Token: 0x17000BF3 RID: 3059
			// (get) Token: 0x06001901 RID: 6401
			public extern PropertyDouble DistanceAfterCurrentSampleLine { get; }
		}
	}
}
