using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd.Roadway
{
	// Token: 0x02000137 RID: 311
	public class UiCmdSubAssembly
	{
		// Token: 0x0600012C RID: 300
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool CheckValid(SubassemblyOperationType operationType);

		// Token: 0x0600012D RID: 301
		public extern UiCmdSubAssembly();
	}
}
