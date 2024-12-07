using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A04 RID: 2564
	public sealed class SurfaceAnalysis : IDisposable
	{
		// Token: 0x06001301 RID: 4865
		public extern SurfaceAnalysisContourData[] GetContourData();

		// Token: 0x06001302 RID: 4866
		public extern void SetContourData(SurfaceAnalysisContourData[] analysisData);

		// Token: 0x06001303 RID: 4867
		public extern SurfaceAnalysisDirectionData[] GetDirectionData();

		// Token: 0x06001304 RID: 4868
		public extern void SetDirectionData(SurfaceAnalysisDirectionData[] analysisData);

		// Token: 0x06001305 RID: 4869
		public extern SurfaceAnalysisElevationData[] GetElevationData();

		// Token: 0x06001306 RID: 4870
		public extern void SetElevationData(SurfaceAnalysisElevationData[] analysisData);

		// Token: 0x06001307 RID: 4871
		public extern SurfaceAnalysisSlopeData[] GetSlopeData();

		// Token: 0x06001308 RID: 4872
		public extern void SetSlopeData(SurfaceAnalysisSlopeData[] analysisData);

		// Token: 0x06001309 RID: 4873
		public extern SurfaceAnalysisSlopeArrowData[] GetSlopeArrowData();

		// Token: 0x0600130A RID: 4874
		public extern void SetSlopeArrowData(SurfaceAnalysisSlopeArrowData[] analysisData);

		// Token: 0x0600130B RID: 4875
		public extern SurfaceAnalysisUserDefinedContourData[] GetUserDefinedContourData();

		// Token: 0x0600130C RID: 4876
		public extern void SetUserDefinedContourData(SurfaceAnalysisUserDefinedContourData[] analysisData);

		// Token: 0x0600130D RID: 4877
		public extern SurfaceAnalysisWatershedDataCollection GetWatershedData();

		// Token: 0x0600130E RID: 4878
		public extern void SetWatershedData(SurfaceAnalysisWatershedDataCollection analysisData);

		// Token: 0x0600130F RID: 4879
		public extern ObjectIdCollection CreateWaterdrop(Point2d location, WaterdropObjectType objectType);

		// Token: 0x06001310 RID: 4880
		public sealed extern void Dispose();

		// Token: 0x040013EE RID: 5102
		private int <SyntheticNonEmptyStructMarker>;
	}
}
