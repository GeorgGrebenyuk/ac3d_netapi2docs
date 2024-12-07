using System;

namespace Autodesk.Civil.AeccUiMgd.Roadway
{
	// Token: 0x0200010D RID: 269
	public class CorridorSectionEditorDataEventArgs : EventArgs
	{
		// Token: 0x060000CD RID: 205
		public extern CorridorSectionEditorDataEventArgs(DataEventType eventType);

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CE RID: 206
		public extern DataEventType EventType { get; }

		// Token: 0x04000129 RID: 297
		private int <SyntheticNonEmptyStructMarker>;
	}
}
