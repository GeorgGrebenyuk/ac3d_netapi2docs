using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200129C RID: 4764
	public sealed class GraphTitleStyle : CivilWrapper<AeccDbGraphStyle>
	{
		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x060029D1 RID: 10705
		// (set) Token: 0x060029D2 RID: 10706
		public extern string Text { get; set; }

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x060029D3 RID: 10707
		// (set) Token: 0x060029D4 RID: 10708
		public extern string TextStyle { get; set; }

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x060029D5 RID: 10709
		// (set) Token: 0x060029D6 RID: 10710
		public extern double TextHeight { get; set; }

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x060029D7 RID: 10711
		// (set) Token: 0x060029D8 RID: 10712
		public extern GraphTitleLocationType Location { get; set; }

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x060029D9 RID: 10713
		// (set) Token: 0x060029DA RID: 10714
		public extern GraphTitleJustificationType Justification { get; set; }

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x060029DB RID: 10715
		// (set) Token: 0x060029DC RID: 10716
		public extern double OffsetX { get; set; }

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x060029DD RID: 10717
		// (set) Token: 0x060029DE RID: 10718
		public extern double OffsetY { get; set; }

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x060029DF RID: 10719
		// (set) Token: 0x060029E0 RID: 10720
		public extern bool Border { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x060029E1 RID: 10721
		// (set) Token: 0x060029E2 RID: 10722
		public extern double BorderGap { get; set; }
	}
}
