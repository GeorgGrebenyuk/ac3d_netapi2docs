using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000AE9 RID: 2793
	public sealed class TinSurfaceEdgeEnumerator : IEnumerator<TinSurfaceEdge>
	{
		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x060014C9 RID: 5321
		public extern object CurrentObject { get; }

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060014CA RID: 5322
		public extern TinSurfaceEdge Current { get; }

		// Token: 0x060014CB RID: 5323
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool MoveNext();

		// Token: 0x060014CC RID: 5324
		public extern void Reset();

		// Token: 0x060014CD RID: 5325
		public sealed extern void Dispose();

		// Token: 0x040014AE RID: 5294
		private int <SyntheticNonEmptyStructMarker>;
	}
}
