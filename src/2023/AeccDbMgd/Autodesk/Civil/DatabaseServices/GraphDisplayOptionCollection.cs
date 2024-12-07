using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000729 RID: 1833
	public abstract class GraphDisplayOptionCollection<ItemType> : IEnumerable<ItemType> where ItemType : GraphDisplayOption
	{
		// Token: 0x170005C3 RID: 1475
		public extern ItemType this[int index]
		{
			get;
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06000E53 RID: 3667
		public extern int Count { get; }

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000E54 RID: 3668
		// (set) Token: 0x06000E55 RID: 3669
		public extern string ClipGridAt { get; set; }

		// Token: 0x06000E56 RID: 3670
		public abstract IEnumerator<ItemType> GetEnumerator();

		// Token: 0x06000E57 RID: 3671
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001125 RID: 4389
		protected List<ItemType> m_itemVector;
	}
}
