using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200000C RID: 12
	[Wrapper("AeccDbPressurePipeStyle")]
	public sealed class PressurePipeStyle : StyleBase
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060000E5 RID: 229
		public extern PressurePipeStylePlanOption PlanOption { get; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060000E6 RID: 230
		public extern PressurePipeStyleProfileOption ProfileOption { get; }

		// Token: 0x060000E7 RID: 231
		public extern DisplayStyle GetDisplayStylePlan(PressurePipeDisplayStylePlanType component);

		// Token: 0x060000E8 RID: 232
		public extern DisplayStyle GetDisplayStyleModel();

		// Token: 0x060000E9 RID: 233
		public extern DisplayStyle GetDisplayStyleProfile(PressurePipeDisplayStyleProfileType component);

		// Token: 0x060000EA RID: 234
		public extern DisplayStyle GetDisplayStyleSection(PressurePipeDisplayStyleSectionType component);

		// Token: 0x060000EB RID: 235
		public extern HatchDisplayStyle GetHatchStylePlan();

		// Token: 0x060000EC RID: 236
		public extern HatchDisplayStyle GetHatchStyleProfile(PressurePipeHatchStyleProfileType component);

		// Token: 0x060000ED RID: 237
		public extern HatchDisplayStyle GetHatchStyleSection();
	}
}
