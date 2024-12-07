using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd.Roadway
{
	// Token: 0x0200010C RID: 268
	public class CorridorBaseline : IDisposable
	{
		// Token: 0x060000C6 RID: 198
		public unsafe extern CorridorBaseline(string sName, uint* nBaselineIndex, uint* nOffsetIndex);

		// Token: 0x060000C7 RID: 199
		public extern CorridorBaseline();

		// Token: 0x060000C8 RID: 200
		public extern CorridorBaseline Copy();

		// Token: 0x060000C9 RID: 201
		public override extern string ToString();

		// Token: 0x060000CA RID: 202
		[return: MarshalAs(UnmanagedType.U1)]
		public override extern bool Equals(object obj);

		// Token: 0x060000CB RID: 203
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x060000CC RID: 204
		public sealed extern void Dispose();

		// Token: 0x04000126 RID: 294
		public string m_sName;

		// Token: 0x04000127 RID: 295
		public uint m_nBaseline;

		// Token: 0x04000128 RID: 296
		public uint m_nOffset;
	}
}
