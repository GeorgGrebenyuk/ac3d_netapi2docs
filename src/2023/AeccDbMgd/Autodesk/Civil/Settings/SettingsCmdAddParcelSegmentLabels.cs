using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D0E RID: 3342
	public sealed class SettingsCmdAddParcelSegmentLabels : SettingsParcel
	{
		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x060017D6 RID: 6102
		public extern SettingsCmdAddParcelSegmentLabels.SettingsCmdOptions Options { get; }

		// Token: 0x02000D0F RID: 3343
		public sealed class SettingsCmdOptions : TreeOidWrapper
		{
			// Token: 0x17000ACD RID: 2765
			// (get) Token: 0x060017D7 RID: 6103
			public extern PropertyEnum<RotationDirType> LabelingDirection { get; }
		}
	}
}
