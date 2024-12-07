using System;

namespace Autodesk.Civil.AeccUiMgd.TrCmd
{
	// Token: 0x0200014C RID: 332
	public class TransparentCmdDataSOEventArgs : EventArgs
	{
		// Token: 0x06000146 RID: 326
		public extern TransparentCmdDataSOEventArgs(TrCmdDataSOEventType eventType);

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000147 RID: 327
		public extern TrCmdDataSOEventType EventType { get; }

		// Token: 0x0400017D RID: 381
		private int <SyntheticNonEmptyStructMarker>;
	}
}
