using System;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F79 RID: 3961
	public sealed class SlopePatternLineSymbol : CivilWrapper<AeccDbSlopePatternStyle>
	{
		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06001E71 RID: 7793
		// (set) Token: 0x06001E72 RID: 7794
		public extern SlopePatternSymbolType SymbolType { get; set; }

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06001E73 RID: 7795
		// (set) Token: 0x06001E74 RID: 7796
		public extern string BlockName { get; set; }

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06001E75 RID: 7797
		// (set) Token: 0x06001E76 RID: 7798
		public extern SlopePatternLengthType LengthType { get; set; }

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06001E77 RID: 7799
		// (set) Token: 0x06001E78 RID: 7800
		public extern double PercentofLength { get; set; }

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06001E79 RID: 7801
		// (set) Token: 0x06001E7A RID: 7802
		public extern double Length { get; set; }

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06001E7B RID: 7803
		// (set) Token: 0x06001E7C RID: 7804
		public extern double WidthRatio { get; set; }

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06001E7D RID: 7805
		// (set) Token: 0x06001E7E RID: 7806
		public extern string Linetype { get; set; }

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06001E7F RID: 7807
		// (set) Token: 0x06001E80 RID: 7808
		public extern LineWeight LineWeight { get; set; }

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06001E81 RID: 7809
		// (set) Token: 0x06001E82 RID: 7810
		public extern Color Color { get; set; }

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06001E83 RID: 7811
		// (set) Token: 0x06001E84 RID: 7812
		public extern int Numberoflines { get; set; }

		// Token: 0x04001853 RID: 6227
		private int <SyntheticNonEmptyStructMarker>;
	}
}
