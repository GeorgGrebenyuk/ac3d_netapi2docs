using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009E8 RID: 2536
	public sealed class GridSurfaceCell : GridSurfaceObject
	{
		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060012E0 RID: 4832
		public extern GridLocation GridLocation { get; }

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060012E1 RID: 4833
		public extern GridSurfaceVertex TopLeftVertex { get; }

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060012E2 RID: 4834
		public extern GridSurfaceVertex TopRightVertex { get; }

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060012E3 RID: 4835
		public extern GridSurfaceVertex BottomLeftVertex { get; }

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060012E4 RID: 4836
		public extern GridSurfaceVertex BottomRightVertex { get; }

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060012E5 RID: 4837
		public extern GridSurfaceEdge LeftEdge { get; }

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060012E6 RID: 4838
		public extern GridSurfaceEdge TopEdge { get; }

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060012E7 RID: 4839
		public extern GridSurfaceEdge RightEdge { get; }

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060012E8 RID: 4840
		public extern GridSurfaceEdge BottomEdge { get; }

		// Token: 0x060012E9 RID: 4841
		[return: MarshalAs(UnmanagedType.U1)]
		public sealed override extern bool Equals(object rhs);

		// Token: 0x060012EA RID: 4842
		public sealed override extern int GetHashCode();
	}
}
