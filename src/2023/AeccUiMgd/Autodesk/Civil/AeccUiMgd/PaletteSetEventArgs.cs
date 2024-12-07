using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd
{
	// Token: 0x020000EB RID: 235
	public class PaletteSetEventArgs : EventArgs
	{
		// Token: 0x06000098 RID: 152
		public extern PaletteSetEventArgs([MarshalAs(UnmanagedType.U1)] bool bShow);

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000099 RID: 153
		public extern bool Show { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x04000103 RID: 259
		private int <SyntheticNonEmptyStructMarker>;
	}
}
