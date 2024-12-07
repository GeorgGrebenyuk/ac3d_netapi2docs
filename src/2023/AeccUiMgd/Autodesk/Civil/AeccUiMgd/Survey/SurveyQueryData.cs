using System;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.AeccUiMgd.Survey
{
	// Token: 0x02000141 RID: 321
	public class SurveyQueryData : IDisposable
	{
		// Token: 0x06000137 RID: 311
		public extern SurveyQueryData();

		// Token: 0x06000138 RID: 312
		public static extern SurveyQueryData Instance();

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000139 RID: 313
		// (set) Token: 0x0600013A RID: 314
		public extern SurveyQuery CurrentQuery { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600013B RID: 315
		public extern ObservableCollection<SurveyQuery> QueryList { get; }

		// Token: 0x0600013C RID: 316
		public extern SurveyQuery getCurrentQuery();

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600013D RID: 317
		// (remove) Token: 0x0600013E RID: 318
		public extern event SurveyQueryData.SurveyQueryDataEventHandler DataChanged;

		// Token: 0x06000140 RID: 320
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000141 RID: 321
		public sealed extern void Dispose();

		// Token: 0x04000171 RID: 369
		private int <SyntheticNonEmptyStructMarker>;

		// Token: 0x02000142 RID: 322
		// (Invoke) Token: 0x06000143 RID: 323
		public delegate void SurveyQueryDataEventHandler(object sender, SurveyQueryDataEventArgs args);
	}
}
