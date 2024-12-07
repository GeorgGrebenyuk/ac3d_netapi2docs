using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020008F8 RID: 2296
	public class SectionSourceCollection : IEnumerable<SectionSource>
	{
		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600118F RID: 4495
		public extern int Count { get; }

		// Token: 0x17000731 RID: 1841
		public extern SectionSource this[int index]
		{
			get;
		}

		// Token: 0x06001191 RID: 4497
		public virtual extern IEnumerator<SectionSource> GetEnumerator();

		// Token: 0x06001192 RID: 4498
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001300 RID: 4864
		private int <SyntheticNonEmptyStructMarker>;
	}
}
