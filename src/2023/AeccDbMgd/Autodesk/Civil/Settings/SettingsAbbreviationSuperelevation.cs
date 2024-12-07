using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010B0 RID: 4272
	public sealed class SettingsAbbreviationSuperelevation : TreeOidWrapper
	{
		// Token: 0x0600226F RID: 8815
		public extern string GetSuperelevationAbbreviation(AbbreviationSuperelevationType type);

		// Token: 0x06002270 RID: 8816
		public extern void SetSuperelevationAbbreviation(AbbreviationSuperelevationType type, string newValue);
	}
}
