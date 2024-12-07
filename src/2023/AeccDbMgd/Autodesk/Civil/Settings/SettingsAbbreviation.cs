using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010AB RID: 4267
	public sealed class SettingsAbbreviation : CivilWrapper<AcDbDatabase>
	{
		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x0600225D RID: 8797
		public extern SettingsAbbreviationGeneral GeneralText { get; }

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x0600225E RID: 8798
		public extern SettingsAbbreviationAlignment AlignmentGeoPointText { get; }

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x0600225F RID: 8799
		public extern SettingsAbbreviationAlignmentEnhanced AlignmentGeoPointEntityData { get; }

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06002260 RID: 8800
		public extern SettingsAbbreviationProfile Profile { get; }

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06002261 RID: 8801
		public extern SettingsAbbreviationCant Cant { get; }

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06002262 RID: 8802
		public extern SettingsAbbreviationSuperelevation Superelevation { get; }
	}
}
