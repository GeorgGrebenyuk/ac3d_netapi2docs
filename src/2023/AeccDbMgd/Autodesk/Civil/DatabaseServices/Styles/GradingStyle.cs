using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000099 RID: 153
	[Wrapper("AeccDbGradingStyle")]
	public sealed class GradingStyle : StyleBase
	{
		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060006A6 RID: 1702
		// (set) Token: 0x060006A7 RID: 1703
		public extern CenterMarkerSizeType CenterMarker { get; set; }

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060006A8 RID: 1704
		// (set) Token: 0x060006A9 RID: 1705
		public extern double PercentageOfScreen { get; set; }

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060006AA RID: 1706
		// (set) Token: 0x060006AB RID: 1707
		public extern double PlottedSize { get; set; }

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060006AC RID: 1708
		// (set) Token: 0x060006AD RID: 1709
		public extern double FixedSize { get; set; }

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060006AE RID: 1710
		public extern bool UseSlopePatternStyle { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060006AF RID: 1711
		// (set) Token: 0x060006B0 RID: 1712
		public extern ObjectId SlopePatternStyleId { get; set; }

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060006B1 RID: 1713
		// (set) Token: 0x060006B2 RID: 1714
		public extern string SlopePatternStyleName { get; set; }

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060006B3 RID: 1715
		// (set) Token: 0x060006B4 RID: 1716
		public extern bool UseSlopeRange { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060006B5 RID: 1717
		// (set) Token: 0x060006B6 RID: 1718
		public extern double SlopeRangeMin { get; set; }

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060006B7 RID: 1719
		// (set) Token: 0x060006B8 RID: 1720
		public extern double SlopeRangeMax { get; set; }

		// Token: 0x060006B9 RID: 1721
		public extern DisplayStyle GetDisplayStylePlan(GradingDisplayStyleType type);

		// Token: 0x060006BA RID: 1722
		public extern DisplayStyle GetDisplayStyleModel(GradingDisplayStyleType type);
	}
}
