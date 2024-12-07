using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009FF RID: 2559
	public sealed class GridSurfaceVertexEnumerator : IEnumerator<GridSurfaceVertex>
	{
		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060012F0 RID: 4848
		public extern object CurrentObject { get; }

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060012F1 RID: 4849
		public extern GridSurfaceVertex Current { get; }

		// Token: 0x060012F2 RID: 4850
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool MoveNext();

		// Token: 0x060012F3 RID: 4851
		public extern void Reset();

		// Token: 0x060012F4 RID: 4852
		public sealed extern void Dispose();

		// Token: 0x040013EA RID: 5098
		private int <SyntheticNonEmptyStructMarker>;
	}
}
