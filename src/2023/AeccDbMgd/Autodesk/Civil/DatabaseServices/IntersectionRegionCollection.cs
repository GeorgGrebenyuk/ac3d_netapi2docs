using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200119C RID: 4508
	public sealed class IntersectionRegionCollection : CivilWrapper<AeccDbIntersection>, IEnumerable<IntersectionRegion>
	{
		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x060025B8 RID: 9656
		public extern int Count { get; }

		// Token: 0x17001391 RID: 5009
		public extern IntersectionRegion this[int index]
		{
			get;
		}

		// Token: 0x060025BA RID: 9658
		public extern IEnumerator<IntersectionRegion> GetEnumerator();

		// Token: 0x060025BB RID: 9659
		public extern IEnumerator GetObjectEnumerator();
	}
}
