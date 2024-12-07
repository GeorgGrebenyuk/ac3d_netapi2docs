using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000CE6 RID: 3302
	public sealed class SettingsCmdAddSurfaceBoundaries : SettingsSurface
	{
		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001775 RID: 6005
		public extern SettingsCmdAddSurfaceBoundaries.SettingsCmdAddDataOptions DataOptions { get; }

		// Token: 0x02000CE7 RID: 3303
		public sealed class SettingsCmdAddDataOptions : TreeOidWrapper
		{
			// Token: 0x17000A6E RID: 2670
			// (get) Token: 0x06001776 RID: 6006
			public extern PropertyDouble MidOrdinateDistance { get; }

			// Token: 0x17000A6D RID: 2669
			// (get) Token: 0x06001777 RID: 6007
			public extern PropertyEnum<SurfaceBoundaryType> BoundaryType { get; }

			// Token: 0x17000A6C RID: 2668
			// (get) Token: 0x06001778 RID: 6008
			public extern PropertyBoolean NonDestructive { get; }
		}
	}
}
