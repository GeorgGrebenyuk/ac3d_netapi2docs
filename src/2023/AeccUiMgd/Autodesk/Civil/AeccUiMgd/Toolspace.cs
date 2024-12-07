using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd
{
	// Token: 0x02000108 RID: 264
	public class Toolspace : PaletteSet
	{
		// Token: 0x060000B9 RID: 185
		public static extern Toolspace Instance();

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000BA RID: 186
		public static extern int RealPalettesCount { get; }

		// Token: 0x060000BB RID: 187
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool PaletteExists(PaletteType pt);

		// Token: 0x060000BC RID: 188
		public extern Toolspace();

		// Token: 0x060000BD RID: 189
		[HandleProcessCorruptedStateExceptions]
		protected override extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x060000BE RID: 190
		protected override extern void Finalize();
	}
}
