using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B77 RID: 2935
	public sealed class Point : CivilWrapper<AeccDbEntity>, IPoint
	{
		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x060015E4 RID: 5604
		public extern CodeCollection Codes { get; }

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x060015E5 RID: 5605
		// (set) Token: 0x060015E6 RID: 5606
		public extern bool IsHidden { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x060015E7 RID: 5607
		// (set) Token: 0x060015E8 RID: 5608
		public extern double Station { get; set; }

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x060015E9 RID: 5609
		// (set) Token: 0x060015EA RID: 5610
		public extern double Offset { get; set; }

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x060015EB RID: 5611
		// (set) Token: 0x060015EC RID: 5612
		public extern double Elevation { get; set; }

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x060015ED RID: 5613
		public extern int Index { get; }

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x060015EE RID: 5614
		// (set) Token: 0x060015EF RID: 5615
		public extern bool IsLoopPoint { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x060015F0 RID: 5616
		public extern void GetXYZ(ref double x, ref double y, ref double z);

		// Token: 0x04001505 RID: 5381
		private int <SyntheticNonEmptyStructMarker>;
	}
}
