using System;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A83 RID: 2691
	public class SurfaceOperationTransformBy : SurfaceOperation
	{
		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001437 RID: 5175
		public extern SurfaceTransformOperationType TransformType { get; }

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001438 RID: 5176
		public extern Matrix3d TransformMatrix { get; }
	}
}
