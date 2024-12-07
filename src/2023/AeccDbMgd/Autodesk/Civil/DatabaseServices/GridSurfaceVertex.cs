using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009E6 RID: 2534
	public sealed class GridSurfaceVertex : GridSurfaceObject
	{
		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060012D6 RID: 4822
		public extern GridLocation GridLocation { get; }

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060012D7 RID: 4823
		public extern Point3d Location { get; }

		// Token: 0x060012D8 RID: 4824
		[return: MarshalAs(UnmanagedType.U1)]
		public sealed override extern bool Equals(object rhs);

		// Token: 0x060012D9 RID: 4825
		public sealed override extern int GetHashCode();
	}
}
