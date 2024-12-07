using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200009F RID: 159
	[Wrapper("AeccDbGraphStyleProfile")]
	public sealed class ProfileViewStyle : StyleBase
	{
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000719 RID: 1817
		public extern GraphStyle GraphStyle { get; }

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600071A RID: 1818
		public extern GridStyle GridStyle { get; }

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600071B RID: 1819
		public extern AxisStyle TopAxis { get; }

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600071C RID: 1820
		public extern AxisStyle BottomAxis { get; }

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600071D RID: 1821
		public extern AxisStyle LeftAxis { get; }

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600071E RID: 1822
		public extern AxisStyle RightAxis { get; }

		// Token: 0x0600071F RID: 1823
		public extern DisplayStyle GetDisplayStylePlan(ProfileViewDisplayStyleType type);
	}
}
