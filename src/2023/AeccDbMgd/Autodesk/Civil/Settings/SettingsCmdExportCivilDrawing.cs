using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000BF4 RID: 3060
	public sealed class SettingsCmdExportCivilDrawing : Autodesk.Civil.Settings.SettingsGeneral
	{
		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001722 RID: 5922
		public extern SettingsCmdExportCivilDrawing.SettingsCmdExportCivilDrawingOption ExportCivilDrawingOption { get; }

		// Token: 0x02000BF5 RID: 3061
		public sealed class SettingsCmdExportCivilDrawingOption : TreeOidWrapper
		{
			// Token: 0x17000A1E RID: 2590
			// (get) Token: 0x06001723 RID: 5923
			public extern PropertyBoolean ExportFeatureLineAs2D { get; }
		}
	}
}
