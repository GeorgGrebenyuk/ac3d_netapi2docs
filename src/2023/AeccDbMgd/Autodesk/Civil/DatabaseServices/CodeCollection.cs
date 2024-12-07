using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011B1 RID: 4529
	public sealed class CodeCollection : CivilWrapper<AeccDbEntity>, IEnumerable<string>
	{
		// Token: 0x060025DA RID: 9690
		public extern void Add(string[] codes);

		// Token: 0x060025DB RID: 9691
		public extern void Add(string code);

		// Token: 0x060025DC RID: 9692
		public extern void TryAdd(string[] codes);

		// Token: 0x060025DD RID: 9693
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool TryAdd(string code);

		// Token: 0x060025DE RID: 9694
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool Remove(string code);

		// Token: 0x060025DF RID: 9695
		public extern IEnumerator<string> GetEnumerator();

		// Token: 0x060025E0 RID: 9696
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x170013A8 RID: 5032
		public extern string this[int index]
		{
			get;
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x060025E2 RID: 9698
		public extern int Count { get; }

		// Token: 0x04001AF8 RID: 6904
		private int <SyntheticNonEmptyStructMarker>;
	}
}
