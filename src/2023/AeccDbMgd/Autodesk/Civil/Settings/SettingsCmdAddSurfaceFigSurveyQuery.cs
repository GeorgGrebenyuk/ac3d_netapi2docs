using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000B2D RID: 2861
	public sealed class SettingsCmdAddSurfaceFigSurveyQuery : SettingsSurface
	{
		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001578 RID: 5496
		public extern SettingsCmdAddSurfaceFigSurveyQuery.SettingsCmdAddDataOptions DataOptions { get; }

		// Token: 0x02000B2E RID: 2862
		public sealed class SettingsCmdAddDataOptions : TreeOidWrapper
		{
			// Token: 0x17000962 RID: 2402
			// (get) Token: 0x06001579 RID: 5497
			public extern PropertyDouble MidOrdinateDistance { get; }
		}
	}
}
