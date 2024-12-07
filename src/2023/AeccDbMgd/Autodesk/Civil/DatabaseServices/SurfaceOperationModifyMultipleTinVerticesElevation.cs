using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A88 RID: 2696
	public class SurfaceOperationModifyMultipleTinVerticesElevation : SurfaceOperation
	{
		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x0600143F RID: 5183
		public extern Point2dCollection Locations { get; }

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001440 RID: 5184
		public extern double Elevation { get; }

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001441 RID: 5185
		public extern bool IsDeltaElevation { [return: MarshalAs(UnmanagedType.U1)] get; }
	}
}
