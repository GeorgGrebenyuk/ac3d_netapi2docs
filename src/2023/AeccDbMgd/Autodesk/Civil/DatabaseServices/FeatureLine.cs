using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000074 RID: 116
	[Wrapper("AeccDbFeatureLine")]
	public class FeatureLine : Feature
	{
		// Token: 0x170001DE RID: 478
		// (set) Token: 0x06000536 RID: 1334
		public override extern ObjectId StyleId { set; }

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000537 RID: 1335
		// (set) Token: 0x06000538 RID: 1336
		public override extern string StyleName { get; set; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000539 RID: 1337
		public extern ObjectId SiteId { get; }

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600053A RID: 1338
		public extern double MinElevation { get; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600053B RID: 1339
		public extern double MaxElevation { get; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600053C RID: 1340
		public extern double MinGrade { get; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600053D RID: 1341
		public extern double MaxGrade { get; }

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600053E RID: 1342
		public extern double Length2D { get; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600053F RID: 1343
		public extern double Length3D { get; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000540 RID: 1344
		// (set) Token: 0x06000541 RID: 1345
		public extern ObjectId RelativeSurfaceId { get; set; }

		// Token: 0x06000542 RID: 1346
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsElevationRelativeToSurface(Point3d pt);

		// Token: 0x06000543 RID: 1347
		public extern double GetPointRelativeElevation(Point3d pt);

		// Token: 0x06000544 RID: 1348
		public extern void SetPointRelativeElevation(Point3d pt, [MarshalAs(UnmanagedType.U1)] bool relative, double elevation);

		// Token: 0x06000545 RID: 1349
		public extern double GetGradeInAtPoint(Point3d pt);

		// Token: 0x06000546 RID: 1350
		public extern double GetGradeOutAtPoint(Point3d pt);

		// Token: 0x06000547 RID: 1351
		public extern double GetDeflectionAngleAtPoint(Point3d pt);

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000548 RID: 1352
		public extern int PointsCount { get; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000549 RID: 1353
		public extern int PIPointsCount { get; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600054A RID: 1354
		public extern int ElevationPointsCount { get; }

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600054B RID: 1355
		public extern int CurvesCount { get; }

		// Token: 0x0600054C RID: 1356
		public extern Point3dCollection GetPoints(FeatureLinePointType type);

		// Token: 0x0600054D RID: 1357
		public extern double Get3dDistanceAtPoint(Point3d pt);

		// Token: 0x0600054E RID: 1358
		public extern double GetBulge(int index);

		// Token: 0x0600054F RID: 1359
		public extern void SetBulge(int index, double bugle);

		// Token: 0x06000550 RID: 1360
		public extern void InsertElevationPoint(Point3d pt);

		// Token: 0x06000551 RID: 1361
		public extern void InsertElevationPoints(Point3dCollection cliPoints);

		// Token: 0x06000552 RID: 1362
		public extern void InsertPIPoint(Point3d pt);

		// Token: 0x06000553 RID: 1363
		public extern void DeleteElevationPoint(Point3d pt);

		// Token: 0x06000554 RID: 1364
		public extern void DeleteElevationPoints(Point3dCollection cliPoints);

		// Token: 0x06000555 RID: 1365
		public extern void DeletePIPoint(Point3d pt);

		// Token: 0x06000556 RID: 1366
		public extern void SetPointElevation(int index, double elevation);

		// Token: 0x06000557 RID: 1367
		public static extern void MoveToSite(ObjectId featureLineId, ObjectId destinationSiteId);

		// Token: 0x06000558 RID: 1368
		public static extern void MoveToNoneSite(ObjectId featureLineId);

		// Token: 0x06000559 RID: 1369
		public static extern ObjectId Create(string featurelineName, ObjectId idCreatedFrom);

		// Token: 0x0600055A RID: 1370
		public static extern ObjectId Create(string featurelineName, ObjectId idCreatedFrom, ObjectId siteId);

		// Token: 0x0600055B RID: 1371
		public extern void AssignElevationsFromSurface(ObjectId surfaceId, [MarshalAs(UnmanagedType.U1)] bool bIncIntermediate);

		// Token: 0x0600055C RID: 1372
		public extern double GetCurveRadius(int index);

		// Token: 0x0600055D RID: 1373
		public extern void SetCurveRadius(int index, double radius);

		// Token: 0x0600055E RID: 1374
		protected internal extern FeatureLine(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
