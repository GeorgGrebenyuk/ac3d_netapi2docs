using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd.Roadway
{
	// Token: 0x0200010B RID: 267
	public class CorridorStation : IDisposable
	{
		// Token: 0x060000BF RID: 191
		public extern CorridorStation(double dRawStation, string sFormattedStation, StationType eType);

		// Token: 0x060000C0 RID: 192
		public extern CorridorStation();

		// Token: 0x060000C1 RID: 193
		public extern CorridorStation Copy();

		// Token: 0x060000C2 RID: 194
		public override extern string ToString();

		// Token: 0x060000C3 RID: 195
		[return: MarshalAs(UnmanagedType.U1)]
		public override extern bool Equals(object obj);

		// Token: 0x060000C4 RID: 196
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x060000C5 RID: 197
		public sealed extern void Dispose();

		// Token: 0x04000123 RID: 291
		public double m_dRawStation;

		// Token: 0x04000124 RID: 292
		public string m_sFormattedStation;

		// Token: 0x04000125 RID: 293
		public StationType m_eType;
	}
}
