using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D4B RID: 3403
	public sealed class SettingsCmdAddWidening : SettingsAlignment
	{
		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06001876 RID: 6262
		public extern SettingsCmdAddWidening.SettingsCmdWideningOptions WideningOptions { get; }

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06001877 RID: 6263
		public extern SettingsCmdAddWidening.SettingsCmdLinearTransitionAroundCurves LinearTransitionAroundCurves { get; }

		// Token: 0x02000D4C RID: 3404
		public sealed class SettingsCmdWideningOptions : TreeOidWrapper
		{
			// Token: 0x17000B76 RID: 2934
			// (get) Token: 0x06001878 RID: 6264
			public extern PropertyEnum<TransitionType> TransitionType { get; }

			// Token: 0x17000B75 RID: 2933
			// (get) Token: 0x06001879 RID: 6265
			public extern PropertyEnum<TransitionInputType> TaperInputType { get; }

			// Token: 0x17000B74 RID: 2932
			// (get) Token: 0x0600187A RID: 6266
			public extern PropertyDouble TransitionLength { get; }

			// Token: 0x17000B73 RID: 2931
			// (get) Token: 0x0600187B RID: 6267
			public extern PropertyDouble TaperRatio { get; }

			// Token: 0x17000B72 RID: 2930
			// (get) Token: 0x0600187C RID: 6268
			public extern PropertyDouble RadiusForCurve1 { get; }

			// Token: 0x17000B71 RID: 2929
			// (get) Token: 0x0600187D RID: 6269
			public extern PropertyDouble RadiusForCurve2 { get; }

			// Token: 0x17000B70 RID: 2928
			// (get) Token: 0x0600187E RID: 6270
			public extern PropertyDouble RadiusForCurve3 { get; }

			// Token: 0x17000B6F RID: 2927
			// (get) Token: 0x0600187F RID: 6271
			public extern PropertyDouble WideningOffset { get; }

			// Token: 0x17000B6E RID: 2926
			// (get) Token: 0x06001880 RID: 6272
			public extern PropertyDouble WideningSegmentLength { get; }
		}

		// Token: 0x02000D4D RID: 3405
		public sealed class SettingsCmdLinearTransitionAroundCurves : TreeOidWrapper
		{
			// Token: 0x17000B78 RID: 2936
			// (get) Token: 0x06001881 RID: 6273
			public extern PropertyInt NumberOfSegments { get; }

			// Token: 0x17000B77 RID: 2935
			// (get) Token: 0x06001882 RID: 6274
			public extern PropertyEnum<AlignmentTransitionSegmentType> TransitionSegmentType { get; }
		}
	}
}
