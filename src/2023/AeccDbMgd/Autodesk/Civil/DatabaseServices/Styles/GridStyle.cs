using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F58 RID: 3928
	public sealed class GridStyle : CivilWrapper<AeccDbGraphStyle>
	{
		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06001DAB RID: 7595
		public extern GridOptions VerticalGridOptions { get; }

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06001DAC RID: 7596
		public extern GridOptions HorizontalGridOptions { get; }

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06001DAD RID: 7597
		// (set) Token: 0x06001DAE RID: 7598
		public extern double GridPaddingAbove { get; set; }

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06001DAF RID: 7599
		// (set) Token: 0x06001DB0 RID: 7600
		public extern double GridPaddingBottom { get; set; }

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06001DB1 RID: 7601
		// (set) Token: 0x06001DB2 RID: 7602
		public extern double GridPaddingLeft { get; set; }

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06001DB3 RID: 7603
		// (set) Token: 0x06001DB4 RID: 7604
		public extern double GridPaddingRight { get; set; }

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06001DB5 RID: 7605
		// (set) Token: 0x06001DB6 RID: 7606
		public extern double AxisOffsetAbove { get; set; }

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06001DB7 RID: 7607
		// (set) Token: 0x06001DB8 RID: 7608
		public extern double AxisOffsetBottom { get; set; }

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06001DB9 RID: 7609
		// (set) Token: 0x06001DBA RID: 7610
		public extern double AxisOffsetLeft { get; set; }

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06001DBB RID: 7611
		// (set) Token: 0x06001DBC RID: 7612
		public extern double AxisOffsetRight { get; set; }
	}
}
