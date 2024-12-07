using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009DC RID: 2524
	public class SurfaceOperationAddGridPoint : SurfaceOperation
	{
		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060012B8 RID: 4792
		public extern GridLocation Location { get; }

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060012B9 RID: 4793
		public extern double Elevation { get; }
	}
}
