using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009E1 RID: 2529
	public class SurfaceOperationModifyGridPointElevation : SurfaceOperation
	{
		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060012BE RID: 4798
		public extern GridLocation Location { get; }

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060012BF RID: 4799
		public extern double NewElevation { get; }
	}
}
