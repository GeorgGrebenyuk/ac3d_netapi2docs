using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000721 RID: 1825
	public abstract class GraphOverrideCollection<ItemType> : IEnumerable<ItemType>, IDisposable where ItemType : GraphOverride
	{
		// Token: 0x170005BA RID: 1466
		public extern ItemType this[int index]
		{
			get;
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000E3E RID: 3646
		public extern int Count { get; }

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000E3F RID: 3647
		// (set) Token: 0x06000E40 RID: 3648
		public extern string ClipGridAt { get; set; }

		// Token: 0x06000E41 RID: 3649
		public abstract IEnumerator<ItemType> GetEnumerator();

		// Token: 0x06000E42 RID: 3650
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06000E43 RID: 3651
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06000E44 RID: 3652
		public sealed extern void Dispose();

		// Token: 0x06000E45 RID: 3653
		protected override extern void Finalize();

		// Token: 0x0400111F RID: 4383
		protected unsafe vector<AeccDbGraphOverrideData\u0020*,std::allocator<AeccDbGraphOverrideData\u0020*>\u0020>* m_dataVector;
	}
}
