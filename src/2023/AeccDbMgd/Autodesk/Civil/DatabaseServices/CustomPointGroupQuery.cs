using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200085D RID: 2141
	public class CustomPointGroupQuery : PointGroupQuery
	{
		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001039 RID: 4153
		// (set) Token: 0x0600103A RID: 4154
		public new extern string QueryString { get; set; }

		// Token: 0x0600103B RID: 4155
		protected override extern void loadQuery();

		// Token: 0x0600103C RID: 4156
		protected override extern void saveQuery();

		// Token: 0x0600103D RID: 4157
		public extern CustomPointGroupQuery();
	}
}
