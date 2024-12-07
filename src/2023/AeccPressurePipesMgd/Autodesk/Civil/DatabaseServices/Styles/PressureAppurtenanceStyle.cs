using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200000E RID: 14
	[Wrapper("AeccDbAppurtenanceStyle")]
	public sealed class PressureAppurtenanceStyle : StyleBase
	{
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060000F4 RID: 244
		public extern PressureAppurtenanceStylePlanOption PlanOption { get; }

		// Token: 0x060000F5 RID: 245
		public extern DisplayStyle GetDisplayStylePlan();

		// Token: 0x060000F6 RID: 246
		public extern DisplayStyle GetDisplayStyleProfile();

		// Token: 0x060000F7 RID: 247
		public extern DisplayStyle GetDisplayStyleModel();

		// Token: 0x060000F8 RID: 248
		public extern DisplayStyle GetDisplayStyleSection(PressureAppurtenanceDisplayStyleSectionType component);

		// Token: 0x060000F9 RID: 249
		public extern HatchDisplayStyle GetHatchStyleSection();
	}
}
