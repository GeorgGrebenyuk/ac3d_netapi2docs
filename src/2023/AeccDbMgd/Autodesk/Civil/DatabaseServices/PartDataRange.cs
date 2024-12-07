using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001026 RID: 4134
	public sealed class PartDataRange : IDisposable
	{
		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x060020E3 RID: 8419
		public extern object RangeMax { get; }

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x060020E4 RID: 8420
		public extern object RangeMin { get; }

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x060020E5 RID: 8421
		public extern object RangeDefault { get; }

		// Token: 0x060020E6 RID: 8422
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsValidValue(object value);

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x060020E7 RID: 8423
		public extern PartCatalogDataType DataType { get; }

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x060020E8 RID: 8424
		public extern PartContextType Context { get; }

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x060020E9 RID: 8425
		public extern int Index { get; }

		// Token: 0x060020EA RID: 8426
		public sealed extern void Dispose();

		// Token: 0x0400191B RID: 6427
		private int <SyntheticNonEmptyStructMarker>;
	}
}
