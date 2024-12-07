using System;

namespace Autodesk.Civil.AeccUiMgd.Survey
{
	// Token: 0x02000140 RID: 320
	public class SurveyQueryDataEventArgs : EventArgs
	{
		// Token: 0x06000135 RID: 309
		public extern SurveyQueryDataEventArgs(DataEventType eventType);

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000136 RID: 310
		public extern DataEventType EventType { get; }

		// Token: 0x04000170 RID: 368
		private int <SyntheticNonEmptyStructMarker>;
	}
}
