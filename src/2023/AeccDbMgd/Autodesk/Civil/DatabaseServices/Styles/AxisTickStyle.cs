using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001298 RID: 4760
	public sealed class AxisTickStyle : CivilWrapper<AeccDbGraphStyle>
	{
		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x060029BD RID: 10685
		// (set) Token: 0x060029BE RID: 10686
		public extern double Interval { get; set; }

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x060029BF RID: 10687
		// (set) Token: 0x060029C0 RID: 10688
		public extern double Size { get; set; }

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x060029C1 RID: 10689
		// (set) Token: 0x060029C2 RID: 10690
		public extern string LabelText { get; set; }

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x060029C3 RID: 10691
		// (set) Token: 0x060029C4 RID: 10692
		public extern string TextStyle { get; set; }

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x060029C5 RID: 10693
		// (set) Token: 0x060029C6 RID: 10694
		public extern double TextHeight { get; set; }

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x060029C7 RID: 10695
		// (set) Token: 0x060029C8 RID: 10696
		public extern AxisTickJustificationType Justification { get; set; }

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x060029C9 RID: 10697
		// (set) Token: 0x060029CA RID: 10698
		public extern double Rotation { get; set; }

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x060029CB RID: 10699
		// (set) Token: 0x060029CC RID: 10700
		public extern double OffsetX { get; set; }

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x060029CD RID: 10701
		// (set) Token: 0x060029CE RID: 10702
		public extern double OffsetY { get; set; }

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x060029CF RID: 10703
		// (set) Token: 0x060029D0 RID: 10704
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.AxisStyle.ShowTickAndLabel instead.", false)]
		public extern bool TickAndLabelStartElevation { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x04001BD2 RID: 7122
		private int <SyntheticNonEmptyStructMarker>;
	}
}
