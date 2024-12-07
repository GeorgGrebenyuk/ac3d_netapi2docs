using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E6C RID: 3692
	public sealed class AlignmentTransitionCollection : CivilWrapper<AeccDbAlignment>, IEnumerable<AlignmentTransition>
	{
		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06001C1F RID: 7199
		public extern int Count { get; }

		// Token: 0x17000E1E RID: 3614
		public extern AlignmentTransition this[int index]
		{
			get;
		}

		// Token: 0x06001C21 RID: 7201
		public extern IEnumerator<AlignmentTransition> GetEnumerator();

		// Token: 0x06001C22 RID: 7202
		public extern IEnumerator GetObjectEnumerator();
	}
}
