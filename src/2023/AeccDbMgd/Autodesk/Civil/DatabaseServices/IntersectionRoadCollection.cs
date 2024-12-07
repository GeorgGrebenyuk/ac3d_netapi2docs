using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200119B RID: 4507
	public sealed class IntersectionRoadCollection : CivilWrapper<AeccDbIntersection>, IEnumerable<IntersectionRoad>
	{
		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x060025B4 RID: 9652
		public extern int Count { get; }

		// Token: 0x1700138F RID: 5007
		public extern IntersectionRoad this[int index]
		{
			get;
		}

		// Token: 0x060025B6 RID: 9654
		public extern IEnumerator<IntersectionRoad> GetEnumerator();

		// Token: 0x060025B7 RID: 9655
		public extern IEnumerator GetObjectEnumerator();
	}
}
