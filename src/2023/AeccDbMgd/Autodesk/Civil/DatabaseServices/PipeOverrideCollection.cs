using System;
using System.Collections.Generic;
using System.Reflection;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020008E3 RID: 2275
	[DefaultMember("Item")]
	public sealed class PipeOverrideCollection : GraphOverrideCollection<PipeOverride>
	{
		// Token: 0x0600116A RID: 4458
		public sealed override extern IEnumerator<PipeOverride> GetEnumerator();

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600116B RID: 4459
		// (set) Token: 0x0600116C RID: 4460
		public extern string SplitAt { get; set; }
	}
}
