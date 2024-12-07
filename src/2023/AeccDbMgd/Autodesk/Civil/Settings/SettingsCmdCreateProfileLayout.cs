using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D5E RID: 3422
	public sealed class SettingsCmdCreateProfileLayout : SettingsProfile
	{
		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x060018A7 RID: 6311
		public extern SettingsCmdCreateProfileLayout.SettingsCmdCurveTessellationOption CurveTessellationOption { get; }

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060018A8 RID: 6312
		public extern SettingsCmdCreateProfileLayout.SettingsCmdRegressionGraphOption RegressionGraphOption { get; }

		// Token: 0x02000D5F RID: 3423
		public sealed class SettingsCmdCurveTessellationOption : TreeOidWrapper
		{
			// Token: 0x17000BA0 RID: 2976
			// (get) Token: 0x060018A9 RID: 6313
			public extern PropertyBoolean TessellateCurve { get; }

			// Token: 0x17000B9F RID: 2975
			// (get) Token: 0x060018AA RID: 6314
			public extern PropertyDouble MidOrdinateTolerance { get; }
		}

		// Token: 0x02000D60 RID: 3424
		public sealed class SettingsCmdRegressionGraphOption : TreeOidWrapper
		{
			// Token: 0x17000BA1 RID: 2977
			// (get) Token: 0x060018AB RID: 6315
			public extern PropertyBoolean SplineFitForRegressionAnalysisGraph { get; }
		}
	}
}
