using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.DatabaseServices.Styles;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200004A RID: 74
	[Wrapper("AeccDbSurfaceTin")]
	public sealed class TinSurface : Surface, ITinSurface, ITerrainSurface
	{
		// Token: 0x0600022C RID: 556
		public static extern ObjectId Create(string surfaceName, ObjectId styleId);

		// Token: 0x0600022D RID: 557
		public static extern ObjectId Create(Database database, string surfaceName);

		// Token: 0x0600022E RID: 558
		public static extern ObjectId CreateFromTin(Database database, string tinFileName);

		// Token: 0x0600022F RID: 559
		public static extern ObjectId CreateFromLandXML(Database database, string newSurfaceName, string landXMLfileName, string landXMLSurfaceName);

		// Token: 0x06000230 RID: 560
		[DeprecatedVersion(CivilVersion.Civil2022)]
		[Obsolete("Use the function with 4 parameters instead, and pass the name of the surface in the LandXML file you want to create as the 4th paraemter.", false)]
		public static extern ObjectId CreateFromLandXML(Database database, string surfaceName, string landXMLfileName);

		// Token: 0x06000231 RID: 561
		public static extern ObjectId CreateFromIMX(Database database, ObjectId styleId, string imxFileName, string surfaceName, string gitHash, string query, [MarshalAs(UnmanagedType.U1)] bool doCoordSysConversion);

		// Token: 0x06000232 RID: 562
		public static extern ObjectId CreateByCropping(Database destDatabase, string surfaceName, ObjectId srcSurfaceId, ObjectIdCollection objects, Point2d location);

		// Token: 0x06000233 RID: 563
		public static extern ObjectId CreateByCropping(Database destDatabase, string surfaceName, ObjectId srcSurfaceId, Point3dCollection points);

		// Token: 0x06000234 RID: 564
		public static extern ObjectId CreateByCropping(Database destDatabase, string surfaceName, ObjectId srcSurfaceId, Point2dCollection points);

		// Token: 0x06000235 RID: 565
		public static extern ObjectId CreateFromCorridorSurface(string surfaceName, CorridorSurface corridorSurface);

		// Token: 0x06000236 RID: 566
		public extern ObjectIdCollection CreateSolidsAtDepth(double depth, string layer, ushort penIndex);

		// Token: 0x06000237 RID: 567
		public extern ObjectIdCollection CreateSolidsAtDepthToFile(double depth, string layer, ushort penIndex, ref string fileName);

		// Token: 0x06000238 RID: 568
		public extern ObjectIdCollection CreateSolidsAtFixedElevation(double elevation, string layer, ushort penIndex);

		// Token: 0x06000239 RID: 569
		public extern ObjectIdCollection CreateSolidsAtFixedElevationToFile(double elevation, string layer, ushort penIndex, ref string fileName);

		// Token: 0x0600023A RID: 570
		public extern ObjectIdCollection CreateSolidsAtSurface(ObjectId bottomSurfaceId, string layer, ushort penIndex);

		// Token: 0x0600023B RID: 571
		public extern ObjectIdCollection CreateSolidsAtSurfaceToFile(ObjectId bottomSurfaceId, string layer, ushort penIndex, ref string fileName);

		// Token: 0x0600023C RID: 572
		public extern TinSurfaceProperties GetTinProperties();

		// Token: 0x0600023D RID: 573
		public extern TerrainSurfaceProperties GetTerrainProperties();

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600023E RID: 574
		public extern SurfaceDefinitionBreaklines BreaklinesDefinition { get; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600023F RID: 575
		public extern SurfaceDefinitionContours ContoursDefinition { get; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000240 RID: 576
		public extern SurfaceDefinitionDEMFiles DEMFilesDefinition { get; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000241 RID: 577
		public extern TinSurfaceVertexCollection Vertices { get; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000242 RID: 578
		public extern TinSurfaceTriangleCollection Triangles { get; }

		// Token: 0x06000243 RID: 579
		public extern TinSurfaceTriangleCollection GetTriangles([MarshalAs(UnmanagedType.U1)] bool includeInvisible);

		// Token: 0x06000244 RID: 580
		public extern TinSurfaceVertex FindVertexAtXY(double x, double y);

		// Token: 0x06000245 RID: 581
		public extern TinSurfaceEdge FindEdgeAtXY(double x, double y);

		// Token: 0x06000246 RID: 582
		public extern TinSurfaceTriangle FindTriangleAtXY(double x, double y);

		// Token: 0x06000247 RID: 583
		public extern Type IdentifyFeatureTypeAtXY(double x, double y);

		// Token: 0x06000248 RID: 584
		public extern TinSurfaceVertex[] GetVerticesInsidePolylinesRandom(ObjectIdCollection polylineIds, int randomNumber);

		// Token: 0x06000249 RID: 585
		public extern TinSurfaceVertex[] GetVerticesInsidePolylines(ObjectIdCollection polylineIds);

		// Token: 0x0600024A RID: 586
		public extern TinSurfaceVertex[] GetVerticesInsideBorderRandom(Point3dCollection border, int randomNumber);

		// Token: 0x0600024B RID: 587
		public extern TinSurfaceVertex[] GetVerticesInsideBorder(Point3dCollection border);

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600024C RID: 588
		public extern SurfaceDefinitionDrawingObjects DrawingObjectsDefinition { get; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600024D RID: 589
		public extern SurfaceDefinitionPointGroups PointGroupsDefinition { get; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600024E RID: 590
		public extern SurfaceDefinitionPointFiles PointFilesDefinition { get; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600024F RID: 591
		public extern SurfaceDefinitionAddFigureSurveyQueries SurveyQueriesAddFigureDefinition { get; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000250 RID: 592
		public extern SurfaceDefinitionAddPointSurveyQueries SurveyQueriesAddPointDefinition { get; }

		// Token: 0x06000251 RID: 593
		public extern SurfaceOperationAddTinVertex AddVertex(Point2d location);

		// Token: 0x06000252 RID: 594
		public extern SurfaceOperationAddTinVertex AddVertex(Point3d location);

		// Token: 0x06000253 RID: 595
		public extern SurfaceOperationAddTinMultipleVertices AddVertices(Point2dCollection locations);

		// Token: 0x06000254 RID: 596
		public extern SurfaceOperationAddTinMultipleVertices AddVertices(Point3dCollection locations);

		// Token: 0x06000255 RID: 597
		public extern SurfaceOperationDeleteTinVertex DeleteVertex(TinSurfaceVertex vertex);

		// Token: 0x06000256 RID: 598
		public extern SurfaceOperationDeleteMultipleTinVertices DeleteVertices(IEnumerable<TinSurfaceVertex> vertices);

		// Token: 0x06000257 RID: 599
		public extern SurfaceOperationModifyTinVertexElevation SetVertexElevation(TinSurfaceVertex vertex, double newElevation);

		// Token: 0x06000258 RID: 600
		public extern SurfaceOperationModifyMultipleTinVerticesElevation SetVerticesElevation(IEnumerable<TinSurfaceVertex> vertices, double newElevation);

		// Token: 0x06000259 RID: 601
		public extern SurfaceOperationModifyMultipleTinVerticesElevation RaiseVertices(IEnumerable<TinSurfaceVertex> vertices, double deltaElevation);

		// Token: 0x0600025A RID: 602
		public extern SurfaceOperationMoveTinVertex MoveVertex(TinSurfaceVertex vertex, Point2d newLocation);

		// Token: 0x0600025B RID: 603
		public extern SurfaceOperationAddLine AddLine(TinSurfaceVertex vertex1, TinSurfaceVertex vertex2);

		// Token: 0x0600025C RID: 604
		public extern SurfaceOperationDeleteLine DeleteLine(TinSurfaceEdge tinTriangleEdge);

		// Token: 0x0600025D RID: 605
		public extern SurfaceOperationDeleteMultipleLines DeleteLines(IEnumerable<TinSurfaceEdge> tinTriangleEdges);

		// Token: 0x0600025E RID: 606
		public extern SurfaceOperationSwapEdge SwapEdge(TinSurfaceEdge tinTriangleEdge);

		// Token: 0x0600025F RID: 607
		public extern SurfaceOperationRaise RaiseSurface(double deltaElevation);

		// Token: 0x06000260 RID: 608
		public extern SurfaceOperationPasteSurface PasteSurface(ObjectId surfaceId);

		// Token: 0x06000261 RID: 609
		public extern SurfaceOperationSimplify SimplifySurface(SurfaceSimplifyOptions simplifyOptions);

		// Token: 0x06000262 RID: 610
		public extern SurfaceOperationMinimizeFlatAreas MinimizeFlatAreas(SurfaceMinimizeFlatAreaOptions minimizeOptions);

		// Token: 0x06000263 RID: 611
		public extern SurfaceOperationSmooth SmoothSurfaceByNNI(SurfacePointOutputOptions pointOutputOptions);

		// Token: 0x06000264 RID: 612
		public extern SurfaceOperationSmooth SmoothSurfaceByKriging(KrigingMethodOptions krigingOptions, SurfacePointOutputOptions pointOutputOptions);

		// Token: 0x06000265 RID: 613
		public extern ObjectIdCollection ExtractBorder(SurfaceExtractionSettingsType settingsType);

		// Token: 0x06000266 RID: 614
		public extern ObjectIdCollection ExtractWatershed(SurfaceExtractionSettingsType settingsType);

		// Token: 0x06000267 RID: 615
		public extern ObjectIdCollection ExtractGridded(SurfaceExtractionSettingsType settingsType);

		// Token: 0x06000268 RID: 616
		public extern ObjectIdCollection ExtractMajorContours(SurfaceExtractionSettingsType settingsType, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x06000269 RID: 617
		public extern ObjectIdCollection ExtractMajorContours(SurfaceExtractionSettingsType settingsType);

		// Token: 0x0600026A RID: 618
		public extern ObjectIdCollection ExtractMinorContours(SurfaceExtractionSettingsType settingsType, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x0600026B RID: 619
		public extern ObjectIdCollection ExtractMinorContours(SurfaceExtractionSettingsType settingsType);

		// Token: 0x0600026C RID: 620
		public extern ObjectIdCollection ExtractContoursAt(double elevation, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x0600026D RID: 621
		public extern ObjectIdCollection ExtractContoursAt(double elevation);

		// Token: 0x0600026E RID: 622
		public extern ObjectIdCollection ExtractContours(double interval, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x0600026F RID: 623
		public extern ObjectIdCollection ExtractContours(double interval);

		// Token: 0x06000270 RID: 624
		public extern ObjectIdCollection ExtractContours(double lowElev, double highElev, double interval, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x06000271 RID: 625
		public extern ObjectIdCollection ExtractContours(double lowElev, double highElev, double interval);

		// Token: 0x06000272 RID: 626
		public extern Point3dCollection SampleElevations(Point3d pt1, Point3d pt2);

		// Token: 0x06000273 RID: 627
		public extern Point3dCollection SampleElevations(ObjectId curveId);
	}
}
