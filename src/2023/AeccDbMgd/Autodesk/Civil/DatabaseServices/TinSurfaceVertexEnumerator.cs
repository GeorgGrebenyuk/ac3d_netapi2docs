using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000AEE RID: 2798
	public sealed class TinSurfaceVertexEnumerator : IEnumerator<TinSurfaceVertex>
	{
		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060014D3 RID: 5331
		public extern object CurrentObject { get; }

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060014D4 RID: 5332
		public extern TinSurfaceVertex Current { get; }

		// Token: 0x060014D5 RID: 5333
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool MoveNext();

		// Token: 0x060014D6 RID: 5334
		public extern void Reset();

		// Token: 0x060014D7 RID: 5335
		public sealed extern void Dispose();

		// Token: 0x040014B3 RID: 5299
		private int <SyntheticNonEmptyStructMarker>;
	}
}
