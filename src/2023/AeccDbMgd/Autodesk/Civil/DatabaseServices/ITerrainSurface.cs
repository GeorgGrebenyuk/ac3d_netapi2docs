using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.Civil.DatabaseServices.Styles;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000046 RID: 70
	public interface ITerrainSurface
	{
		// Token: 0x06000204 RID: 516
		TerrainSurfaceProperties GetTerrainProperties();

		// Token: 0x06000205 RID: 517
		SurfaceOperationRaise RaiseSurface(double deltaElevation);

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000206 RID: 518
		SurfaceDefinitionDEMFiles DEMFilesDefinition { get; }

		// Token: 0x06000207 RID: 519
		ObjectIdCollection ExtractBorder(SurfaceExtractionSettingsType settingsType);

		// Token: 0x06000208 RID: 520
		ObjectIdCollection ExtractWatershed(SurfaceExtractionSettingsType settingsType);

		// Token: 0x06000209 RID: 521
		ObjectIdCollection ExtractGridded(SurfaceExtractionSettingsType settingsType);

		// Token: 0x0600020A RID: 522
		ObjectIdCollection ExtractMajorContours(SurfaceExtractionSettingsType settingsType, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x0600020B RID: 523
		ObjectIdCollection ExtractMajorContours(SurfaceExtractionSettingsType settingsType);

		// Token: 0x0600020C RID: 524
		ObjectIdCollection ExtractMinorContours(SurfaceExtractionSettingsType settingsType, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x0600020D RID: 525
		ObjectIdCollection ExtractMinorContours(SurfaceExtractionSettingsType settingsType);

		// Token: 0x0600020E RID: 526
		ObjectIdCollection ExtractContoursAt(double elevation, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x0600020F RID: 527
		ObjectIdCollection ExtractContoursAt(double elevation);

		// Token: 0x06000210 RID: 528
		ObjectIdCollection ExtractContours(double interval, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x06000211 RID: 529
		ObjectIdCollection ExtractContours(double interval);

		// Token: 0x06000212 RID: 530
		ObjectIdCollection ExtractContours(double lowElev, double highElev, double interval, ContourSmoothingType smoothType, int smoothFactor);

		// Token: 0x06000213 RID: 531
		ObjectIdCollection ExtractContours(double lowElev, double highElev, double interval);

		// Token: 0x06000214 RID: 532
		Point3dCollection SampleElevations(ObjectId curveId);
	}
}
