using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D34 RID: 3380
	public sealed class SettingsCmdGradingElevEditor : SettingsGrading
	{
		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06001841 RID: 6209
		public extern SettingsCmdGradingElevEditor.SettingsCmdGradingElevationEditor GradingElevationEditor { get; }

		// Token: 0x02000D35 RID: 3381
		public sealed class SettingsCmdGradingElevationEditor : TreeOidWrapper
		{
			// Token: 0x17000B39 RID: 2873
			// (get) Token: 0x06001842 RID: 6210
			public extern PropertyDouble RaiseLowerIncrement { get; }

			// Token: 0x17000B38 RID: 2872
			// (get) Token: 0x06001843 RID: 6211
			public extern PropertyBoolean ShowGradeBreaksOnly { get; }
		}
	}
}
