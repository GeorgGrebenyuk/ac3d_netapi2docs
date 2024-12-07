using System;
using System.ComponentModel;
using Autodesk.Civil.DatabaseServices.Styles;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A07 RID: 2567
	public class SurfaceAnalysisContourData : ISurfaceAnalysis
	{
		// Token: 0x06001325 RID: 4901
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe virtual extern void Initialize(AeccDbSurface.ColorValue* codeValue);

		// Token: 0x06001326 RID: 4902
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe virtual extern void Update(AeccDbSurface.ColorValue* codeValue);

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001327 RID: 4903
		// (set) Token: 0x06001328 RID: 4904
		public extern double MinimumElevation { get; set; }

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001329 RID: 4905
		// (set) Token: 0x0600132A RID: 4906
		public extern double MaximumElevation { get; set; }

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x0600132B RID: 4907
		// (set) Token: 0x0600132C RID: 4908
		public extern ContourValues ContourValue { get; set; }

		// Token: 0x0600132D RID: 4909
		public extern SurfaceAnalysisContourData(double minimumElevation, double maximumElevation, ContourValues contourValue);

		// Token: 0x0600132E RID: 4910
		public extern SurfaceAnalysisContourData();

		// Token: 0x040013F1 RID: 5105
		private int <SyntheticNonEmptyStructMarker>;
	}
}
