using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200086D RID: 2157
	public class StandardPointGroupQuery : PointGroupQuery
	{
		// Token: 0x0600104E RID: 4174
		public extern StandardPointGroupQuery();

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x0600104F RID: 4175
		// (set) Token: 0x06001050 RID: 4176
		public extern bool IncludeAllPoints { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001051 RID: 4177
		// (set) Token: 0x06001052 RID: 4178
		public extern string IncludeNumbers { get; set; }

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001053 RID: 4179
		// (set) Token: 0x06001054 RID: 4180
		public extern string ExcludeNumbers { get; set; }

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001055 RID: 4181
		// (set) Token: 0x06001056 RID: 4182
		public extern string IncludeElevations { get; set; }

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001057 RID: 4183
		// (set) Token: 0x06001058 RID: 4184
		public extern string ExcludeElevations { get; set; }

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001059 RID: 4185
		// (set) Token: 0x0600105A RID: 4186
		public extern string IncludeNames { get; set; }

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x0600105B RID: 4187
		// (set) Token: 0x0600105C RID: 4188
		public extern string ExcludeNames { get; set; }

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x0600105D RID: 4189
		// (set) Token: 0x0600105E RID: 4190
		public extern string IncludeRawDescriptions { get; set; }

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x0600105F RID: 4191
		// (set) Token: 0x06001060 RID: 4192
		public extern string ExcludeRawDescriptions { get; set; }

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001061 RID: 4193
		// (set) Token: 0x06001062 RID: 4194
		public extern string IncludeFullDescriptions { get; set; }

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001063 RID: 4195
		// (set) Token: 0x06001064 RID: 4196
		public extern string ExcludeFullDescriptions { get; set; }

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001065 RID: 4197
		public extern IList<string> PointGroups { get; }

		// Token: 0x06001066 RID: 4198
		protected override extern void loadQuery();

		// Token: 0x06001067 RID: 4199
		protected override extern void saveQuery();

		// Token: 0x04001273 RID: 4723
		private int <SyntheticNonEmptyStructMarker>;
	}
}
