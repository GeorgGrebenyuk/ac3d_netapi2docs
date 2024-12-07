using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil
{
	// Token: 0x020011FD RID: 4605
	public sealed class SurveyProjectCollection : DisposableWrapper, IEnumerable<SurveyProject>
	{
		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x060026EC RID: 9964
		// (set) Token: 0x060026ED RID: 9965
		public extern string WorkingFolder { get; set; }

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x060026EE RID: 9966
		public extern int Count { get; }

		// Token: 0x170013E1 RID: 5089
		public extern SurveyProject this[int index]
		{
			get;
		}

		// Token: 0x060026F0 RID: 9968
		public extern IEnumerator<SurveyProject> GetEnumerator();

		// Token: 0x060026F1 RID: 9969
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x060026F2 RID: 9970
		public extern SurveyProject GetItem(string surveyProjectPath);

		// Token: 0x060026F3 RID: 9971
		public extern SurveyProject GetItem(Guid surveyProjectGuid);

		// Token: 0x060026F4 RID: 9972
		public extern SurveyProject GetCurrentProject();
	}
}
