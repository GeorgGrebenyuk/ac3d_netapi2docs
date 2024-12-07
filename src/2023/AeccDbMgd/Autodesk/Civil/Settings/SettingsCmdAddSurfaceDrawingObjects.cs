using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CEE RID: 3310
	public sealed class SettingsCmdAddSurfaceDrawingObjects : SettingsSurface
	{
		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x0600178C RID: 6028
		public extern SettingsCmdAddSurfaceDrawingObjects.SettingsCmdAddDataOptions DataOptions { get; }

		// Token: 0x02000CEF RID: 3311
		public sealed class SettingsCmdAddDataOptions : TreeOidWrapper
		{
			// Token: 0x17000A83 RID: 2691
			// (get) Token: 0x0600178D RID: 6029
			public extern PropertyBoolean HasMaintainedges { get; }
		}
	}
}
