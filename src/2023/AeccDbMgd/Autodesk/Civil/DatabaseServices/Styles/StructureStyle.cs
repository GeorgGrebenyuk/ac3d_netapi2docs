using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000D0 RID: 208
	[Wrapper("AeccDbStructureStyle")]
	public sealed class StructureStyle : StyleBase
	{
		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060009AE RID: 2478
		public extern StructureStylePlanOption PlanOption { get; }

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060009AF RID: 2479
		public extern StructureStyleProfileOption ProfileOption { get; }

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060009B0 RID: 2480
		public extern StructureStyleModelOption ModelOption { get; }

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060009B1 RID: 2481
		public extern StructureStyleSectionOption SectionOption { get; }

		// Token: 0x060009B2 RID: 2482
		public extern DisplayStyle GetDisplayStylePlan(StructureDisplayStylePlanType component);

		// Token: 0x060009B3 RID: 2483
		public extern DisplayStyle GetDisplayStyleModel();

		// Token: 0x060009B4 RID: 2484
		public extern DisplayStyle GetDisplayStyleProfile(StructureDisplayStyleProfileType component);

		// Token: 0x060009B5 RID: 2485
		public extern DisplayStyle GetDisplayStyleSection(StructureDisplayStyleSectionType component);

		// Token: 0x060009B6 RID: 2486
		public extern HatchDisplayStyle GetHatchStylePlan();

		// Token: 0x060009B7 RID: 2487
		public extern HatchDisplayStyle GetHatchStyleProfile();

		// Token: 0x060009B8 RID: 2488
		public extern HatchDisplayStyle GetHatchStyleSection();
	}
}
