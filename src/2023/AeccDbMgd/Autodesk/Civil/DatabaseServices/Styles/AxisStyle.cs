using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F5A RID: 3930
	public sealed class AxisStyle : CivilWrapper<AeccDbGraphStyle>
	{
		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06001DC5 RID: 7621
		// (set) Token: 0x06001DC6 RID: 7622
		public extern bool ShowTickAndLabel { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06001DC7 RID: 7623
		public extern AxisTitleStyle TitleStyle { get; }

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06001DC8 RID: 7624
		public extern AxisTickStyle MajorTickStyle { get; }

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06001DC9 RID: 7625
		public extern AxisTickStyle MinorTickStyle { get; }

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06001DCA RID: 7626
		public extern AxisTickStyle HorizontalGeometryTickStyle { get; }

		// Token: 0x04001837 RID: 6199
		private int <SyntheticNonEmptyStructMarker>;
	}
}
