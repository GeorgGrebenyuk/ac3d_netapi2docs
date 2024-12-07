using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil
{
	// Token: 0x02001200 RID: 4608
	public sealed class SurveyQuery : DisposableWrapper
	{
		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x060026FA RID: 9978
		public extern string Name { get; }

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x060026FB RID: 9979
		public extern Guid GUID { get; }

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x060026FC RID: 9980
		public extern string Description { get; }
	}
}
