using System;
using System.Collections.Generic;
using System.Reflection;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200092C RID: 2348
	[DefaultMember("Item")]
	public sealed class SectionOverrideCollection : GraphOverrideCollection<SectionOverride>
	{
		// Token: 0x060011E1 RID: 4577
		public sealed override extern IEnumerator<SectionOverride> GetEnumerator();
	}
}
