using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009E3 RID: 2531
	public sealed class GridSurfaceVertexCollection : IEnumerable<GridSurfaceVertex>
	{
		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060012C3 RID: 4803
		public extern int Count { get; }

		// Token: 0x060012C4 RID: 4804
		public extern void GetIndexRange(ref int minColIndex, ref int minRowIndex, ref int maxColIndex, ref int maxRowIndex);

		// Token: 0x060012C5 RID: 4805
		public extern GridSurfaceVertex GetAt(GridLocation location);

		// Token: 0x060012C6 RID: 4806
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Contains(GridLocation location);

		// Token: 0x060012C7 RID: 4807
		public extern IEnumerator<GridSurfaceVertex> GetEnumerator();

		// Token: 0x060012C8 RID: 4808
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x040013D0 RID: 5072
		private int <SyntheticNonEmptyStructMarker>;
	}
}
