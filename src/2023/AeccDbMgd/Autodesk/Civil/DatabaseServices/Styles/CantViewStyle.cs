using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000E1 RID: 225
	[Wrapper("AeccDbGraphStyleCant")]
	public sealed class CantViewStyle : StyleBase
	{
		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000A23 RID: 2595
		// (set) Token: 0x06000A24 RID: 2596
		public extern double VerticalExaggeration { get; set; }

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000A25 RID: 2597
		// (set) Token: 0x06000A26 RID: 2598
		public extern double AxisTopMajorTickInterval { get; set; }

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000A27 RID: 2599
		// (set) Token: 0x06000A28 RID: 2600
		public extern double AxisBottomMajorTickInterval { get; set; }

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000A29 RID: 2601
		// (set) Token: 0x06000A2A RID: 2602
		public extern bool UseFullHeightTick { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000A2B RID: 2603
		// (set) Token: 0x06000A2C RID: 2604
		public extern bool UseSmallTicksAtTop { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000A2D RID: 2605
		// (set) Token: 0x06000A2E RID: 2606
		public extern bool UseSmallTicksAtMiddle { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000A2F RID: 2607
		// (set) Token: 0x06000A30 RID: 2608
		public extern bool UseSmallTicksAtBottom { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000A31 RID: 2609
		public extern DisplayStyle GetDisplayStylePlan(CantViewDisplayStyleType type);
	}
}
