using System;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000AA4 RID: 2724
	public sealed class TinSurfaceVertex : TinSurfaceObject
	{
		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001484 RID: 5252
		public extern Point3d Location { get; }

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001485 RID: 5253
		public extern TinSurfaceVertexCollection Vertices { get; }

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001486 RID: 5254
		public extern TinSurfaceTriangleCollection Triangles { get; }

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001487 RID: 5255
		public extern TinSurfaceEdgeCollection Edges { get; }
	}
}
