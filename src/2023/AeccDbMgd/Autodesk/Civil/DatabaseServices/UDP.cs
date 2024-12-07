using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000885 RID: 2181
	public class UDP
	{
		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001097 RID: 4247
		public extern string Name { get; }

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001098 RID: 4248
		public extern Guid Guid { get; }

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001099 RID: 4249
		public extern string ClassificationName { get; }

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600109A RID: 4250
		// (set) Token: 0x0600109B RID: 4251
		public extern string Description { get; set; }

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600109C RID: 4252
		// (set) Token: 0x0600109D RID: 4253
		public extern object DefaultValue { get; set; }

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600109E RID: 4254
		// (set) Token: 0x0600109F RID: 4255
		public extern bool UseDefaultValue { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060010A0 RID: 4256
		public extern bool IsInUsed { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x0400128E RID: 4750
		private int <SyntheticNonEmptyStructMarker>;
	}
}
