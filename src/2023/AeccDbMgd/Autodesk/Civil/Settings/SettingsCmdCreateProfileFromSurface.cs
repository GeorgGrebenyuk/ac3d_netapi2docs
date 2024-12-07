using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D5C RID: 3420
	public sealed class SettingsCmdCreateProfileFromSurface : SettingsProfile
	{
		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060018A5 RID: 6309
		public extern SettingsCmdCreateProfileFromSurface.SettingsCmdGeometry Geometry { get; }

		// Token: 0x02000D5D RID: 3421
		public sealed class SettingsCmdGeometry : TreeOidWrapper
		{
			// Token: 0x17000B9C RID: 2972
			// (get) Token: 0x060018A6 RID: 6310
			public extern PropertyBoolean ProfileSampleOffsetsCommandSetting { get; }
		}
	}
}
