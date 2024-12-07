using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A1E RID: 2590
	[DefaultMember("Item")]
	public sealed class SurfaceDefinitionBoundaries : SurfaceDefinitionBase<SurfaceOperationAddBoundary>
	{
		// Token: 0x06001385 RID: 4997
		public extern SurfaceOperationAddBoundary AddBoundaries(Point3dCollection points, double midOrdinateDistance, SurfaceBoundaryType boundaryType, [MarshalAs(UnmanagedType.U1)] bool useNonDestructiveBreakline);

		// Token: 0x06001386 RID: 4998
		public extern SurfaceOperationAddBoundary AddBoundaries(Point2dCollection points, double midOrdinateDistance, SurfaceBoundaryType boundaryType, [MarshalAs(UnmanagedType.U1)] bool useNonDestructiveBreakline);

		// Token: 0x06001387 RID: 4999
		public extern SurfaceOperationAddBoundary AddBoundaries(ObjectIdCollection boundaryEntities, double midOrdinateDistance, SurfaceBoundaryType boundaryType, [MarshalAs(UnmanagedType.U1)] bool useNonDestructiveBreakline);
	}
}
