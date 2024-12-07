using System;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A21 RID: 2593
	[DefaultMember("Item")]
	public sealed class SurfaceDefinitionBreaklines : SurfaceDefinitionBase<SurfaceOperationAddBreakline>
	{
		// Token: 0x06001388 RID: 5000
		public extern SurfaceOperationAddBreakline AddNonDestructiveBreaklines(Point3dCollection points, double midOrdinateDistance);

		// Token: 0x06001389 RID: 5001
		public extern SurfaceOperationAddBreakline AddNonDestructiveBreaklines(Point2dCollection points, double midOrdinateDistance);

		// Token: 0x0600138A RID: 5002
		public extern SurfaceOperationAddBreakline AddNonDestructiveBreaklines(ObjectIdCollection breaklineEntities, double midOrdinateDistance);

		// Token: 0x0600138B RID: 5003
		public extern SurfaceOperationAddBreakline AddStandardBreaklines(Point3dCollection points, double midOrdinateDistance, double maximumDistance, double weedingDistance, double weedingAngle);

		// Token: 0x0600138C RID: 5004
		public extern SurfaceOperationAddBreakline AddStandardBreaklines(Point2dCollection points, double midOrdinateDistance, double maximumDistance, double weedingDistance, double weedingAngle);

		// Token: 0x0600138D RID: 5005
		public extern SurfaceOperationAddBreakline AddStandardBreaklines(ObjectIdCollection breaklineEntities, double midOrdinateDistance, double maximumDistance, double weedingDistance, double weedingAngle);

		// Token: 0x0600138E RID: 5006
		public extern SurfaceOperationAddBreakline AddWallBreaklines(WallBreaklineCreationData[] creationData, double midOrdinateDistance, double maximumDistance, double weedingDistance, double weedingAngle);

		// Token: 0x0600138F RID: 5007
		public extern SurfaceOperationAddBreakline AddWallBreaklines(WallBreaklineCreationDataEx[] creationData, double midOrdinateDistance, double maximumDistance, double weedingDistance, double weedingAngle);

		// Token: 0x06001390 RID: 5008
		public extern SurfaceOperationAddBreakline AddProximityBreaklines(Point3dCollection points, double midOrdinateDistance);

		// Token: 0x06001391 RID: 5009
		public extern SurfaceOperationAddBreakline AddProximityBreaklines(Point2dCollection points, double midOrdinateDistance);

		// Token: 0x06001392 RID: 5010
		public extern SurfaceOperationAddBreakline AddProximityBreaklines(ObjectIdCollection breaklineEntities, double midOrdinateDistance);

		// Token: 0x06001393 RID: 5011
		public extern SurfaceOperationAddBreakline[] ImportBreaklinesFromFile(string filename);

		// Token: 0x06001394 RID: 5012
		public extern SurfaceOperationAddBreaklineFromFile AddBreaklinesFromFile(string filename);
	}
}
