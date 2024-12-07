using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011AF RID: 4527
	public sealed class Link : CivilWrapper<AeccDbEntity>
	{
		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x060025D3 RID: 9683
		public extern CodeCollection Codes { get; }

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x060025D4 RID: 9684
		// (set) Token: 0x060025D5 RID: 9685
		public extern bool IsHidden { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x060025D6 RID: 9686
		public extern int Index { get; }

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x060025D7 RID: 9687
		public extern PointCollection Points { get; }

		// Token: 0x04001AF7 RID: 6903
		private int <SyntheticNonEmptyStructMarker>;
	}
}
