using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000CF RID: 207
	[Wrapper("AeccDbPipeStyle")]
	public sealed class PipeStyle : StyleBase
	{
		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060009A3 RID: 2467
		public extern PipeStylePlanOption PlanOption { get; }

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060009A4 RID: 2468
		public extern PipeStyleProfileOption ProfileOption { get; }

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060009A5 RID: 2469
		// (set) Token: 0x060009A6 RID: 2470
		public extern PipeHatchType SectionCrossingHatch { get; set; }

		// Token: 0x060009A7 RID: 2471
		public extern DisplayStyle GetDisplayStylePlan(PipeDisplayStylePlanType component);

		// Token: 0x060009A8 RID: 2472
		public extern DisplayStyle GetDisplayStyleModel();

		// Token: 0x060009A9 RID: 2473
		public extern DisplayStyle GetDisplayStyleProfile(PipeDisplayStyleProfileType component);

		// Token: 0x060009AA RID: 2474
		public extern DisplayStyle GetDisplayStyleSection(PipeDisplayStyleSectionType component);

		// Token: 0x060009AB RID: 2475
		public extern HatchDisplayStyle GetHatchStylePlan();

		// Token: 0x060009AC RID: 2476
		public extern HatchDisplayStyle GetHatchStyleProfile(PipeHatchStyleProfileType component);

		// Token: 0x060009AD RID: 2477
		public extern HatchDisplayStyle GetHatchStyleSection();
	}
}
