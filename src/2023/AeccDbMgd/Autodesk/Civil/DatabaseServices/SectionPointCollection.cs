using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DD2 RID: 3538
	public class SectionPointCollection : CivilWrapper<AeccDbSection>, IEnumerable<SectionPoint>
	{
		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06001A37 RID: 6711
		public extern int Count { get; }

		// Token: 0x17000D20 RID: 3360
		public extern SectionPoint this[int index]
		{
			get;
		}

		// Token: 0x06001A39 RID: 6713
		public virtual extern IEnumerator<SectionPoint> GetEnumerator();

		// Token: 0x06001A3A RID: 6714
		public extern IEnumerator GetObjectEnumerator();
	}
}
