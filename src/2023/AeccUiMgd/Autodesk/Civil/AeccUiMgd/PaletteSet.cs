using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd
{
	// Token: 0x020000ED RID: 237
	public class PaletteSet : IDisposable
	{
		// Token: 0x0600009C RID: 156
		public extern PaletteSet();

		// Token: 0x0600009D RID: 157
		public unsafe extern void SetPaletteSet(AxUiPltSet* pPaletteSet);

		// Token: 0x0600009E RID: 158
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool PaletteExists(int nKey);

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600009F RID: 159
		public extern bool IsVisible { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060000A0 RID: 160
		// (remove) Token: 0x060000A1 RID: 161
		public extern event PaletteSet.PaletteSetEventHandler StateChanged;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060000A3 RID: 163
		// (remove) Token: 0x060000A4 RID: 164
		public extern event PaletteSet.PaletteEventHandler PaletteAdded;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000A6 RID: 166
		// (remove) Token: 0x060000A7 RID: 167
		public extern event PaletteSet.PaletteEventHandler PaletteRemoved;

		// Token: 0x060000A9 RID: 169
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x060000AA RID: 170
		public sealed extern void Dispose();

		// Token: 0x04000105 RID: 261
		protected PaletteSet.PaletteSetEventHandler m_StateChangedEvent;

		// Token: 0x04000106 RID: 262
		protected PaletteSet.PaletteEventHandler m_PaletteAddedEvent;

		// Token: 0x04000107 RID: 263
		protected PaletteSet.PaletteEventHandler m_PaletteRemovedEvent;

		// Token: 0x04000108 RID: 264
		protected unsafe AxUiPltSet* m_pPaletteSet;

		// Token: 0x04000109 RID: 265
		protected unsafe UnmanagedAxUiPaletteSetEventHandler* m_pUnMgdEventHandler;

		// Token: 0x020000EE RID: 238
		// (Invoke) Token: 0x060000AC RID: 172
		public delegate void PaletteSetEventHandler(object sender, PaletteSetEventArgs args);

		// Token: 0x020000EF RID: 239
		// (Invoke) Token: 0x060000B0 RID: 176
		public delegate void PaletteEventHandler(object sender, PaletteEventArgs args);
	}
}
