using System;

namespace Autodesk.Civil.AeccUiMgd.TrCmd
{
	// Token: 0x02000159 RID: 345
	public class TransparentCmdDataPTEventArgs : EventArgs
	{
		// Token: 0x06000160 RID: 352
		public extern TransparentCmdDataPTEventArgs(TrCmdDataPTEventType eventType);

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000161 RID: 353
		public extern TrCmdDataPTEventType EventType { get; }

		// Token: 0x0400018F RID: 399
		private int <SyntheticNonEmptyStructMarker>;
	}
}
