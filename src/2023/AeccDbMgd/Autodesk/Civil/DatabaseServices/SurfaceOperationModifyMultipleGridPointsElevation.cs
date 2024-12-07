using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020009E2 RID: 2530
	public class SurfaceOperationModifyMultipleGridPointsElevation : SurfaceOperation
	{
		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060012C0 RID: 4800
		public extern GridLocation[] Locations { get; }

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060012C1 RID: 4801
		public extern double Elevation { get; }

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060012C2 RID: 4802
		public extern bool IsDeltaElevation { [return: MarshalAs(UnmanagedType.U1)] get; }
	}
}
