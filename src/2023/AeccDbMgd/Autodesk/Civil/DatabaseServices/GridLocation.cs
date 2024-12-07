using System;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200004B RID: 75
	public struct GridLocation
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000274 RID: 628
		// (set) Token: 0x06000275 RID: 629
		public extern int ColumnIndex { get; set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000276 RID: 630
		// (set) Token: 0x06000277 RID: 631
		public extern int RowIndex { get; set; }

		// Token: 0x06000278 RID: 632
		public extern GridLocation(int columnIndex, int rowIndex);

		// Token: 0x06000279 RID: 633
		[return: MarshalAs(UnmanagedType.U1)]
		public sealed override extern bool Equals(object obj);

		// Token: 0x040002EC RID: 748
		private int <backing_store>ColumnIndex;

		// Token: 0x040002ED RID: 749
		private int <backing_store>RowIndex;
	}
}
