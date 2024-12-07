using System;
using System.ComponentModel;
using Autodesk.AutoCAD.Colors;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A06 RID: 2566
	public sealed class SurfaceAnalysisElevationData : ISurfaceAnalysis
	{
		// Token: 0x0600131B RID: 4891
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe extern void Initialize(AeccDbSurface.ColorValue* codeValue);

		// Token: 0x0600131C RID: 4892
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe extern void Update(AeccDbSurface.ColorValue* A_0);

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x0600131D RID: 4893
		// (set) Token: 0x0600131E RID: 4894
		public extern double MinimumElevation { get; set; }

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x0600131F RID: 4895
		// (set) Token: 0x06001320 RID: 4896
		public extern double MaximumElevation { get; set; }

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001321 RID: 4897
		// (set) Token: 0x06001322 RID: 4898
		public extern Color Scheme { get; set; }

		// Token: 0x06001323 RID: 4899
		public extern SurfaceAnalysisElevationData(double minimumElevation, double maximumElevation, Color scheme);

		// Token: 0x06001324 RID: 4900
		public extern SurfaceAnalysisElevationData();

		// Token: 0x040013F0 RID: 5104
		private int <SyntheticNonEmptyStructMarker>;
	}
}
