using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000AAF RID: 2735
	public sealed class TinSurfaceTriangleCollection : IEnumerable<TinSurfaceTriangle>, IDisposable
	{
		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001499 RID: 5273
		public extern int Count { get; }

		// Token: 0x0600149A RID: 5274
		public extern IEnumerator<TinSurfaceTriangle> GetEnumerator();

		// Token: 0x0600149B RID: 5275
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x0600149C RID: 5276
		public sealed extern void Dispose();

		// Token: 0x04001476 RID: 5238
		private int <SyntheticNonEmptyStructMarker>;
	}
}
