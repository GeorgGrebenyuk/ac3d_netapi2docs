using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009D6 RID: 2518
	public class GeneralSurfaceProperties
	{
		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x0600129D RID: 4765
		public extern int RevisionNumber { get; }

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x0600129E RID: 4766
		public extern int NumberOfPoints { get; }

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x0600129F RID: 4767
		public extern double MinimumCoordinateX { get; }

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060012A0 RID: 4768
		public extern double MinimumCoordinateY { get; }

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x060012A1 RID: 4769
		public extern double MaximumCoordinateX { get; }

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x060012A2 RID: 4770
		public extern double MaximumCoordinateY { get; }

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x060012A3 RID: 4771
		public extern double MinimumElevation { get; }

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060012A4 RID: 4772
		public extern double MaximumElevation { get; }

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060012A5 RID: 4773
		public extern double MeanElevation { get; }

		// Token: 0x040013CC RID: 5068
		private int <SyntheticNonEmptyStructMarker>;
	}
}
