using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Aec.Content
{
	// Token: 0x0200003F RID: 63
	public class CaMgdIFilter : IDisposable
	{
		// Token: 0x060000A1 RID: 161
		public extern string GetPropertyName();

		// Token: 0x060000A2 RID: 162
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool DoFilter(CaMgdContentValue value);

		// Token: 0x060000A3 RID: 163
		public extern string AsString();

		// Token: 0x060000A4 RID: 164
		public unsafe extern CaMgdIFilter(CaIFilter* caIFilter);

		// Token: 0x060000A5 RID: 165
		public unsafe extern CaIFilter* GetFilter();

		// Token: 0x060000A6 RID: 166
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x060000A7 RID: 167
		public sealed extern void Dispose();

		// Token: 0x060000A8 RID: 168
		protected override extern void Finalize();

		// Token: 0x04000460 RID: 1120
		private int <SyntheticNonEmptyStructMarker>;
	}
}
