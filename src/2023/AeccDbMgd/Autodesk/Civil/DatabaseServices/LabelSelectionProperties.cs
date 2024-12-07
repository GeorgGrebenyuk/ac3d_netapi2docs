using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000070 RID: 112
	public class LabelSelectionProperties : IDisposable
	{
		// Token: 0x060004BC RID: 1212
		public extern LabelSelectionProperties(ObjectIdCollection objIds);

		// Token: 0x060004BD RID: 1213
		public static extern LabelSelectionProperties Instance(ObjectIdCollection objIds);

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060004BE RID: 1214
		public extern bool FlipLabel { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060004BF RID: 1215
		public extern bool ReverseLabel { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060004C0 RID: 1216
		public extern bool ToggleLabelPin { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060004C1 RID: 1217
		public extern bool ResetLabel { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060004C2 RID: 1218
		public extern bool Leader { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060004C3 RID: 1219
		public extern bool LeaderTail { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060004C4 RID: 1220
		public extern bool EditLabelText { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060004C5 RID: 1221
		public extern bool ClearLabelText { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060004C6 RID: 1222
		public extern bool ClearMultiLabelText { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060004C7 RID: 1223
		public extern bool TagLabel { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x060004C8 RID: 1224
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x060004C9 RID: 1225
		public sealed extern void Dispose();

		// Token: 0x04000300 RID: 768
		private int <SyntheticNonEmptyStructMarker>;
	}
}
