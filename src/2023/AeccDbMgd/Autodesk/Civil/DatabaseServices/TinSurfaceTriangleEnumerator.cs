using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000AEC RID: 2796
	public sealed class TinSurfaceTriangleEnumerator : IEnumerator<TinSurfaceTriangle>
	{
		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060014CE RID: 5326
		public extern object CurrentObject { get; }

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x060014CF RID: 5327
		public extern TinSurfaceTriangle Current { get; }

		// Token: 0x060014D0 RID: 5328
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool MoveNext();

		// Token: 0x060014D1 RID: 5329
		public extern void Reset();

		// Token: 0x060014D2 RID: 5330
		public sealed extern void Dispose();

		// Token: 0x040014B1 RID: 5297
		private int <SyntheticNonEmptyStructMarker>;
	}
}
