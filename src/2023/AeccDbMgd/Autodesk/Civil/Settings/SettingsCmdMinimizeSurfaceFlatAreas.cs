using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000B27 RID: 2855
	public sealed class SettingsCmdMinimizeSurfaceFlatAreas : SettingsSurface
	{
		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x0600155A RID: 5466
		public extern PropertyBoolean FillGapsInContour { get; }

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x0600155B RID: 5467
		public extern PropertyBoolean SwapEdges { get; }

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x0600155C RID: 5468
		public extern PropertyBoolean AddPointsToFlatTriangles { get; }

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x0600155D RID: 5469
		public extern PropertyBoolean AddPointsToFlatEdges { get; }
	}
}
