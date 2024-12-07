using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A85 RID: 2693
	public class SurfaceOperationMinimizeFlatAreas : SurfaceOperation
	{
		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x0600143A RID: 5178
		public extern SurfaceMinimizeFlatAreaOptions MinimizeFlatAreaOptions { get; }

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x0600143B RID: 5179
		public extern int CountOfAddedPoints { get; }

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x0600143C RID: 5180
		public extern int CountOfRemovedPoints { get; }
	}
}
