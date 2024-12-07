using System;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A8F RID: 2703
	public class SurfaceOperationCreateByCropping : SurfaceOperation
	{
		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x0600145D RID: 5213
		public extern string SourceFileName { get; }

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x0600145E RID: 5214
		public extern Point3dCollection CroppedBoundary { get; }
	}
}
