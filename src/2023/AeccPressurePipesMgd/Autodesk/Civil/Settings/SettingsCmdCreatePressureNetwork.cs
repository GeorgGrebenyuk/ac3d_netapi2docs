using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x020001BA RID: 442
	public sealed class SettingsCmdCreatePressureNetwork : SettingsPressureNetwork
	{
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060001E1 RID: 481
		[DeprecatedVersion(CivilVersion.Civil2021)]
		[Obsolete("Use SettingsPressureNetwork.Cover instead.", false)]
		public extern SettingsCmdCreatePressureNetwork.SettingsCmdDepthOfCover DepthOfCover { get; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060001E2 RID: 482
		public extern SettingsCmdCreatePressureNetwork.SettingsCmdLabelNewParts LabelNewParts { get; }

		// Token: 0x020001BB RID: 443
		public sealed class SettingsCmdDepthOfCover : TreeOidWrapper
		{
			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x060001E3 RID: 483
			public extern PropertyDouble DepthBelowSurface { get; }
		}

		// Token: 0x020001BC RID: 444
		public sealed class SettingsCmdLabelNewParts : TreeOidWrapper
		{
			// Token: 0x17000101 RID: 257
			// (get) Token: 0x060001E4 RID: 484
			public extern PropertyBoolean PressurePipeInPlan { get; }

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x060001E5 RID: 485
			public extern PropertyBoolean PressurePipeProfile { get; }

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x060001E6 RID: 486
			public extern PropertyBoolean FittingInPlan { get; }

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x060001E7 RID: 487
			public extern PropertyBoolean FittingProfile { get; }

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x060001E8 RID: 488
			public extern PropertyBoolean AppurtenanceInPlan { get; }

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x060001E9 RID: 489
			public extern PropertyBoolean AppurtenanceProfile { get; }

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x060001EA RID: 490
			public extern PropertyBoolean CrossingPressurePipeProfile { get; }

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x060001EB RID: 491
			[Obsolete("Does not work", false)]
			[DeprecatedVersion(CivilVersion.Civil2020)]
			public extern PropertyBoolean CrossingPressurePipeSection { get; }
		}
	}
}
