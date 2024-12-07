using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd
{
	// Token: 0x0200019C RID: 412
	public class WebServiceUtils
	{
		// Token: 0x06000195 RID: 405
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool HasServiceEntitlement();

		// Token: 0x06000196 RID: 406
		public extern WebServiceUtils();
	}
}
