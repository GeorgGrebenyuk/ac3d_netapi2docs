using System;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A7B RID: 2683
	public class SurfaceOperationAddTinMultipleVertices : SurfaceOperation
	{
		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x0600142A RID: 5162
		public extern Point3dCollection Locations { get; }
	}
}
