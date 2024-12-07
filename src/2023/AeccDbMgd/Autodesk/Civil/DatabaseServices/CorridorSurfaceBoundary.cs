using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001173 RID: 4467
	public sealed class CorridorSurfaceBoundary : CorridorSurfaceBaseMask
	{
		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x0600254B RID: 9547
		// (set) Token: 0x0600254C RID: 9548
		public extern CorridorSurfaceBoundaryType BoundaryType { get; set; }

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x0600254D RID: 9549
		public extern bool IsCorridorExtents { [return: MarshalAs(UnmanagedType.U1)] get; }
	}
}
