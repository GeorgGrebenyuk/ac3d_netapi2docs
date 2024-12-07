using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020010AE RID: 4270
	public sealed class SettingsAbbreviationAlignmentEnhanced : TreeOidWrapper
	{
		// Token: 0x0600226B RID: 8811
		public extern string GetAlignmentEnhancedAbbreviation(AbbreviationAlignmentEnhancedType type);

		// Token: 0x0600226C RID: 8812
		public extern void SetAlignmentEnhancedAbbreviation(AbbreviationAlignmentEnhancedType type, string newValue);
	}
}
