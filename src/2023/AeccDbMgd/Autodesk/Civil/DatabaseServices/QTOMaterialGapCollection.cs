using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000825 RID: 2085
	public sealed class QTOMaterialGapCollection : IEnumerable<QTOMaterialGap>, IDisposable
	{
		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06000FA9 RID: 4009
		public extern int Count { get; }

		// Token: 0x1700067C RID: 1660
		public extern QTOMaterialGap this[int index]
		{
			get;
		}

		// Token: 0x06000FAB RID: 4011
		public extern IEnumerator<QTOMaterialGap> GetEnumerator();

		// Token: 0x06000FAC RID: 4012
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06000FAD RID: 4013
		public sealed extern void Dispose();

		// Token: 0x0400122C RID: 4652
		private int <SyntheticNonEmptyStructMarker>;
	}
}
