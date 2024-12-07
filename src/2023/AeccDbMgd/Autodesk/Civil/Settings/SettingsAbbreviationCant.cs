using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000BF9 RID: 3065
	public sealed class SettingsAbbreviationCant : TreeOidWrapper
	{
		// Token: 0x0600172F RID: 5935
		public extern string GetCantAbbreviation(AbbreviationCantType type);

		// Token: 0x06001730 RID: 5936
		public extern void SetCantAbbreviation(AbbreviationCantType type, string newValue);
	}
}
