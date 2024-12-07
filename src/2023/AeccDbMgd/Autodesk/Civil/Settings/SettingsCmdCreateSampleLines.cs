using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D6E RID: 3438
	public sealed class SettingsCmdCreateSampleLines : SettingsSampleLine
	{
		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x060018C3 RID: 6339
		public extern SettingsCmdCreateSampleLines.SettingsCmdSwathWidths SwathWidths { get; }

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x060018C4 RID: 6340
		public extern SettingsCmdCreateSampleLines.SettingsCmdSamplingIncrements SamplingIncrements { get; }

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x060018C5 RID: 6341
		public extern SettingsCmdCreateSampleLines.SettingsCmdAdditionalSampleControls AdditionalSampleControls { get; }

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x060018C6 RID: 6342
		public extern SettingsCmdCreateSampleLines.SettingsCmdMiscellaneous Miscellaneous { get; }

		// Token: 0x02000D6F RID: 3439
		public sealed class SettingsCmdSwathWidths : TreeOidWrapper
		{
			// Token: 0x17000BBE RID: 3006
			// (get) Token: 0x060018C7 RID: 6343
			public extern PropertyDouble LeftSwathWidth { get; }

			// Token: 0x17000BBD RID: 3005
			// (get) Token: 0x060018C8 RID: 6344
			public extern PropertyDouble RightSwathWidth { get; }
		}

		// Token: 0x02000D70 RID: 3440
		public sealed class SettingsCmdSamplingIncrements : TreeOidWrapper
		{
			// Token: 0x17000BC2 RID: 3010
			// (get) Token: 0x060018C9 RID: 6345
			public extern PropertyBoolean UseSamplingIncrements { get; }

			// Token: 0x17000BC1 RID: 3009
			// (get) Token: 0x060018CA RID: 6346
			public extern PropertyDouble IncrementAlongTangents { get; }

			// Token: 0x17000BC0 RID: 3008
			// (get) Token: 0x060018CB RID: 6347
			public extern PropertyDouble IncrementAlongCurves { get; }

			// Token: 0x17000BBF RID: 3007
			// (get) Token: 0x060018CC RID: 6348
			public extern PropertyDouble IncrementAlongSpirals { get; }
		}

		// Token: 0x02000D71 RID: 3441
		public sealed class SettingsCmdAdditionalSampleControls : TreeOidWrapper
		{
			// Token: 0x17000BC8 RID: 3016
			// (get) Token: 0x060018CD RID: 6349
			public extern PropertyBoolean AtRangeStart { get; }

			// Token: 0x17000BC7 RID: 3015
			// (get) Token: 0x060018CE RID: 6350
			public extern PropertyBoolean AtRangeEnd { get; }

			// Token: 0x17000BC6 RID: 3014
			// (get) Token: 0x060018CF RID: 6351
			public extern PropertyBoolean AtHorizontalGeometryPoints { get; }

			// Token: 0x17000BC5 RID: 3013
			// (get) Token: 0x060018D0 RID: 6352
			public extern PropertyBoolean AtSuperelevationCriticalStations { get; }

			// Token: 0x17000BC4 RID: 3012
			// (get) Token: 0x060018D1 RID: 6353
			public extern PropertyBoolean StartRangeAtAlignmentStart { get; }

			// Token: 0x17000BC3 RID: 3011
			// (get) Token: 0x060018D2 RID: 6354
			public extern PropertyBoolean EndRangeAtAlignmentEnd { get; }
		}

		// Token: 0x02000D72 RID: 3442
		public sealed class SettingsCmdMiscellaneous : TreeOidWrapper
		{
			// Token: 0x17000BC9 RID: 3017
			// (get) Token: 0x060018D3 RID: 6355
			public extern PropertyBoolean LockTostation { get; }
		}
	}
}
