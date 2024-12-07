using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil
{
	// Token: 0x020011FC RID: 4604
	public sealed class SurveyQueryCollection : DisposableWrapper, IEnumerable<SurveyQuery>
	{
		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x060026E6 RID: 9958
		public extern int Count { get; }

		// Token: 0x170013DF RID: 5087
		public extern SurveyQuery this[int index]
		{
			get;
		}

		// Token: 0x060026E8 RID: 9960
		public extern IEnumerator<SurveyQuery> GetEnumerator();

		// Token: 0x060026E9 RID: 9961
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x060026EA RID: 9962
		public extern ArrayList GetItem(string queryName);

		// Token: 0x060026EB RID: 9963
		public extern SurveyQuery GetItem(Guid queryGuid);

		// Token: 0x04001B35 RID: 6965
		private int <SyntheticNonEmptyStructMarker>;
	}
}
