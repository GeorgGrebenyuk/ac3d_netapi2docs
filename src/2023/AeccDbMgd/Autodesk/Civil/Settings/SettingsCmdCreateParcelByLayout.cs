using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D14 RID: 3348
	public sealed class SettingsCmdCreateParcelByLayout : SettingsParcel
	{
		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x060017E8 RID: 6120
		public extern SettingsCmdCreateParcelByLayout.SettingsCmdParcelSizing ParcelSizing { get; }

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x060017E9 RID: 6121
		public extern SettingsCmdCreateParcelByLayout.SettingsCmdPreviewGraphics PreviewGraphics { get; }

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x060017EA RID: 6122
		public extern SettingsCmdCreateParcelByLayout.SettingsCmdAutomaticLayout AutomaticLayout { get; }

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x060017EB RID: 6123
		public extern SettingsCmdCreateParcelByLayout.SettingsCmdConvertFromEntities ConvertFromEntities { get; }

		// Token: 0x02000D15 RID: 3349
		public sealed class SettingsCmdParcelSizing : TreeOidWrapper
		{
			// Token: 0x17000AEB RID: 2795
			// (get) Token: 0x060017EC RID: 6124
			public extern PropertyEnum<ParcelSelectionType> SelectionMethod { get; }

			// Token: 0x17000AEA RID: 2794
			// (get) Token: 0x060017ED RID: 6125
			public extern PropertyDouble MinimumArea { get; }

			// Token: 0x17000AE9 RID: 2793
			// (get) Token: 0x060017EE RID: 6126
			public extern PropertyDouble MinimumFrontage { get; }

			// Token: 0x17000AE8 RID: 2792
			// (get) Token: 0x060017EF RID: 6127
			public extern PropertyBoolean UseMinimumFrontageAtOffset { get; }

			// Token: 0x17000AE7 RID: 2791
			// (get) Token: 0x060017F0 RID: 6128
			public extern PropertyDouble FrontageOffset { get; }

			// Token: 0x17000AE6 RID: 2790
			// (get) Token: 0x060017F1 RID: 6129
			public extern PropertyDouble MinimumWidth { get; }

			// Token: 0x17000AE5 RID: 2789
			// (get) Token: 0x060017F2 RID: 6130
			public extern PropertyDouble MinimumDepth { get; }

			// Token: 0x17000AE4 RID: 2788
			// (get) Token: 0x060017F3 RID: 6131
			public extern PropertyBoolean UseMaximumDepth { get; }

			// Token: 0x17000AE3 RID: 2787
			// (get) Token: 0x060017F4 RID: 6132
			public extern PropertyDouble MaximumDepth { get; }

			// Token: 0x17000AE2 RID: 2786
			// (get) Token: 0x060017F5 RID: 6133
			public extern PropertyEnum<ParcelSolutionType> SolutionPreference { get; }
		}

		// Token: 0x02000D16 RID: 3350
		public sealed class SettingsCmdPreviewGraphics : TreeOidWrapper
		{
			// Token: 0x17000AF1 RID: 2801
			// (get) Token: 0x060017F6 RID: 6134
			public extern PropertyColor FrontageColor { get; }

			// Token: 0x17000AF0 RID: 2800
			// (get) Token: 0x060017F7 RID: 6135
			public extern PropertyColor FrontageOffsetColor { get; }

			// Token: 0x17000AEF RID: 2799
			// (get) Token: 0x060017F8 RID: 6136
			public extern PropertyColor NewParcelColor { get; }

			// Token: 0x17000AEE RID: 2798
			// (get) Token: 0x060017F9 RID: 6137
			public extern PropertyColor MinimumFrontageColor { get; }

			// Token: 0x17000AED RID: 2797
			// (get) Token: 0x060017FA RID: 6138
			public extern PropertyColor MinimumWidthColor { get; }

			// Token: 0x17000AEC RID: 2796
			// (get) Token: 0x060017FB RID: 6139
			public extern PropertyColor MinimumDepthColor { get; }
		}

		// Token: 0x02000D17 RID: 3351
		public sealed class SettingsCmdAutomaticLayout : TreeOidWrapper
		{
			// Token: 0x17000AF3 RID: 2803
			// (get) Token: 0x060017FC RID: 6140
			public extern PropertyBoolean AutomaticMode { get; }

			// Token: 0x17000AF2 RID: 2802
			// (get) Token: 0x060017FD RID: 6141
			public extern PropertyEnum<ParcelRemainderDistributionType> RemainderDistributionType { get; }
		}

		// Token: 0x02000D18 RID: 3352
		public sealed class SettingsCmdConvertFromEntities : TreeOidWrapper
		{
			// Token: 0x17000AF4 RID: 2804
			// (get) Token: 0x060017FE RID: 6142
			public extern PropertyBoolean AutoAddSegmentLabel { get; }
		}
	}
}
