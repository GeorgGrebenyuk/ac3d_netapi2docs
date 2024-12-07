using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x0200107F RID: 4223
	public sealed class SettingsCmdCreateArcByBestFit : Autodesk.Civil.Settings.SettingsGeneral
	{
		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x060021C2 RID: 8642
		public extern SettingsCmdCreateArcByBestFit.SettingsCmdCurveTessellationOption CurveTessellationOption { get; }

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x060021C3 RID: 8643
		public extern SettingsCmdCreateArcByBestFit.SettingsCmdRegressionGraphOption RegressionGraphOption { get; }

		// Token: 0x02001080 RID: 4224
		public sealed class SettingsCmdCurveTessellationOption : TreeOidWrapper
		{
			// Token: 0x17001103 RID: 4355
			// (get) Token: 0x060021C4 RID: 8644
			public extern PropertyBoolean TessellateCurve { get; }

			// Token: 0x17001102 RID: 4354
			// (get) Token: 0x060021C5 RID: 8645
			public extern PropertyDouble MidOrdinateTolerance { get; }
		}

		// Token: 0x02001081 RID: 4225
		public sealed class SettingsCmdRegressionGraphOption : TreeOidWrapper
		{
			// Token: 0x17001104 RID: 4356
			// (get) Token: 0x060021C6 RID: 8646
			public extern PropertyBoolean SplineFitForRegressionAnalysisGraph { get; }
		}
	}
}
