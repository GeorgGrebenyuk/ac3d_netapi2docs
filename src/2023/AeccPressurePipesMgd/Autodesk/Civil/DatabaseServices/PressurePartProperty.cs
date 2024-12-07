using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200012B RID: 299
	public class PressurePartProperty
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000152 RID: 338
		public extern uint Id { get; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000153 RID: 339
		public extern string Name { get; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000154 RID: 340
		public extern string DisplayName { get; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000155 RID: 341
		public extern bool HasValue { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000156 RID: 342
		public extern object Value { get; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000157 RID: 343
		public extern bool IsHidden { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x040001B0 RID: 432
		private int <SyntheticNonEmptyStructMarker>;
	}
}
