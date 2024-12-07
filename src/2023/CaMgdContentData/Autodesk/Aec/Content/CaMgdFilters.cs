using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Aec.Content
{
	// Token: 0x02000041 RID: 65
	public class CaMgdFilters : IDisposable
	{
		// Token: 0x060000AC RID: 172
		public extern CaMgdFilters();

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000AD RID: 173
		public extern int Size { get; }

		// Token: 0x060000AE RID: 174
		public extern void Remove(CaMgdIFilter A_0);

		// Token: 0x060000AF RID: 175
		public extern void AddFilter(CaMgdIFilter A_0);

		// Token: 0x1700000E RID: 14
		public extern CaMgdIFilter this[int A_0]
		{
			get;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000B1 RID: 177
		public unsafe extern CaFilters* Value { get; }

		// Token: 0x060000B2 RID: 178
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x060000B3 RID: 179
		public sealed extern void Dispose();

		// Token: 0x060000B4 RID: 180
		protected override extern void Finalize();

		// Token: 0x04000461 RID: 1121
		private int <SyntheticNonEmptyStructMarker>;
	}
}
