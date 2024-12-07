using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.DatabaseServices.Styles;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000043 RID: 67
	[Wrapper("AeccDbSurface")]
	public class Surface : Entity
	{
		// Token: 0x060001D2 RID: 466
		public virtual extern GeneralSurfaceProperties GetGeneralProperties();

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001D3 RID: 467
		public extern bool IsVolumeSurface { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x060001D4 RID: 468
		public extern double FindElevationAtXY(double x, double y);

		// Token: 0x060001D5 RID: 469
		public extern double FindSlopeAtXY(double x, double y);

		// Token: 0x060001D6 RID: 470
		public extern double FindDirectionAtXY(double x, double y);

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001D7 RID: 471
		public extern SurfaceAnalysis Analysis { get; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001D8 RID: 472
		public extern SurfaceDefinitionBoundaries BoundariesDefinition { get; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001D9 RID: 473
		public extern SurfaceOperationCollection Operations { get; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001DA RID: 474
		public extern SurfaceBuildOptions BuildOptions { get; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001DB RID: 475
		public extern bool IsOutOfDate { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x060001DC RID: 476
		public extern void Rebuild();

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001DD RID: 477
		public extern bool HasSnapshot { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001DE RID: 478
		public extern bool IsSnapshotOutOfDate { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x060001DF RID: 479
		public extern void CreateSnapshot();

		// Token: 0x060001E0 RID: 480
		public extern void RemoveSnapshot();

		// Token: 0x060001E1 RID: 481
		public extern void RebuildSnapshot();

		// Token: 0x17000086 RID: 134
		// (set) Token: 0x060001E2 RID: 482
		public override extern ObjectId StyleId { set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001E3 RID: 483
		// (set) Token: 0x060001E4 RID: 484
		public extern bool Lock { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001E5 RID: 485
		// (set) Token: 0x060001E6 RID: 486
		public extern bool AutoRebuild { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001E7 RID: 487
		public virtual extern SurfaceMaskCollection Masks { get; }

		// Token: 0x060001E8 RID: 488
		public extern void ExportToDEM(string fileName, string coordinateSystemCode, double gridSpacing, ExportDetermineElevationType deteElevBy);

		// Token: 0x060001E9 RID: 489
		public extern void ExportToDEM(string fileName, string coordinateSystemCode, double gridSpacing, ExportDetermineElevationType deteElevBy, [MarshalAs(UnmanagedType.U1)] bool useCustomNullElevationation, float customNullElevation);

		// Token: 0x060001EA RID: 490
		public extern SurfaceVolumeInfo GetBoundedVolumes(Point3dCollection polygon, double datumElevation);

		// Token: 0x060001EB RID: 491
		public extern SurfaceVolumeInfo GetBoundedVolumes(Point3dCollection polygon);

		// Token: 0x060001EC RID: 492
		public extern Point3d GetIntersectionPoint(Point3d startPoint, Vector3d dir);

		// Token: 0x060001ED RID: 493
		public extern Point3dCollection FindPointsAlongLine(LineSegment3d lineSeg3d);

		// Token: 0x060001EE RID: 494
		protected unsafe static extern void InternalAddCreationGeneralData(AeccLand.AeccSurfaceCreationData* surfaceData, SurfaceType surfaceType, string surfaceName, ObjectId styleId);

		// Token: 0x060001EF RID: 495
		protected unsafe static extern void InternalAddCreationGridData(AeccLand.AeccSurfaceCreationData* surfaceData, double xSpacing, double ySpacing, double orientation);

		// Token: 0x060001F0 RID: 496
		protected unsafe static extern void InternalAddCreationVolumeData(AeccLand.AeccSurfaceCreationData* surfaceData, ObjectId baseSurfaceId, ObjectId comparisonSurfaceId);

		// Token: 0x060001F1 RID: 497
		protected unsafe static extern ObjectId InternalCreateSurface(AeccLand.AeccSurfaceCreationData* surfaceData);

		// Token: 0x060001F2 RID: 498
		protected extern Point3dCollection InternalSampleElevations(Point3d pt1, Point3d pt2);

		// Token: 0x060001F3 RID: 499
		protected extern Point3dCollection InternalSampleElevations(ObjectId curveId);

		// Token: 0x060001F4 RID: 500
		protected extern ObjectIdCollection InternalExtractBorder(SurfaceExtractionSettingsType settingsType);

		// Token: 0x060001F5 RID: 501
		protected extern ObjectIdCollection InternalExtractWatershed(SurfaceExtractionSettingsType settingsType);

		// Token: 0x060001F6 RID: 502
		protected extern ObjectIdCollection InternalExtractGridded(SurfaceExtractionSettingsType settingsType);

		// Token: 0x060001F7 RID: 503
		protected extern ObjectIdCollection InternalExtractMajorContours(SurfaceExtractionSettingsType settingsType, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x060001F8 RID: 504
		protected extern ObjectIdCollection InternalExtractMajorContours(SurfaceExtractionSettingsType settingsType);

		// Token: 0x060001F9 RID: 505
		protected extern ObjectIdCollection InternalExtractMinorContours(SurfaceExtractionSettingsType settingsType, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x060001FA RID: 506
		protected extern ObjectIdCollection InternalExtractMinorContours(SurfaceExtractionSettingsType settingsType);

		// Token: 0x060001FB RID: 507
		protected extern ObjectIdCollection InternalExtractContoursAt(double elevation, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x060001FC RID: 508
		protected extern ObjectIdCollection InternalExtractContoursAt(double elevation);

		// Token: 0x060001FD RID: 509
		protected extern ObjectIdCollection InternalExtractContours(double interval, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x060001FE RID: 510
		protected extern ObjectIdCollection InternalExtractContours(double interval);

		// Token: 0x060001FF RID: 511
		protected extern ObjectIdCollection InternalExtractContours(double lowElev, double highElev, double interval, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x06000200 RID: 512
		protected extern ObjectIdCollection InternalExtractContours(double lowElev, double highElev, double interval);

		// Token: 0x06000201 RID: 513
		protected internal extern Surface(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
