using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009E5 RID: 2533
	public sealed class GridSurfaceEdge : GridSurfaceObject
	{
		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060012CF RID: 4815
		public override extern bool IsValid { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060012D0 RID: 4816
		public extern GridSurfaceVertex Vertex1 { get; }

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060012D1 RID: 4817
		public extern GridSurfaceVertex Vertex2 { get; }

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060012D2 RID: 4818
		public extern GridSurfaceCell Cell1 { get; }

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060012D3 RID: 4819
		public extern GridSurfaceCell Cell2 { get; }

		// Token: 0x060012D4 RID: 4820
		[return: MarshalAs(UnmanagedType.U1)]
		public sealed override extern bool Equals(object rhs);

		// Token: 0x060012D5 RID: 4821
		public sealed override extern int GetHashCode();

		// Token: 0x040013D2 RID: 5074
		private int <SyntheticNonEmptyStructMarker>;
	}
}
