using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000A2 RID: 162
	[Wrapper("AeccDbGraphStyleCrossSection")]
	public sealed class SectionViewStyle : StyleBase
	{
		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000723 RID: 1827
		public extern GraphStyle GraphStyle { get; }

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000724 RID: 1828
		public extern GridStyle GridStyle { get; }

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000725 RID: 1829
		public extern AxisStyle TopAxis { get; }

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000726 RID: 1830
		public extern AxisStyle BottomAxis { get; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000727 RID: 1831
		public extern AxisStyle LeftAxis { get; }

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000728 RID: 1832
		public extern AxisStyle CenterAxis { get; }

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000729 RID: 1833
		public extern AxisStyle RightAxis { get; }

		// Token: 0x0600072A RID: 1834
		public extern DisplayStyle GetDisplayStylePlan(SectionViewDisplayStyleType type);
	}
}
