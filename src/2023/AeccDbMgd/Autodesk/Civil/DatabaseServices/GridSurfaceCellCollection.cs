using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009E7 RID: 2535
	public class GridSurfaceCellCollection : IEnumerable<GridSurfaceCell>
	{
		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060012DA RID: 4826
		public extern int Count { get; }

		// Token: 0x060012DB RID: 4827
		public extern void GetIndexRange(ref int minColIndex, ref int minRowIndex, ref int maxColIndex, ref int maxRowIndex);

		// Token: 0x060012DC RID: 4828
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Contains(GridLocation location);

		// Token: 0x060012DD RID: 4829
		public extern GridSurfaceCell GetAt(GridLocation location);

		// Token: 0x060012DE RID: 4830
		public virtual extern IEnumerator<GridSurfaceCell> GetEnumerator();

		// Token: 0x060012DF RID: 4831
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x040013D3 RID: 5075
		private int <SyntheticNonEmptyStructMarker>;
	}
}
