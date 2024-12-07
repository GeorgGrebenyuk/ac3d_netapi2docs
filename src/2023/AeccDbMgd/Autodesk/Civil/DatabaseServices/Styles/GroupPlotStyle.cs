using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200009A RID: 154
	[Wrapper("AeccDbSampleLineGroupStyle")]
	public sealed class GroupPlotStyle : StyleBase
	{
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060006BB RID: 1723
		// (set) Token: 0x060006BC RID: 1724
		public extern SectionViewPlotRuleType PlotRule { get; set; }

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060006BD RID: 1725
		// (set) Token: 0x060006BE RID: 1726
		public extern int MaximumInRow { get; set; }

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060006BF RID: 1727
		// (set) Token: 0x060006C0 RID: 1728
		public extern int MaximumInColumn { get; set; }

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060006C1 RID: 1729
		// (set) Token: 0x060006C2 RID: 1730
		public extern GroupPlotStartCornerType StartCorner { get; set; }

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060006C3 RID: 1731
		// (set) Token: 0x060006C4 RID: 1732
		public extern GroupPlotAlignType AlignType { get; set; }

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060006C5 RID: 1733
		// (set) Token: 0x060006C6 RID: 1734
		public extern GroupPlotCellSizeType CellSizeType { get; set; }

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060006C7 RID: 1735
		// (set) Token: 0x060006C8 RID: 1736
		public extern double SpaceColumn { get; set; }

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060006C9 RID: 1737
		// (set) Token: 0x060006CA RID: 1738
		public extern double SpaceRow { get; set; }

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060006CB RID: 1739
		// (set) Token: 0x060006CC RID: 1740
		public extern double GapBetweenPages { get; set; }

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060006CD RID: 1741
		// (set) Token: 0x060006CE RID: 1742
		public extern double GridHorizontalMajor { get; set; }

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060006CF RID: 1743
		// (set) Token: 0x060006D0 RID: 1744
		public extern double GridHorizontalMinor { get; set; }

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060006D1 RID: 1745
		// (set) Token: 0x060006D2 RID: 1746
		public extern double GridVerticalMajor { get; set; }

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060006D3 RID: 1747
		// (set) Token: 0x060006D4 RID: 1748
		public extern double GridVerticalMinor { get; set; }

		// Token: 0x060006D5 RID: 1749
		public extern DisplayStyle GetDisplayPlan(GroupPlotDisplayStyleType type);
	}
}
