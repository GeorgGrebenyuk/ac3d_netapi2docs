using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020012A5 RID: 4773
	public class UDPCollection : IEnumerable<UDP>
	{
		// Token: 0x170015C0 RID: 5568
		public extern UDP this[int index]
		{
			get;
		}

		// Token: 0x170015C1 RID: 5569
		public extern UDP[] this[Guid guid]
		{
			get;
		}

		// Token: 0x170015C2 RID: 5570
		public extern UDP[] this[string name]
		{
			get;
		}

		// Token: 0x060029E7 RID: 10727
		public extern UDP[] ToArray();

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x060029E8 RID: 10728
		public extern int Count { get; }

		// Token: 0x060029E9 RID: 10729
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Contains(UDP udp);

		// Token: 0x060029EA RID: 10730
		public virtual extern IEnumerator<UDP> GetEnumerator();

		// Token: 0x060029EB RID: 10731
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001BEC RID: 7148
		private int <SyntheticNonEmptyStructMarker>;
	}
}
