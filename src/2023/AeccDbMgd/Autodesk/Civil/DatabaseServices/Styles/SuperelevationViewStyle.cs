using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000E0 RID: 224
	[Wrapper("AeccDbGraphStyleSuperelevation")]
	public sealed class SuperelevationViewStyle : StyleBase
	{
		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000A14 RID: 2580
		// (set) Token: 0x06000A15 RID: 2581
		public extern double VerticalUnitHeight { get; set; }

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000A16 RID: 2582
		// (set) Token: 0x06000A17 RID: 2583
		public extern double AxisTopMajorTickInterval { get; set; }

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000A18 RID: 2584
		// (set) Token: 0x06000A19 RID: 2585
		public extern double AxisBottomMajorTickInterval { get; set; }

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000A1A RID: 2586
		// (set) Token: 0x06000A1B RID: 2587
		public extern bool UseFullHeightTick { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000A1C RID: 2588
		// (set) Token: 0x06000A1D RID: 2589
		public extern bool UseSmallTicksAtTop { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000A1E RID: 2590
		// (set) Token: 0x06000A1F RID: 2591
		public extern bool UseSmallTicksAtMiddle { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000A20 RID: 2592
		// (set) Token: 0x06000A21 RID: 2593
		public extern bool UseSmallTicksAtBottom { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000A22 RID: 2594
		public extern DisplayStyle GetDisplayStylePlan(SuperElevationViewDisplayStyleType type);
	}
}
