using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D64 RID: 3428
	public sealed class SettingsCmdSuperimposeProfile : SettingsProfile
	{
		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x060018AF RID: 6319
		public extern SettingsCmdSuperimposeProfile.SettingsCmdSuperimposeProfileOption SuperimposeProfile { get; }

		// Token: 0x02000D65 RID: 3429
		public sealed class SettingsCmdSuperimposeProfileOption : TreeOidWrapper
		{
			// Token: 0x17000BA7 RID: 2983
			// (get) Token: 0x060018B0 RID: 6320
			public extern PropertyDouble HorizontalMidOrdinateDistance { get; }

			// Token: 0x17000BA6 RID: 2982
			// (get) Token: 0x060018B1 RID: 6321
			public extern PropertyDouble VerticalMidOrdinateDistance { get; }
		}
	}
}
