using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CEC RID: 3308
	public sealed class SettingsCmdAddSurfaceDemFile : SettingsSurface
	{
		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001789 RID: 6025
		public extern SettingsCmdAddSurfaceDemFile.SettingsCmdImportOptions ImportOptions { get; }

		// Token: 0x02000CED RID: 3309
		public sealed class SettingsCmdImportOptions : TreeOidWrapper
		{
			// Token: 0x17000A81 RID: 2689
			// (get) Token: 0x0600178A RID: 6026
			public extern PropertyBoolean UseCustomNullElevation { get; }

			// Token: 0x17000A80 RID: 2688
			// (get) Token: 0x0600178B RID: 6027
			public extern PropertyDouble NullElevation { get; }
		}
	}
}
