using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D32 RID: 3378
	public sealed class SettingsCmdFitCurveFeature : SettingsGrading
	{
		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x0600183E RID: 6206
		public extern SettingsCmdFitCurveFeature.SettingsCmdFeatureLineFitCurve FeatureLineFitCurve { get; }

		// Token: 0x02000D33 RID: 3379
		public sealed class SettingsCmdFeatureLineFitCurve : TreeOidWrapper
		{
			// Token: 0x17000B36 RID: 2870
			// (get) Token: 0x0600183F RID: 6207
			public extern PropertyDouble Tolerance { get; }

			// Token: 0x17000B35 RID: 2869
			// (get) Token: 0x06001840 RID: 6208
			public extern PropertyInt MinimumNumberOfSegments { get; }
		}
	}
}
