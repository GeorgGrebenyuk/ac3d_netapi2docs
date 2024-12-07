using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000D1 RID: 209
	[Wrapper("AeccDbInterferenceStyle")]
	public sealed class InterferenceStyle : StyleBase
	{
		// Token: 0x060009B9 RID: 2489
		public extern DisplayStyle GetDisplayStylePlan(InterferenceDisplayStyleType component);

		// Token: 0x060009BA RID: 2490
		public extern DisplayStyle GetDisplayStyleModel(InterferenceDisplayStyleType component);

		// Token: 0x060009BB RID: 2491
		public extern DisplayStyle GetDisplayStyleSection(InterferenceDisplayStyleType component);

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060009BC RID: 2492
		// (set) Token: 0x060009BD RID: 2493
		public extern ObjectId MarkerStyle { get; set; }

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060009BE RID: 2494
		// (set) Token: 0x060009BF RID: 2495
		public extern InterferenceModelType ModelOptions { get; set; }

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060009C0 RID: 2496
		// (set) Token: 0x060009C1 RID: 2497
		public extern InterferenceModelSizeType ModelSizeType { get; set; }

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060009C2 RID: 2498
		// (set) Token: 0x060009C3 RID: 2499
		public extern InterferenceModelSizeOptionType ModelSizeOptions { get; set; }

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060009C4 RID: 2500
		// (set) Token: 0x060009C5 RID: 2501
		public extern double AbsoluteModelSize { get; set; }

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060009C6 RID: 2502
		// (set) Token: 0x060009C7 RID: 2503
		public extern double DrawingScaleModelSize { get; set; }
	}
}
