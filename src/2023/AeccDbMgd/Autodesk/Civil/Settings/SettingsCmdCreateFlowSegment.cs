using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000B12 RID: 2834
	public sealed class SettingsCmdCreateFlowSegment : SettingsCatchment
	{
		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001538 RID: 5432
		public extern SettingsCmdCreateFlowSegment.SettingsCmdSheetFlow SheetFlow { get; }

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001539 RID: 5433
		public extern SettingsCmdCreateFlowSegment.SettingsCmdShallowConcentratedFlow ShallowConcentratedFlow { get; }

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x0600153A RID: 5434
		public extern SettingsCmdCreateFlowSegment.SettingsCmdChannelFlow ChannelFlow { get; }

		// Token: 0x02000B13 RID: 2835
		public sealed class SettingsCmdSheetFlow : TreeOidWrapper
		{
			// Token: 0x17000924 RID: 2340
			// (get) Token: 0x0600153B RID: 5435
			public extern PropertyDouble RainIntensity { get; }
		}

		// Token: 0x02000B14 RID: 2836
		public sealed class SettingsCmdShallowConcentratedFlow : TreeOidWrapper
		{
			// Token: 0x17000925 RID: 2341
			// (get) Token: 0x0600153C RID: 5436
			public extern PropertyEnum<CatchmentShallowConcentratedFlowSurfaceType> SurfaceType { get; }
		}

		// Token: 0x02000B15 RID: 2837
		public sealed class SettingsCmdChannelFlow : TreeOidWrapper
		{
			// Token: 0x17000927 RID: 2343
			// (get) Token: 0x0600153D RID: 5437
			public extern PropertyDouble CrossSectionalArea { get; }

			// Token: 0x17000926 RID: 2342
			// (get) Token: 0x0600153E RID: 5438
			public extern PropertyDouble WetPerimeter { get; }
		}
	}
}
