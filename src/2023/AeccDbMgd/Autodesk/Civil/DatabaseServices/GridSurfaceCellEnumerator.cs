using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009FC RID: 2556
	public sealed class GridSurfaceCellEnumerator : IEnumerator<GridSurfaceCell>
	{
		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060012EB RID: 4843
		public extern object CurrentObject { get; }

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060012EC RID: 4844
		public extern GridSurfaceCell Current { get; }

		// Token: 0x060012ED RID: 4845
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool MoveNext();

		// Token: 0x060012EE RID: 4846
		public extern void Reset();

		// Token: 0x060012EF RID: 4847
		public sealed extern void Dispose();

		// Token: 0x040013E7 RID: 5095
		private int <SyntheticNonEmptyStructMarker>;
	}
}
