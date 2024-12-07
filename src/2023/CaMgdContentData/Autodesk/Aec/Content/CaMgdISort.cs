using System;

namespace Autodesk.Aec.Content
{
	// Token: 0x02000048 RID: 72
	public class CaMgdISort
	{
		// Token: 0x0600010C RID: 268
		public extern CaMgdISort();

		// Token: 0x0600010D RID: 269
		public extern CaMgdISort(string propName, CaMgdSortOrder order);

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600010E RID: 270
		// (set) Token: 0x0600010F RID: 271
		public extern string Property { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000110 RID: 272
		// (set) Token: 0x06000111 RID: 273
		public extern CaMgdSortOrder SortOrder { get; set; }

		// Token: 0x04000468 RID: 1128
		private int <SyntheticNonEmptyStructMarker>;
	}
}
