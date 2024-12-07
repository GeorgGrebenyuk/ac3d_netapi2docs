using System;
using System.Collections.Generic;
using System.Reflection;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000EA6 RID: 3750
	[DefaultMember("Item")]
	public sealed class ProfileOverrideCollection : GraphOverrideCollection<ProfileOverride>
	{
		// Token: 0x06001C7B RID: 7291
		public sealed override extern IEnumerator<ProfileOverride> GetEnumerator();

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06001C7C RID: 7292
		// (set) Token: 0x06001C7D RID: 7293
		public extern string SplitAt { get; set; }
	}
}
