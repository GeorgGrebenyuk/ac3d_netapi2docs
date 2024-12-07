using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000AB0 RID: 2736
	public sealed class TinSurfaceTriangle : TinSurfaceObject
	{
		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x0600149D RID: 5277
		public extern TinSurfaceVertex Vertex1 { get; }

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x0600149E RID: 5278
		public extern TinSurfaceVertex Vertex2 { get; }

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x0600149F RID: 5279
		public extern TinSurfaceVertex Vertex3 { get; }

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x060014A0 RID: 5280
		public extern TinSurfaceEdge Edge1 { get; }

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x060014A1 RID: 5281
		public extern TinSurfaceEdge Edge2 { get; }

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x060014A2 RID: 5282
		public extern TinSurfaceEdge Edge3 { get; }

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x060014A3 RID: 5283
		public extern bool IsVisible { [return: MarshalAs(UnmanagedType.U1)] get; }
	}
}
