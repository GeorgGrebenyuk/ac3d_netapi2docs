using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D23 RID: 3363
	public sealed class SettingsCmdExportParcelAnalysis : SettingsParcel
	{
		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x0600181A RID: 6170
		public extern SettingsCmdExportParcelAnalysis.SettingsCmdParcelAnalysis ParcelAnalysis { get; }

		// Token: 0x02000D24 RID: 3364
		public sealed class SettingsCmdParcelAnalysis : TreeOidWrapper
		{
			// Token: 0x17000B13 RID: 2835
			// (get) Token: 0x0600181B RID: 6171
			public extern PropertyEnum<ParcelAnalysisType> AnalysisType { get; }

			// Token: 0x17000B12 RID: 2834
			// (get) Token: 0x0600181C RID: 6172
			public extern PropertyBoolean EnableMapcheckAcrossChord { get; }

			// Token: 0x17000B11 RID: 2833
			// (get) Token: 0x0600181D RID: 6173
			public extern PropertyBoolean ProcessCounterClockwise { get; }
		}
	}
}
