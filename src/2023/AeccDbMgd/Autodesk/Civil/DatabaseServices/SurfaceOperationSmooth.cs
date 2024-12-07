using System;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A8E RID: 2702
	public class SurfaceOperationSmooth : SurfaceOperation
	{
		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x0600145B RID: 5211
		public extern SurfaceSmoothType SurfaceSmoothMethod { get; }

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x0600145C RID: 5212
		public extern Point3dCollection OutPutPoints { get; }
	}
}
