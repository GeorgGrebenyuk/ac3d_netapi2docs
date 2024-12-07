using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000076 RID: 118
	[Wrapper("AeccDbIntersection")]
	public sealed class Intersection : Entity
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600056C RID: 1388
		public extern ObjectId CorridorId { get; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600056D RID: 1389
		public extern IntersectionRoadCollection IntersectionRoads { get; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600056E RID: 1390
		public extern IntersectionRegionCollection IntersectionRegions { get; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600056F RID: 1391
		public extern IntersectionCorridorType GradeRuleType { get; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000570 RID: 1392
		// (set) Token: 0x06000571 RID: 1393
		public extern DrivingDirectionType RoadwayDrivingDirection { get; set; }

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000572 RID: 1394
		public extern Point3d Location { get; }

		// Token: 0x06000573 RID: 1395
		public extern ObjectIdCollection GetIntersectionLocaitonLabelIds();
	}
}
