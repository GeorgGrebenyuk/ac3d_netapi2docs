using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010AF RID: 4271
	public sealed class SettingsAbbreviationProfile : TreeOidWrapper
	{
		// Token: 0x0600226D RID: 8813
		public extern string GetProfileAbbreviation(AbbreviationProfileType type);

		// Token: 0x0600226E RID: 8814
		public extern void SetProfileAbbreviation(AbbreviationProfileType type, string newValue);
	}
}
