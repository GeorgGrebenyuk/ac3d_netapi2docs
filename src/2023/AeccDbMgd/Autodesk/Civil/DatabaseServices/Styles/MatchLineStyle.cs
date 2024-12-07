using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200009B RID: 155
	[Wrapper("AeccDbMatchLineStyle")]
	public sealed class MatchLineStyle : StyleBase
	{
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060006D6 RID: 1750
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.MatchLineStyle.GetLinesDisplayStylePlan instead.", false)]
		public extern DisplayStyle LinesDisplayStylePlan { get; }

		// Token: 0x060006D7 RID: 1751
		public extern DisplayStyle GetLinesDisplayStylePlan();

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060006D8 RID: 1752
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.MatchLineStyle.GetMatchLineMaskDisplayStylePlan instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle MatchLineMaskDisplayStylePlan { get; }

		// Token: 0x060006D9 RID: 1753
		public extern DisplayStyle GetMatchLineMaskDisplayStylePlan();

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060006DA RID: 1754
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.MatchLineStyle.GetMatchLineMaskHatchDisplayStyle instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern HatchDisplayStyle MatchLineMaskHatchDisplayStyle { get; }

		// Token: 0x060006DB RID: 1755
		public extern HatchDisplayStyle GetMatchLineMaskHatchDisplayStyle();
	}
}
