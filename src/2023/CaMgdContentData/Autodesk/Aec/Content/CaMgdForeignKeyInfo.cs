using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Aec.Content
{
	// Token: 0x02000046 RID: 70
	public class CaMgdForeignKeyInfo : IDisposable
	{
		// Token: 0x060000F9 RID: 249
		public unsafe extern CaMgdForeignKeyInfo(CaForeignKeyInfo* foreignKeyInfo);

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FA RID: 250
		public extern string ReferencedTable { get; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FB RID: 251
		public extern string ReferencedColumn { get; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FC RID: 252
		public extern string ReferenceColumn { get; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000FD RID: 253
		public unsafe extern CaForeignKeyInfo* Value { get; }

		// Token: 0x060000FE RID: 254
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x060000FF RID: 255
		public sealed extern void Dispose();

		// Token: 0x06000100 RID: 256
		protected override extern void Finalize();

		// Token: 0x04000466 RID: 1126
		private int <SyntheticNonEmptyStructMarker>;
	}
}
