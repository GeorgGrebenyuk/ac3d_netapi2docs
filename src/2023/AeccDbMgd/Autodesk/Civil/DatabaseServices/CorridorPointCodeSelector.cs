using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000EC RID: 236
	public class CorridorPointCodeSelector : IEnumerable<CorridorPointCodeOption>
	{
		// Token: 0x17000492 RID: 1170
		public extern CorridorPointCodeOption this[int index]
		{
			get;
		}

		// Token: 0x17000493 RID: 1171
		public extern CorridorPointCodeOption this[string name]
		{
			get;
		}

		// Token: 0x06000AA0 RID: 2720
		public extern void SelectAll();

		// Token: 0x06000AA1 RID: 2721
		public extern void UnSelectAll();

		// Token: 0x06000AA2 RID: 2722
		public extern string[] GetAllCodes();

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000AA3 RID: 2723
		public extern int Count { get; }

		// Token: 0x06000AA4 RID: 2724
		public virtual extern IEnumerator<CorridorPointCodeOption> GetEnumerator();

		// Token: 0x06000AA5 RID: 2725
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06000AA6 RID: 2726
		public extern CorridorPointCodeSelector(Corridor corridor);

		// Token: 0x04000315 RID: 789
		private int <SyntheticNonEmptyStructMarker>;
	}
}
