using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CE8 RID: 3304
	public sealed class SettingsCmdAddSurfaceBreaklines : SettingsSurface
	{
		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001779 RID: 6009
		public extern SettingsCmdAddSurfaceBreaklines.SettingsCmdAddDataOptions DataOptions { get; }

		// Token: 0x02000CE9 RID: 3305
		public sealed class SettingsCmdAddDataOptions : TreeOidWrapper
		{
			// Token: 0x17000A75 RID: 2677
			// (get) Token: 0x0600177A RID: 6010
			public extern PropertyDouble WeedingDistance { get; }

			// Token: 0x17000A74 RID: 2676
			// (get) Token: 0x0600177B RID: 6011
			public extern PropertyDouble WeedingAngle { get; }

			// Token: 0x17000A73 RID: 2675
			// (get) Token: 0x0600177C RID: 6012
			public extern PropertyDouble SupplementingDistance { get; }

			// Token: 0x17000A72 RID: 2674
			// (get) Token: 0x0600177D RID: 6013
			public extern PropertyDouble MidOrdinateDistance { get; }

			// Token: 0x17000A71 RID: 2673
			// (get) Token: 0x0600177E RID: 6014
			public extern PropertyBoolean ApplyWeeding { get; }

			// Token: 0x17000A70 RID: 2672
			// (get) Token: 0x0600177F RID: 6015
			public extern PropertyBoolean ApplySupplementing { get; }
		}
	}
}
