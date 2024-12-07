using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DE9 RID: 3561
	public class SampleLineVertexCollection : CivilWrapper<AeccDbSampleLine>, IEnumerable<SampleLineVertex>
	{
		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06001A45 RID: 6725
		public extern int Count { get; }

		// Token: 0x17000D26 RID: 3366
		public extern SampleLineVertex this[int index]
		{
			get;
		}

		// Token: 0x06001A47 RID: 6727
		public virtual extern IEnumerator<SampleLineVertex> GetEnumerator();

		// Token: 0x06001A48 RID: 6728
		public extern IEnumerator GetObjectEnumerator();
	}
}
