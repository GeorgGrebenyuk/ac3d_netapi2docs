using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A77 RID: 2679
	public class SurfaceOperationAddTinFile : SurfaceOperation
	{
		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001427 RID: 5159
		// (set) Token: 0x06001428 RID: 5160
		public extern string TinFileName { get; set; }

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001429 RID: 5161
		public extern double FileSize { get; }
	}
}
