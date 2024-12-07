using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D57 RID: 3415
	public sealed class SettingsCmdCreateOffsetAlignment : SettingsAlignment
	{
		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x0600189A RID: 6298
		public extern SettingsCmdCreateOffsetAlignment.SettingsCmdOffsetAlignmentOptions OffsetAlignmentOptions { get; }

		// Token: 0x02000D58 RID: 3416
		public sealed class SettingsCmdOffsetAlignmentOptions : TreeOidWrapper
		{
			// Token: 0x17000B96 RID: 2966
			// (get) Token: 0x0600189B RID: 6299
			public extern PropertyBoolean FromParentAlignmentStart { get; }

			// Token: 0x17000B95 RID: 2965
			// (get) Token: 0x0600189C RID: 6300
			public extern PropertyBoolean ToParentAlignmentEnd { get; }

			// Token: 0x17000B94 RID: 2964
			// (get) Token: 0x0600189D RID: 6301
			public extern PropertyInt NumberOfOffsetsLeftSide { get; }

			// Token: 0x17000B93 RID: 2963
			// (get) Token: 0x0600189E RID: 6302
			public extern PropertyInt NumberOfOffsetsRightSide { get; }

			// Token: 0x17000B92 RID: 2962
			// (get) Token: 0x0600189F RID: 6303
			public extern PropertyDouble IncrementalOffsetValueLeftSide { get; }

			// Token: 0x17000B91 RID: 2961
			// (get) Token: 0x060018A0 RID: 6304
			public extern PropertyDouble IncrementalOffsetValueRightSide { get; }
		}
	}
}
