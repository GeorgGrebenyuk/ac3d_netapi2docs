using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200000D RID: 13
	[Wrapper("AeccDbFittingStyle")]
	public sealed class PressureFittingStyle : StyleBase
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060000EE RID: 238
		public extern PressureFittingStylePlanOption PlanOption { get; }

		// Token: 0x060000EF RID: 239
		public extern DisplayStyle GetDisplayStylePlan();

		// Token: 0x060000F0 RID: 240
		public extern DisplayStyle GetDisplayStyleProfile();

		// Token: 0x060000F1 RID: 241
		public extern DisplayStyle GetDisplayStyleModel();

		// Token: 0x060000F2 RID: 242
		public extern DisplayStyle GetDisplayStyleSection(PressureFittingDisplayStyleSectionType component);

		// Token: 0x060000F3 RID: 243
		public extern HatchDisplayStyle GetHatchStyleSection();
	}
}
