using System;
using System.Collections.Generic;
using System.Reflection;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020008E9 RID: 2281
	[DefaultMember("Item")]
	public sealed class StructureOverrideCollection : GraphOverrideCollection<StructureOverride>
	{
		// Token: 0x06001177 RID: 4471
		public sealed override extern IEnumerator<StructureOverride> GetEnumerator();

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001178 RID: 4472
		// (set) Token: 0x06001179 RID: 4473
		public extern string SplitAt { get; set; }
	}
}
