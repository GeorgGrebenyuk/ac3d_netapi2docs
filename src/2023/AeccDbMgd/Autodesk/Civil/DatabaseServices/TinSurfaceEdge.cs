using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000AA5 RID: 2725
	public sealed class TinSurfaceEdge : TinSurfaceObject
	{
		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001488 RID: 5256
		public override extern bool IsValid { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001489 RID: 5257
		public extern TinSurfaceVertex Vertex1 { get; }

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x0600148A RID: 5258
		public extern TinSurfaceVertex Vertex2 { get; }

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x0600148B RID: 5259
		public extern TinSurfaceTriangle Triangle1 { get; }

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x0600148C RID: 5260
		public extern TinSurfaceTriangle Triangle2 { get; }

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x0600148D RID: 5261
		public extern bool IsLocked { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x0600148E RID: 5262
		[return: MarshalAs(UnmanagedType.U1)]
		public sealed override extern bool Equals(object rhs);

		// Token: 0x0600148F RID: 5263
		public sealed override extern int GetHashCode();

		// Token: 0x0400146C RID: 5228
		private int <SyntheticNonEmptyStructMarker>;
	}
}
