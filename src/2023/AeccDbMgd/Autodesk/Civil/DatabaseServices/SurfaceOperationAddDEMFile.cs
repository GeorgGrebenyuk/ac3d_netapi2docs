using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A2A RID: 2602
	public class SurfaceOperationAddDEMFile : SurfaceOperation
	{
		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060013A6 RID: 5030
		// (set) Token: 0x060013A7 RID: 5031
		public extern string DEMFileName { get; set; }

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060013A8 RID: 5032
		public extern double FileSize { get; }

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060013A9 RID: 5033
		public extern string CoordinateSystemCode { get; }

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060013AA RID: 5034
		public extern bool UseCustomNullElevation { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060013AB RID: 5035
		public extern double CustomeNullElevation { get; }
	}
}
