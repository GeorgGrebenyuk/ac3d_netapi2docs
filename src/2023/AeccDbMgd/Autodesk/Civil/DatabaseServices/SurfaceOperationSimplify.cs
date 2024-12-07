using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A8D RID: 2701
	public class SurfaceOperationSimplify : SurfaceOperation
	{
		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001459 RID: 5209
		public extern SurfaceSimplifyOptions SimplifyOptions { get; }

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x0600145A RID: 5210
		public extern int CountOfRemovedPoints { get; }
	}
}
