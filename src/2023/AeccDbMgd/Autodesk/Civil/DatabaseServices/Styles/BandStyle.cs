using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000094 RID: 148
	[Wrapper("AeccDbGraphStyleBands")]
	public abstract class BandStyle : StyleBase
	{
		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000673 RID: 1651
		public abstract BandType BandType { get; }

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000674 RID: 1652
		public abstract ObjectId TitleTextLabelStyleId { get; }

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000675 RID: 1653
		// (set) Token: 0x06000676 RID: 1654
		public extern string TextStyle { get; set; }

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000677 RID: 1655
		// (set) Token: 0x06000678 RID: 1656
		public extern string Text { get; set; }

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000679 RID: 1657
		// (set) Token: 0x0600067A RID: 1658
		public extern double BandHeight { get; set; }

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600067B RID: 1659
		// (set) Token: 0x0600067C RID: 1660
		public extern double TextBoxWidth { get; set; }

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600067D RID: 1661
		// (set) Token: 0x0600067E RID: 1662
		public extern double OffsetFromBand { get; set; }

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600067F RID: 1663
		// (set) Token: 0x06000680 RID: 1664
		public extern BandTitleBoxPosition TextBoxPosition { get; set; }

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000681 RID: 1665
		// (set) Token: 0x06000682 RID: 1666
		public extern BandTitleTextLocation TextLocation { get; set; }

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000683 RID: 1667
		// (set) Token: 0x06000684 RID: 1668
		public extern double TextHeight { get; set; }

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000685 RID: 1669
		// (set) Token: 0x06000686 RID: 1670
		public extern double WeedingFactor { get; set; }

		// Token: 0x06000687 RID: 1671
		public static extern ObjectId GetBandStyleId(Database database, BandType bandType, string bandStyleName);

		// Token: 0x06000688 RID: 1672
		protected internal extern BandStyle(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
