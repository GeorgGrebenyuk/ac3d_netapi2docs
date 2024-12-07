using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D2E RID: 3374
	public sealed class SettingsCmdCreateGradingGroup : SettingsGrading
	{
		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06001833 RID: 6195
		public extern SettingsCmdCreateGradingGroup.SettingsCmdGradingGroupCreation GradingGroupCreation { get; }

		// Token: 0x02000D2F RID: 3375
		public sealed class SettingsCmdGradingGroupCreation : TreeOidWrapper
		{
			// Token: 0x17000B2F RID: 2863
			// (get) Token: 0x06001834 RID: 6196
			public extern PropertyBoolean GradingSurfaceCreation { get; }

			// Token: 0x17000B2E RID: 2862
			// (get) Token: 0x06001835 RID: 6197
			public extern PropertyBoolean UseGroupName { get; }

			// Token: 0x17000B2D RID: 2861
			// (get) Token: 0x06001836 RID: 6198
			public extern PropertyString SurfaceStyle { get; }

			// Token: 0x17000B2C RID: 2860
			// (get) Token: 0x06001837 RID: 6199
			public extern PropertyObjectId SurfaceStyleId { get; }

			// Token: 0x17000B2B RID: 2859
			// (get) Token: 0x06001838 RID: 6200
			public extern PropertyDouble SurfaceTessellationIncrement { get; }

			// Token: 0x17000B2A RID: 2858
			// (get) Token: 0x06001839 RID: 6201
			public extern PropertyDouble SurfaceConeTessellationAngle { get; }
		}
	}
}
