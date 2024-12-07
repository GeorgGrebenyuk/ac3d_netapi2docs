using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000889 RID: 2185
	public class UDPDouble : UDP
	{
		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060010C4 RID: 4292
		// (set) Token: 0x060010C5 RID: 4293
		public extern AttributeTypeInfoDoubleDataType DataType { get; set; }

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060010C6 RID: 4294
		// (set) Token: 0x060010C7 RID: 4295
		public new extern double DefaultValue { get; set; }

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060010C8 RID: 4296
		// (set) Token: 0x060010C9 RID: 4297
		public extern bool UpperBoundInclusive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060010CA RID: 4298
		// (set) Token: 0x060010CB RID: 4299
		public extern bool LowerBoundInclusive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060010CC RID: 4300
		// (set) Token: 0x060010CD RID: 4301
		public extern double UpperBoundValue { get; set; }

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060010CE RID: 4302
		// (set) Token: 0x060010CF RID: 4303
		public extern double LowerBoundValue { get; set; }

		// Token: 0x04001291 RID: 4753
		private int <SyntheticNonEmptyStructMarker>;
	}
}
