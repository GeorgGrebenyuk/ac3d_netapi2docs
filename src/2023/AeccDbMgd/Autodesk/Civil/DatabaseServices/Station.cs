using System;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200004D RID: 77
	public sealed class Station
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002A0 RID: 672
		// (set) Token: 0x060002A1 RID: 673
		public extern double RawStation { get; set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002A2 RID: 674
		// (set) Token: 0x060002A3 RID: 675
		public extern AlignmentGeometryPointStationType GeometryStationType { get; set; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002A4 RID: 676
		// (set) Token: 0x060002A5 RID: 677
		public extern StationTypes StationType { get; set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002A6 RID: 678
		// (set) Token: 0x060002A7 RID: 679
		public extern Point2d Location { get; set; }

		// Token: 0x060002A8 RID: 680
		public extern Station();

		// Token: 0x040002EE RID: 750
		private int <SyntheticNonEmptyStructMarker>;
	}
}
