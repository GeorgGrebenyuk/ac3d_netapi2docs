using System;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009CE RID: 2510
	public class SurfaceBoundary
	{
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001281 RID: 4737
		public extern Point3dCollection Vertices { get; }

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001282 RID: 4738
		public extern SurfaceBoundaryType BoundaryType { get; }

		// Token: 0x040013C7 RID: 5063
		private int <SyntheticNonEmptyStructMarker>;
	}
}
