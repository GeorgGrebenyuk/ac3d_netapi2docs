using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A72 RID: 2674
	public class SurfaceOperationAddImxFile : SurfaceOperation
	{
		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x0600141A RID: 5146
		// (set) Token: 0x0600141B RID: 5147
		public extern string ImxFileName { get; set; }

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x0600141C RID: 5148
		// (set) Token: 0x0600141D RID: 5149
		public extern string SurfaceName { get; set; }

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x0600141E RID: 5150
		// (set) Token: 0x0600141F RID: 5151
		public extern string Query { get; set; }

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001420 RID: 5152
		// (set) Token: 0x06001421 RID: 5153
		public extern string GitHash { get; set; }

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001422 RID: 5154
		// (set) Token: 0x06001423 RID: 5155
		public extern bool DoCoordinateConversion { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001424 RID: 5156
		public extern double FileSize { get; }
	}
}
