using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000B16 RID: 2838
	public sealed class SettingsCmdEditFlowSegments : SettingsCatchment
	{
		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x0600153F RID: 5439
		public extern SettingsCmdEditFlowSegments.SettingsCmdSheetFlow SheetFlow { get; }

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001540 RID: 5440
		public extern SettingsCmdEditFlowSegments.SettingsCmdShallowConcentratedFlow ShallowConcentratedFlow { get; }

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001541 RID: 5441
		public extern SettingsCmdEditFlowSegments.SettingsCmdChannelFlow ChannelFlow { get; }

		// Token: 0x02000B17 RID: 2839
		public sealed class SettingsCmdSheetFlow : TreeOidWrapper
		{
			// Token: 0x1700092B RID: 2347
			// (get) Token: 0x06001542 RID: 5442
			public extern PropertyDouble RainIntensity { get; }
		}

		// Token: 0x02000B18 RID: 2840
		public sealed class SettingsCmdShallowConcentratedFlow : TreeOidWrapper
		{
			// Token: 0x1700092C RID: 2348
			// (get) Token: 0x06001543 RID: 5443
			public extern PropertyEnum<CatchmentShallowConcentratedFlowSurfaceType> SurfaceType { get; }
		}

		// Token: 0x02000B19 RID: 2841
		public sealed class SettingsCmdChannelFlow : TreeOidWrapper
		{
			// Token: 0x1700092E RID: 2350
			// (get) Token: 0x06001544 RID: 5444
			public extern PropertyDouble CrossSectionalArea { get; }

			// Token: 0x1700092D RID: 2349
			// (get) Token: 0x06001545 RID: 5445
			public extern PropertyDouble WetPerimeter { get; }
		}
	}
}
