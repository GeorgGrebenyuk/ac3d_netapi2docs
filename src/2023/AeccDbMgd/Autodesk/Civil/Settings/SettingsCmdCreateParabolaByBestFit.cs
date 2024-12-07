using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02001085 RID: 4229
	public sealed class SettingsCmdCreateParabolaByBestFit : Autodesk.Civil.Settings.SettingsGeneral
	{
		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x060021CC RID: 8652
		public extern SettingsCmdCreateParabolaByBestFit.SettingsCmdCurveTessellationOption CurveTessellationOption { get; }

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x060021CD RID: 8653
		public extern SettingsCmdCreateParabolaByBestFit.SettingsCmdRegressionGraphOption RegressionGraphOption { get; }

		// Token: 0x02001086 RID: 4230
		public sealed class SettingsCmdCurveTessellationOption : TreeOidWrapper
		{
			// Token: 0x1700110D RID: 4365
			// (get) Token: 0x060021CE RID: 8654
			public extern PropertyBoolean TessellateCurve { get; }

			// Token: 0x1700110C RID: 4364
			// (get) Token: 0x060021CF RID: 8655
			public extern PropertyDouble MidOrdinateTolerance { get; }
		}

		// Token: 0x02001087 RID: 4231
		public sealed class SettingsCmdRegressionGraphOption : TreeOidWrapper
		{
			// Token: 0x1700110E RID: 4366
			// (get) Token: 0x060021D0 RID: 8656
			public extern PropertyBoolean SplineFitForRegressionAnalysisGraph { get; }
		}
	}
}
