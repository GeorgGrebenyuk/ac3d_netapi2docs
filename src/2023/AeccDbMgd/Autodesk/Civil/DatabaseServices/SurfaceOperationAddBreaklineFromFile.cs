using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A22 RID: 2594
	public class SurfaceOperationAddBreaklineFromFile : SurfaceOperation
	{
		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001395 RID: 5013
		public extern string Description { get; }

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001396 RID: 5014
		// (set) Token: 0x06001397 RID: 5015
		public extern string BreaklineFileName { get; set; }
	}
}
