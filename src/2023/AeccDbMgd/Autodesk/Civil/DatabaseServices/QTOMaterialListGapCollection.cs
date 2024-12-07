using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000836 RID: 2102
	public sealed class QTOMaterialListGapCollection : IEnumerable<QTOMaterialListGap>, IDisposable
	{
		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06000FBD RID: 4029
		public extern int Count { get; }

		// Token: 0x17000686 RID: 1670
		public extern QTOMaterialListGap this[int index]
		{
			get;
		}

		// Token: 0x06000FBF RID: 4031
		public extern QTOMaterialListGap Add(double startStation, double endStation);

		// Token: 0x06000FC0 RID: 4032
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(QTOMaterialListGap materialListGap);

		// Token: 0x06000FC1 RID: 4033
		public extern void RemoveAt(int index);

		// Token: 0x06000FC2 RID: 4034
		public extern IEnumerator<QTOMaterialListGap> GetEnumerator();

		// Token: 0x06000FC3 RID: 4035
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06000FC4 RID: 4036
		public sealed extern void Dispose();

		// Token: 0x04001240 RID: 4672
		private int <SyntheticNonEmptyStructMarker>;
	}
}
