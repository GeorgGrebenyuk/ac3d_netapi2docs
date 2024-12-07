using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000DE RID: 222
	public sealed class DisplayStyle : CivilWrapper<AeccDbStyle>
	{
		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000A02 RID: 2562
		// (set) Token: 0x06000A03 RID: 2563
		public extern bool Visible { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000A04 RID: 2564
		// (set) Token: 0x06000A05 RID: 2565
		public extern string Layer { get; set; }

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000A06 RID: 2566
		// (set) Token: 0x06000A07 RID: 2567
		public extern string Linetype { get; set; }

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000A08 RID: 2568
		// (set) Token: 0x06000A09 RID: 2569
		public extern LineWeight Lineweight { get; set; }

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000A0A RID: 2570
		// (set) Token: 0x06000A0B RID: 2571
		public extern double LinetypeScale { get; set; }

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000A0C RID: 2572
		// (set) Token: 0x06000A0D RID: 2573
		public extern string PlotStyle { get; set; }

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000A0E RID: 2574
		// (set) Token: 0x06000A0F RID: 2575
		public extern Color Color { get; set; }

		// Token: 0x0400030D RID: 781
		private int <SyntheticNonEmptyStructMarker>;
	}
}
