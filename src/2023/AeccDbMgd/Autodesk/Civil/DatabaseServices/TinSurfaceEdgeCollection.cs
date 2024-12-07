using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000AE8 RID: 2792
	public sealed class TinSurfaceEdgeCollection : IEnumerable<TinSurfaceEdge>, IDisposable
	{
		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060014C5 RID: 5317
		public extern int Count { get; }

		// Token: 0x060014C6 RID: 5318
		public extern IEnumerator<TinSurfaceEdge> GetEnumerator();

		// Token: 0x060014C7 RID: 5319
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x060014C8 RID: 5320
		public sealed extern void Dispose();

		// Token: 0x040014AD RID: 5293
		private int <SyntheticNonEmptyStructMarker>;
	}
}
