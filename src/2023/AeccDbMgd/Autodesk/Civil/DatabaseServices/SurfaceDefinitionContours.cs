using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A26 RID: 2598
	[DefaultMember("Item")]
	public sealed class SurfaceDefinitionContours : SurfaceDefinitionBase<SurfaceOperationAddContour>
	{
		// Token: 0x06001398 RID: 5016
		public extern SurfaceOperationAddContour AddContours(Point3dCollection points, double midOrdinateDistance, double maximumDistance, double weedingDistance, double weedingAngle, SurfaceMinimizeFlatAreaOptions options);

		// Token: 0x06001399 RID: 5017
		public extern SurfaceOperationAddContour AddContours(Point2dCollection points, double midOrdinateDistance, double maximumDistance, double weedingDistance, double weedingAngle, SurfaceMinimizeFlatAreaOptions options);

		// Token: 0x0600139A RID: 5018
		public extern SurfaceOperationAddContour AddContours(ObjectIdCollection boundaryEntities, double midOrdinateDistance, double maximumDistance, double weedingDistance, double weedingAngle, SurfaceMinimizeFlatAreaOptions options);

		// Token: 0x0600139B RID: 5019
		public extern SurfaceOperationAddContour AddContours(Point3dCollection points, double midOrdinateDistance, double maximumDistance, double weedingDistance, double weedingAngle);

		// Token: 0x0600139C RID: 5020
		public extern SurfaceOperationAddContour AddContours(Point2dCollection points, double midOrdinateDistance, double maximumDistance, double weedingDistance, double weedingAngle);

		// Token: 0x0600139D RID: 5021
		public extern SurfaceOperationAddContour AddContours(ObjectIdCollection boundaryEntities, double midOrdinateDistance, double maximumDistance, double weedingDistance, double weedingAngle);
	}
}
