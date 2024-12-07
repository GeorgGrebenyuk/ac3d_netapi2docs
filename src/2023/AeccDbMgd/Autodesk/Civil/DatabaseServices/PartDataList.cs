using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001025 RID: 4133
	public sealed class PartDataList : IDisposable
	{
		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x060020DC RID: 8412
		public extern int Count { get; }

		// Token: 0x17001091 RID: 4241
		public extern object this[int index]
		{
			get;
		}

		// Token: 0x060020DE RID: 8414
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsValidValue(object value);

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x060020DF RID: 8415
		public extern PartCatalogDataType DataType { get; }

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x060020E0 RID: 8416
		public extern PartContextType Context { get; }

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x060020E1 RID: 8417
		public extern int Index { get; }

		// Token: 0x060020E2 RID: 8418
		public sealed extern void Dispose();

		// Token: 0x0400191A RID: 6426
		private int <SyntheticNonEmptyStructMarker>;
	}
}
