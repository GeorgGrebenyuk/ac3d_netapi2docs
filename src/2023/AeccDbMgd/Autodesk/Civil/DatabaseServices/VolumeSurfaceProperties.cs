using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A02 RID: 2562
	public sealed class VolumeSurfaceProperties
	{
		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060012F5 RID: 4853
		public extern ObjectId BaseSurface { get; }

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060012F6 RID: 4854
		public extern ObjectId ComparisonSurface { get; }

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060012F7 RID: 4855
		public extern double CutFactor { get; }

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060012F8 RID: 4856
		public extern double FillFactor { get; }

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060012F9 RID: 4857
		public extern double AdjustedCutVolume { get; }

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060012FA RID: 4858
		public extern double AdjustedFillVolume { get; }

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060012FB RID: 4859
		public extern double AdjustedNetVolume { get; }

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060012FC RID: 4860
		public extern double UnadjustedCutVolume { get; }

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060012FD RID: 4861
		public extern double UnadjustedFillVolume { get; }

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060012FE RID: 4862
		public extern double UnadjustedNetVolume { get; }

		// Token: 0x040013ED RID: 5101
		private int <SyntheticNonEmptyStructMarker>;
	}
}
