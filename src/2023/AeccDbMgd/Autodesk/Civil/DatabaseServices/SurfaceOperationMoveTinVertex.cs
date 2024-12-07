using System;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A8A RID: 2698
	public class SurfaceOperationMoveTinVertex : SurfaceOperation
	{
		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001444 RID: 5188
		public extern Point2d OriginalLocation { get; }

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001445 RID: 5189
		public extern Point2d NewLocation { get; }
	}
}
