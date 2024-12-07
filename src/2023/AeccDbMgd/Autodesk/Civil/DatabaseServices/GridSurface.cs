using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.DatabaseServices.Styles;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200004C RID: 76
	[Wrapper("AeccDbSurfaceGrid")]
	public sealed class GridSurface : Surface, IGridSurface, ITerrainSurface
	{
		// Token: 0x0600027A RID: 634
		public static extern ObjectId Create(string surfaceName, double spacingX, double spacingY, double orientation, ObjectId styleId);

		// Token: 0x0600027B RID: 635
		public static extern ObjectId Create(Database database, string surfaceName, double spacingX, double spacingY, double orientation);

		// Token: 0x0600027C RID: 636
		public static extern ObjectId CreateFromDEM(string DEMFileName, ObjectId styleId);

		// Token: 0x0600027D RID: 637
		public static extern ObjectId CreateFromDEM(Database database, string DEMFileName);

		// Token: 0x0600027E RID: 638
		public extern GridSurfaceProperties GetGridProperties();

		// Token: 0x0600027F RID: 639
		public extern TerrainSurfaceProperties GetTerrainProperties();

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000280 RID: 640
		public extern SurfaceDefinitionDEMFiles DEMFilesDefinition { get; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000281 RID: 641
		public extern GridSurfaceVertexCollection Vertices { get; }

		// Token: 0x06000282 RID: 642
		public extern GridSurfaceVertexCollection GetVertices([MarshalAs(UnmanagedType.U1)] bool includeInvisible);

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000283 RID: 643
		public extern GridSurfaceCellCollection Cells { get; }

		// Token: 0x06000284 RID: 644
		public extern GridSurfaceCellCollection GetCells([MarshalAs(UnmanagedType.U1)] bool includeInvisible);

		// Token: 0x06000285 RID: 645
		public extern GridSurfaceVertex FindVertexAtXY(double x, double y);

		// Token: 0x06000286 RID: 646
		public extern GridSurfaceEdge FindEdgeAtXY(double x, double y);

		// Token: 0x06000287 RID: 647
		public extern GridSurfaceCell FindCellAtXY(double x, double y);

		// Token: 0x06000288 RID: 648
		public extern SurfaceOperationAddGridPoint AddPoint(GridLocation location, double elevation);

		// Token: 0x06000289 RID: 649
		public extern SurfaceOperationDeleteGridPoint DeletePoint(GridLocation location);

		// Token: 0x0600028A RID: 650
		public extern SurfaceOperationDeleteMultipleGridPoints DeletePoints(IEnumerable<GridLocation> locations);

		// Token: 0x0600028B RID: 651
		public extern SurfaceOperationModifyGridPointElevation SetPointElevation(GridLocation location, double newElevation);

		// Token: 0x0600028C RID: 652
		public extern SurfaceOperationModifyMultipleGridPointsElevation SetPointsElevation(IEnumerable<GridLocation> locations, double newElevation);

		// Token: 0x0600028D RID: 653
		public extern SurfaceOperationModifyMultipleGridPointsElevation RaisePoints(IEnumerable<GridLocation> locations, double deltaElevation);

		// Token: 0x0600028E RID: 654
		public extern SurfaceOperationDeleteLine DeleteLine(GridSurfaceEdge edge);

		// Token: 0x0600028F RID: 655
		public extern SurfaceOperationDeleteMultipleLines DeleteLines(IEnumerable<GridSurfaceEdge> edges);

		// Token: 0x06000290 RID: 656
		public extern SurfaceOperationRaise RaiseSurface(double deltaElevation);

		// Token: 0x06000291 RID: 657
		public extern Point3dCollection SampleElevations(Point3d pt1, Point3d pt2);

		// Token: 0x06000292 RID: 658
		public extern Point3dCollection SampleElevations(ObjectId curveId);

		// Token: 0x06000293 RID: 659
		public extern ObjectIdCollection ExtractBorder(SurfaceExtractionSettingsType settingsType);

		// Token: 0x06000294 RID: 660
		public extern ObjectIdCollection ExtractWatershed(SurfaceExtractionSettingsType settingsType);

		// Token: 0x06000295 RID: 661
		public extern ObjectIdCollection ExtractGridded(SurfaceExtractionSettingsType settingsType);

		// Token: 0x06000296 RID: 662
		public extern ObjectIdCollection ExtractMajorContours(SurfaceExtractionSettingsType settingsType, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x06000297 RID: 663
		public extern ObjectIdCollection ExtractMajorContours(SurfaceExtractionSettingsType settingsType);

		// Token: 0x06000298 RID: 664
		public extern ObjectIdCollection ExtractMinorContours(SurfaceExtractionSettingsType settingsType, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x06000299 RID: 665
		public extern ObjectIdCollection ExtractMinorContours(SurfaceExtractionSettingsType settingsType);

		// Token: 0x0600029A RID: 666
		public extern ObjectIdCollection ExtractContoursAt(double elevation, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x0600029B RID: 667
		public extern ObjectIdCollection ExtractContoursAt(double elevation);

		// Token: 0x0600029C RID: 668
		public extern ObjectIdCollection ExtractContours(double interval, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x0600029D RID: 669
		public extern ObjectIdCollection ExtractContours(double interval);

		// Token: 0x0600029E RID: 670
		public extern ObjectIdCollection ExtractContours(double lowElev, double highElev, double interval, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x0600029F RID: 671
		public extern ObjectIdCollection ExtractContours(double lowElev, double highElev, double interval);
	}
}
