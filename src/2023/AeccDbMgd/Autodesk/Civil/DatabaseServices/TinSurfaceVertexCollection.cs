using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000AAE RID: 2734
	public sealed class TinSurfaceVertexCollection : IEnumerable<TinSurfaceVertex>, IDisposable
	{
		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001495 RID: 5269
		public extern int Count { get; }

		// Token: 0x06001496 RID: 5270
		public extern IEnumerator<TinSurfaceVertex> GetEnumerator();

		// Token: 0x06001497 RID: 5271
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06001498 RID: 5272
		public sealed extern void Dispose();

		// Token: 0x04001475 RID: 5237
		private int <SyntheticNonEmptyStructMarker>;
	}
}
