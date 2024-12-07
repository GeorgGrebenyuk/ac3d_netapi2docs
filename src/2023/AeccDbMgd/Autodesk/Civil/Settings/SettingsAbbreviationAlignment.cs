using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010AD RID: 4269
	public sealed class SettingsAbbreviationAlignment : TreeOidWrapper
	{
		// Token: 0x06002269 RID: 8809
		public extern string GetAlignmentAbbreviation(AbbreviationAlignmentType type);

		// Token: 0x0600226A RID: 8810
		public extern void SetAlignmentAbbreviation(AbbreviationAlignmentType type, string value);
	}
}
