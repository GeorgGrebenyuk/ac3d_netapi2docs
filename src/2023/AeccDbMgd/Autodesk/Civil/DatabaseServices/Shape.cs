using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011BB RID: 4539
	public sealed class Shape : CivilWrapper<AeccDbEntity>
	{
		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x06002612 RID: 9746
		public extern CodeCollection Codes { get; }

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06002613 RID: 9747
		// (set) Token: 0x06002614 RID: 9748
		public extern bool IsHidden { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x06002615 RID: 9749
		public extern LinkCollection Links { get; }

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06002616 RID: 9750
		public extern int Index { get; }

		// Token: 0x06002617 RID: 9751
		public extern void AddHole(Link[] links);

		// Token: 0x04001B05 RID: 6917
		private int <SyntheticNonEmptyStructMarker>;
	}
}
