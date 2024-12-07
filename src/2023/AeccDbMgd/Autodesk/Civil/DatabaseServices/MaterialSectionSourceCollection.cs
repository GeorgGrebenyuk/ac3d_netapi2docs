using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020008F6 RID: 2294
	public class MaterialSectionSourceCollection : IEnumerable<MaterialSectionSource>
	{
		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001186 RID: 4486
		public extern int Count { get; }

		// Token: 0x1700072D RID: 1837
		public extern MaterialSectionSource this[int index]
		{
			get;
		}

		// Token: 0x06001188 RID: 4488
		public virtual extern IEnumerator<MaterialSectionSource> GetEnumerator();

		// Token: 0x06001189 RID: 4489
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x040012FE RID: 4862
		private int <SyntheticNonEmptyStructMarker>;
	}
}
