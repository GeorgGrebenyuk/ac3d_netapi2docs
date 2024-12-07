using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd.Survey
{
	// Token: 0x0200013F RID: 319
	public class SurveyQuery : IDisposable
	{
		// Token: 0x0600012E RID: 302
		public unsafe extern SurveyQuery(string sName, uint* nId);

		// Token: 0x0600012F RID: 303
		public extern SurveyQuery();

		// Token: 0x06000130 RID: 304
		public extern SurveyQuery Copy();

		// Token: 0x06000131 RID: 305
		public override extern string ToString();

		// Token: 0x06000132 RID: 306
		[return: MarshalAs(UnmanagedType.U1)]
		public override extern bool Equals(object obj);

		// Token: 0x06000133 RID: 307
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000134 RID: 308
		public sealed extern void Dispose();

		// Token: 0x0400016E RID: 366
		public string m_sName;

		// Token: 0x0400016F RID: 367
		public uint m_nId;
	}
}
