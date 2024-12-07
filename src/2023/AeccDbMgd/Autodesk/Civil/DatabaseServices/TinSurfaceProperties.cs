using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000AAD RID: 2733
	public sealed class TinSurfaceProperties
	{
		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001490 RID: 5264
		public extern int NumberOfTriangles { get; }

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001491 RID: 5265
		public extern double MaximumTriangleArea { get; }

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001492 RID: 5266
		public extern double MinimumTriangleArea { get; }

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001493 RID: 5267
		public extern double MaximumTriangleLength { get; }

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001494 RID: 5268
		public extern double MinimumTriangleLength { get; }

		// Token: 0x04001474 RID: 5236
		private int <SyntheticNonEmptyStructMarker>;
	}
}
