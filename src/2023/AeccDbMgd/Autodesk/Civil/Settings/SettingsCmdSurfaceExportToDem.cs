using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D04 RID: 3332
	public sealed class SettingsCmdSurfaceExportToDem : SettingsSurface
	{
		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x060017C1 RID: 6081
		public extern SettingsCmdSurfaceExportToDem.SettingsCmdExportOptions ExportOptions { get; }

		// Token: 0x02000D05 RID: 3333
		public sealed class SettingsCmdExportOptions : TreeOidWrapper
		{
			// Token: 0x17000ABA RID: 2746
			// (get) Token: 0x060017C2 RID: 6082
			public extern PropertyBoolean UseCustomNullElevation { get; }

			// Token: 0x17000AB9 RID: 2745
			// (get) Token: 0x060017C3 RID: 6083
			public extern PropertyDouble NullElevation { get; }

			// Token: 0x17000AB8 RID: 2744
			// (get) Token: 0x060017C4 RID: 6084
			public extern PropertyDouble GridSpacing { get; }
		}
	}
}
