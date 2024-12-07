using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001297 RID: 4759
	public sealed class AxisTitleStyle : CivilWrapper<AeccDbGraphStyle>
	{
		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x060029AF RID: 10671
		// (set) Token: 0x060029B0 RID: 10672
		public extern string Text { get; set; }

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x060029B1 RID: 10673
		// (set) Token: 0x060029B2 RID: 10674
		public extern string TextStyle { get; set; }

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x060029B3 RID: 10675
		// (set) Token: 0x060029B4 RID: 10676
		public extern double TextHeight { get; set; }

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x060029B5 RID: 10677
		// (set) Token: 0x060029B6 RID: 10678
		public extern AxisTitleLocationType Location { get; set; }

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x060029B7 RID: 10679
		// (set) Token: 0x060029B8 RID: 10680
		public extern double Rotation { get; set; }

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x060029B9 RID: 10681
		// (set) Token: 0x060029BA RID: 10682
		public extern double OffsetX { get; set; }

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x060029BB RID: 10683
		// (set) Token: 0x060029BC RID: 10684
		public extern double OffsetY { get; set; }

		// Token: 0x04001BD1 RID: 7121
		private int <SyntheticNonEmptyStructMarker>;
	}
}
