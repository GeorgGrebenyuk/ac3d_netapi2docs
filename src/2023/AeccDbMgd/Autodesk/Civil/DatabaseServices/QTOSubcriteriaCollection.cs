using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000824 RID: 2084
	public sealed class QTOSubcriteriaCollection : IEnumerable<QTOSubcriteria>, IDisposable
	{
		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06000FA1 RID: 4001
		public extern int Count { get; }

		// Token: 0x1700067A RID: 1658
		public extern QTOSubcriteria this[int index]
		{
			get;
		}

		// Token: 0x06000FA3 RID: 4003
		public extern QTOSubcriteria Add(string subcriteriaName);

		// Token: 0x06000FA4 RID: 4004
		public extern void RemoveAt(int index);

		// Token: 0x06000FA5 RID: 4005
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(QTOSubcriteria subcriteria);

		// Token: 0x06000FA6 RID: 4006
		public extern IEnumerator<QTOSubcriteria> GetEnumerator();

		// Token: 0x06000FA7 RID: 4007
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06000FA8 RID: 4008
		public sealed extern void Dispose();

		// Token: 0x0400122B RID: 4651
		private int <SyntheticNonEmptyStructMarker>;
	}
}
