using System;
using System.ComponentModel;
using Autodesk.AutoCAD.Colors;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A09 RID: 2569
	public sealed class SurfaceAnalysisSlopeArrowData : ISurfaceAnalysis
	{
		// Token: 0x06001339 RID: 4921
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe extern void Initialize(AeccDbSurface.ColorValue* codeValue);

		// Token: 0x0600133A RID: 4922
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe extern void Update(AeccDbSurface.ColorValue* A_0);

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x0600133B RID: 4923
		// (set) Token: 0x0600133C RID: 4924
		public extern double MinimumSlope { get; set; }

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x0600133D RID: 4925
		// (set) Token: 0x0600133E RID: 4926
		public extern double MaximumSlope { get; set; }

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x0600133F RID: 4927
		// (set) Token: 0x06001340 RID: 4928
		public extern Color Scheme { get; set; }

		// Token: 0x06001341 RID: 4929
		public extern SurfaceAnalysisSlopeArrowData(double minimumSlope, double maximumSlope, Color scheme);

		// Token: 0x06001342 RID: 4930
		public extern SurfaceAnalysisSlopeArrowData();

		// Token: 0x040013F3 RID: 5107
		private int <SyntheticNonEmptyStructMarker>;
	}
}
