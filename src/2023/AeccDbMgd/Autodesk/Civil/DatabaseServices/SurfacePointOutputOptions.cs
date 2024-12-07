using System;
using System.Collections.Generic;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000AA2 RID: 2722
	public class SurfacePointOutputOptions
	{
		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x0600146C RID: 5228
		// (set) Token: 0x0600146D RID: 5229
		public extern SurfacePointOutputLocationsType OutputLocations { get; set; }

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x0600146E RID: 5230
		// (set) Token: 0x0600146F RID: 5231
		public extern IEnumerable<Point3dCollection> OutputRegions { get; set; }

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001470 RID: 5232
		// (set) Token: 0x06001471 RID: 5233
		public extern IEnumerable<TinSurfaceEdge> Edges { get; set; }

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001472 RID: 5234
		// (set) Token: 0x06001473 RID: 5235
		public extern double GridSpacingX { get; set; }

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001474 RID: 5236
		// (set) Token: 0x06001475 RID: 5237
		public extern double GridSpacingY { get; set; }

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001476 RID: 5238
		// (set) Token: 0x06001477 RID: 5239
		public extern double GridOrientation { get; set; }

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001478 RID: 5240
		// (set) Token: 0x06001479 RID: 5241
		public extern int RandomPointsNumber { get; set; }

		// Token: 0x0600147A RID: 5242
		public extern SurfacePointOutputOptions();

		// Token: 0x0400146A RID: 5226
		private int <SyntheticNonEmptyStructMarker>;
	}
}
