using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000932 RID: 2354
	public abstract class BandSetItem
	{
		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x060011ED RID: 4589
		public extern BandLocationType Location { get; }

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x060011EE RID: 4590
		// (set) Token: 0x060011EF RID: 4591
		public abstract double MajorInterval { get; set; }

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x060011F0 RID: 4592
		// (set) Token: 0x060011F1 RID: 4593
		public abstract double MinorInterval { get; set; }

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x060011F2 RID: 4594
		public extern BandType BandType { get; }

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060011F3 RID: 4595
		// (set) Token: 0x060011F4 RID: 4596
		public abstract virtual extern ObjectId BandStyleId { get; set; }

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060011F5 RID: 4597
		// (set) Token: 0x060011F6 RID: 4598
		public extern bool ShowLabels { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060011F7 RID: 4599
		// (set) Token: 0x060011F8 RID: 4600
		public extern double Gap { get; set; }

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060011F9 RID: 4601
		// (set) Token: 0x060011FA RID: 4602
		public extern double Weeding { get; set; }

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060011FB RID: 4603
		// (set) Token: 0x060011FC RID: 4604
		public extern StaggerLabelType StaggerLabel { get; set; }

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060011FD RID: 4605
		// (set) Token: 0x060011FE RID: 4606
		public extern double StaggerLineHeight { get; set; }

		// Token: 0x060011FF RID: 4607
		protected unsafe extern AeccDbBandStyleSetData* GetImpObj();

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001200 RID: 4608
		protected unsafe abstract char* SettingsNode { get; }

		// Token: 0x04001334 RID: 4916
		private int <SyntheticNonEmptyStructMarker>;
	}
}
