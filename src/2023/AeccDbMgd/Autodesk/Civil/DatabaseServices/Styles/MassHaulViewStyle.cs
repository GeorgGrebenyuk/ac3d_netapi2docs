using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000B9 RID: 185
	[Wrapper("AeccDbGraphStyleMassHaulView")]
	public sealed class MassHaulViewStyle : StyleBase
	{
		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000825 RID: 2085
		public extern GraphStyle GraphStyle { get; }

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000826 RID: 2086
		public extern GridStyle GridStyle { get; }

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000827 RID: 2087
		public extern AxisStyle TopAxis { get; }

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000828 RID: 2088
		public extern AxisStyle MiddleAxis { get; }

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000829 RID: 2089
		public extern AxisStyle BottomAxis { get; }

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x0600082A RID: 2090
		public extern AxisStyle LeftAxis { get; }

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x0600082B RID: 2091
		public extern AxisStyle RightAxis { get; }

		// Token: 0x0600082C RID: 2092
		public extern DisplayStyle GetDisplayStylePlan(MassHaulViewDisplayStyleType type);
	}
}
