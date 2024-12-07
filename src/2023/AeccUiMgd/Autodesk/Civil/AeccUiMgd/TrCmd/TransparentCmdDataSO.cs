using System;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd.TrCmd
{
	// Token: 0x0200014D RID: 333
	public class TransparentCmdDataSO : IDisposable
	{
		// Token: 0x06000148 RID: 328
		public extern TransparentCmdDataSO();

		// Token: 0x06000149 RID: 329
		public static extern TransparentCmdDataSO Instance();

		// Token: 0x0600014A RID: 330
		public unsafe extern AeccDocumentDataAeccUiLand* GetDocumentData();

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600014B RID: 331
		public extern bool IsTrCmdSOActive { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600014C RID: 332
		public extern ObservableCollection<string> AlignmentList { get; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600014D RID: 333
		// (set) Token: 0x0600014E RID: 334
		public extern string CurrentAlignment { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600014F RID: 335
		// (set) Token: 0x06000150 RID: 336
		public extern string Station { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000151 RID: 337
		// (set) Token: 0x06000152 RID: 338
		public extern string Offset { get; set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000153 RID: 339
		// (set) Token: 0x06000154 RID: 340
		public extern bool IsOffsetLocked { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000155 RID: 341
		// (set) Token: 0x06000156 RID: 342
		public extern bool IsStationLocked { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000157 RID: 343
		// (remove) Token: 0x06000158 RID: 344
		public extern event TransparentCmdDataSO.TransparentCmdDataSOEventHandler DataChanged;

		// Token: 0x0600015A RID: 346
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x0600015B RID: 347
		public sealed extern void Dispose();

		// Token: 0x0400017E RID: 382
		private int <SyntheticNonEmptyStructMarker>;

		// Token: 0x0200014E RID: 334
		// (Invoke) Token: 0x0600015D RID: 349
		public delegate void TransparentCmdDataSOEventHandler(object sender, TransparentCmdDataSOEventArgs args);
	}
}
