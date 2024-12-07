using System;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A89 RID: 2697
	public class SurfaceOperationModifyTinVertexElevation : SurfaceOperation
	{
		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001442 RID: 5186
		public extern Point2d Location { get; }

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001443 RID: 5187
		public extern double NewElevation { get; }
	}
}
