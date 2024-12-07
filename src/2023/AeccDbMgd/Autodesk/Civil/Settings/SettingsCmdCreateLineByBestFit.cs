using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02001082 RID: 4226
	public sealed class SettingsCmdCreateLineByBestFit : Autodesk.Civil.Settings.SettingsGeneral
	{
		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x060021C7 RID: 8647
		public extern SettingsCmdCreateLineByBestFit.SettingsCmdCurveTessellationOption CurveTessellationOption { get; }

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x060021C8 RID: 8648
		public extern SettingsCmdCreateLineByBestFit.SettingsCmdRegressionGraphOption RegressionGraphOption { get; }

		// Token: 0x02001083 RID: 4227
		public sealed class SettingsCmdCurveTessellationOption : TreeOidWrapper
		{
			// Token: 0x17001108 RID: 4360
			// (get) Token: 0x060021C9 RID: 8649
			public extern PropertyBoolean TessellateCurve { get; }

			// Token: 0x17001107 RID: 4359
			// (get) Token: 0x060021CA RID: 8650
			public extern PropertyDouble MidOrdinateTolerance { get; }
		}

		// Token: 0x02001084 RID: 4228
		public sealed class SettingsCmdRegressionGraphOption : TreeOidWrapper
		{
			// Token: 0x17001109 RID: 4361
			// (get) Token: 0x060021CB RID: 8651
			public extern PropertyBoolean SplineFitForRegressionAnalysisGraph { get; }
		}
	}
}
