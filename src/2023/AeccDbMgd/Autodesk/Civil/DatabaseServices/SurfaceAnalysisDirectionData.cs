using System;
using System.ComponentModel;
using Autodesk.AutoCAD.Colors;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A05 RID: 2565
	public sealed class SurfaceAnalysisDirectionData : ISurfaceAnalysis
	{
		// Token: 0x06001311 RID: 4881
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe extern void Initialize(AeccDbSurface.ColorValue* codeValue);

		// Token: 0x06001312 RID: 4882
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe extern void Update(AeccDbSurface.ColorValue* A_0);

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001313 RID: 4883
		// (set) Token: 0x06001314 RID: 4884
		public extern double MinimumDirection { get; set; }

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001315 RID: 4885
		// (set) Token: 0x06001316 RID: 4886
		public extern double MaximumDirection { get; set; }

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001317 RID: 4887
		// (set) Token: 0x06001318 RID: 4888
		public extern Color Scheme { get; set; }

		// Token: 0x06001319 RID: 4889
		public extern SurfaceAnalysisDirectionData(double minimumDirection, double maximumDirection, Color scheme);

		// Token: 0x0600131A RID: 4890
		public extern SurfaceAnalysisDirectionData();

		// Token: 0x040013EF RID: 5103
		private int <SyntheticNonEmptyStructMarker>;
	}
}
