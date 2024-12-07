using System;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd.TrCmd
{
	// Token: 0x0200015A RID: 346
	public class TransparentCmdDataPT : IDisposable
	{
		// Token: 0x06000162 RID: 354
		public extern TransparentCmdDataPT();

		// Token: 0x06000163 RID: 355
		public static extern TransparentCmdDataPT Instance();

		// Token: 0x06000164 RID: 356
		public unsafe extern AeccDocumentDataAeccUiLand* GetDocumentData();

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000165 RID: 357
		public extern ObservableCollection<string> ProfileViewList { get; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000166 RID: 358
		// (set) Token: 0x06000167 RID: 359
		public extern string CurrentProfileView { get; set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000168 RID: 360
		// (set) Token: 0x06000169 RID: 361
		public extern string PTStation { get; set; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600016A RID: 362
		// (set) Token: 0x0600016B RID: 363
		public extern string PTElevation { get; set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600016C RID: 364
		// (set) Token: 0x0600016D RID: 365
		public extern string PTLength { get; set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600016E RID: 366
		// (set) Token: 0x0600016F RID: 367
		public extern string PTGrade { get; set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000170 RID: 368
		public extern bool IsShowViewportsChecked { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000171 RID: 369
		// (set) Token: 0x06000172 RID: 370
		public extern bool PTLengthChecked { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000173 RID: 371
		// (remove) Token: 0x06000174 RID: 372
		public extern event TransparentCmdDataPT.TransparentCmdDataPTEventHandler DataChanged;

		// Token: 0x06000176 RID: 374
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000177 RID: 375
		public sealed extern void Dispose();

		// Token: 0x04000190 RID: 400
		private int <SyntheticNonEmptyStructMarker>;

		// Token: 0x0200015B RID: 347
		// (Invoke) Token: 0x06000179 RID: 377
		public delegate void TransparentCmdDataPTEventHandler(object sender, TransparentCmdDataPTEventArgs args);
	}
}
