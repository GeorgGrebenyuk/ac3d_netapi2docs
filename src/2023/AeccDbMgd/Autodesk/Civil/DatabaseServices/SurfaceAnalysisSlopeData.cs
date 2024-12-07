using System;
using System.ComponentModel;
using Autodesk.AutoCAD.Colors;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A08 RID: 2568
	public sealed class SurfaceAnalysisSlopeData : ISurfaceAnalysis
	{
		// Token: 0x0600132F RID: 4911
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe extern void Initialize(AeccDbSurface.ColorValue* codeValue);

		// Token: 0x06001330 RID: 4912
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe extern void Update(AeccDbSurface.ColorValue* A_0);

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001331 RID: 4913
		// (set) Token: 0x06001332 RID: 4914
		public extern double MinimumSlope { get; set; }

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001333 RID: 4915
		// (set) Token: 0x06001334 RID: 4916
		public extern double MaximumSlope { get; set; }

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001335 RID: 4917
		// (set) Token: 0x06001336 RID: 4918
		public extern Color Scheme { get; set; }

		// Token: 0x06001337 RID: 4919
		public extern SurfaceAnalysisSlopeData(double minimumSlope, double maximumSlope, Color scheme);

		// Token: 0x06001338 RID: 4920
		public extern SurfaceAnalysisSlopeData();

		// Token: 0x040013F2 RID: 5106
		private int <SyntheticNonEmptyStructMarker>;
	}
}
