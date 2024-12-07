using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000EA8 RID: 3752
	public sealed class ProfileViewSplitDataCollection : CivilWrapper<AeccDbGraphProfile>, IEnumerable<ProfileViewSplitData>
	{
		// Token: 0x17000E4D RID: 3661
		public extern ProfileViewSplitData this[int index]
		{
			get;
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06001C84 RID: 7300
		public extern int Count { get; }

		// Token: 0x06001C85 RID: 7301
		public extern ProfileViewSplitData Add(double rawStation, double datum);

		// Token: 0x06001C86 RID: 7302
		public extern void RemoveAt(int index);

		// Token: 0x06001C87 RID: 7303
		public extern IEnumerator<ProfileViewSplitData> GetEnumerator();

		// Token: 0x06001C88 RID: 7304
		public extern IEnumerator GetObjectEnumerator();
	}
}
