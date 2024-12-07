using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009D1 RID: 2513
	public class SurfaceBreakline
	{
		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x0600128D RID: 4749
		public extern string Description { get; }

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x0600128E RID: 4750
		public extern SurfaceBreaklineType BreaklineType { get; }

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x0600128F RID: 4751
		public extern Point3dCollection Vertices { get; }

		// Token: 0x06001290 RID: 4752
		public extern ObjectId InsertIntoDrawing();

		// Token: 0x040013C9 RID: 5065
		private int <SyntheticNonEmptyStructMarker>;
	}
}
