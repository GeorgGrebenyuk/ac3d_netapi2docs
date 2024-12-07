using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000888 RID: 2184
	public class AttributeTypeInfoDouble : AttributeTypeInfo
	{
		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060010B5 RID: 4277
		// (set) Token: 0x060010B6 RID: 4278
		public extern AttributeTypeInfoDoubleDataType DataType { get; set; }

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060010B7 RID: 4279
		// (set) Token: 0x060010B8 RID: 4280
		public new extern double DefaultValue { get; set; }

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060010B9 RID: 4281
		// (set) Token: 0x060010BA RID: 4282
		public extern bool UpperBoundInclusive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060010BB RID: 4283
		// (set) Token: 0x060010BC RID: 4284
		public extern bool LowerBoundInclusive { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060010BD RID: 4285
		// (set) Token: 0x060010BE RID: 4286
		public extern double UpperBoundValue { get; set; }

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060010BF RID: 4287
		// (set) Token: 0x060010C0 RID: 4288
		public extern double LowerBoundValue { get; set; }

		// Token: 0x060010C1 RID: 4289
		public extern AttributeTypeInfoDouble(string name, AttributeTypeInfoDoubleDataType dataType);

		// Token: 0x060010C2 RID: 4290
		public extern AttributeTypeInfoDouble(string name);

		// Token: 0x060010C3 RID: 4291
		protected override extern object getValidDefaultValue(object defaultValue);

		// Token: 0x04001290 RID: 4752
		private int <SyntheticNonEmptyStructMarker>;
	}
}
