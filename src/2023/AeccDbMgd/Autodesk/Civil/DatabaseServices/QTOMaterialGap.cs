using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000835 RID: 2101
	public sealed class QTOMaterialGap : IDisposable
	{
		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06000FB3 RID: 4019
		// (set) Token: 0x06000FB4 RID: 4020
		public extern bool Applied { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06000FB5 RID: 4021
		public extern double StartStation { get; }

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06000FB6 RID: 4022
		public extern double EndStation { get; }

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06000FB7 RID: 4023
		// (set) Token: 0x06000FB8 RID: 4024
		public extern double RunOutDistance { get; set; }

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06000FB9 RID: 4025
		// (set) Token: 0x06000FBA RID: 4026
		public extern double RunInDistance { get; set; }

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06000FBB RID: 4027
		public extern string Description { get; }

		// Token: 0x06000FBC RID: 4028
		public sealed extern void Dispose();

		// Token: 0x0400123F RID: 4671
		private int <SyntheticNonEmptyStructMarker>;
	}
}
