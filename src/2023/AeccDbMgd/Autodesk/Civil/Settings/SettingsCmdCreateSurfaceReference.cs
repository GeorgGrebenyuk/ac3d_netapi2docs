using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CFB RID: 3323
	public sealed class SettingsCmdCreateSurfaceReference : SettingsSurface
	{
		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060017B2 RID: 6066
		public extern SettingsCmdCreateSurfaceReference.SettingsNameFormat NameFormat { get; }

		// Token: 0x02000CFC RID: 3324
		public sealed class SettingsNameFormat : TreeOidWrapper
		{
			// Token: 0x17000AA9 RID: 2729
			// (get) Token: 0x060017B3 RID: 6067
			public extern PropertyString Surface { get; }
		}
	}
}
