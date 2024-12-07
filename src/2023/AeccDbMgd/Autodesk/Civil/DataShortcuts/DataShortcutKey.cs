using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DataShortcuts
{
	// Token: 0x0200003A RID: 58
	public sealed class DataShortcutKey : DisposableWrapper
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000150 RID: 336
		public extern string Name { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000151 RID: 337
		public extern DataShortcutEntityType Type { get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000152 RID: 338
		public extern uint HandleLow { get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000153 RID: 339
		public extern uint HandleHigh { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000154 RID: 340
		public extern string SourceDrawing { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000155 RID: 341
		public extern bool IsSourceDrawingExistent { [return: MarshalAs(UnmanagedType.U1)] get; }
	}
}
