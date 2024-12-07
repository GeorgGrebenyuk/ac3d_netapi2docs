using System;
using Autodesk.Civil.DatabaseServices;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02000D51 RID: 3409
	public sealed class SettingsCmdCreateAlignmentLayout : SettingsAlignment
	{
		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06001889 RID: 6281
		public extern SettingsCmdCreateAlignmentLayout.SettingsCmdCurveAndSpiralSettings CurveAndSpiralSettings { get; }

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x0600188A RID: 6282
		public extern SettingsCmdCreateAlignmentLayout.SettingsCmdCurveTessellationOption CurveTessellationOption { get; }

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x0600188B RID: 6283
		public extern SettingsCmdCreateAlignmentLayout.SettingsCmdRegressionGraphOption RegressionGraphOption { get; }

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x0600188C RID: 6284
		public extern SettingsCmdCreateAlignmentLayout.SettingsCmdAlignmentTypeOption AlignmentTypeOption { get; }

		// Token: 0x02000D52 RID: 3410
		public sealed class SettingsCmdCurveAndSpiralSettings : TreeOidWrapper
		{
			// Token: 0x17000B8B RID: 2955
			// (get) Token: 0x0600188D RID: 6285
			public extern PropertyEnum<SpiralType> SpiralType { get; }

			// Token: 0x17000B8A RID: 2954
			// (get) Token: 0x0600188E RID: 6286
			public extern PropertyBoolean UseSpiralIn { get; }

			// Token: 0x17000B89 RID: 2953
			// (get) Token: 0x0600188F RID: 6287
			public extern PropertyDouble SpiralInLength { get; }

			// Token: 0x17000B88 RID: 2952
			// (get) Token: 0x06001890 RID: 6288
			public extern PropertyDouble SpiralInAValue { get; }

			// Token: 0x17000B87 RID: 2951
			// (get) Token: 0x06001891 RID: 6289
			public extern PropertyBoolean UseCurve { get; }

			// Token: 0x17000B86 RID: 2950
			// (get) Token: 0x06001892 RID: 6290
			public extern PropertyDouble CurveRadiusForSCSGroup { get; }

			// Token: 0x17000B85 RID: 2949
			// (get) Token: 0x06001893 RID: 6291
			public extern PropertyBoolean UseSpiralOut { get; }

			// Token: 0x17000B84 RID: 2948
			// (get) Token: 0x06001894 RID: 6292
			public extern PropertyDouble SpiralOutLength { get; }

			// Token: 0x17000B83 RID: 2947
			// (get) Token: 0x06001895 RID: 6293
			public extern PropertyDouble SpiralOutAValue { get; }
		}

		// Token: 0x02000D53 RID: 3411
		public sealed class SettingsCmdCurveTessellationOption : TreeOidWrapper
		{
			// Token: 0x17000B8D RID: 2957
			// (get) Token: 0x06001896 RID: 6294
			public extern PropertyBoolean TessellateCurve { get; }

			// Token: 0x17000B8C RID: 2956
			// (get) Token: 0x06001897 RID: 6295
			public extern PropertyDouble MidOrdinateTolerance { get; }
		}

		// Token: 0x02000D54 RID: 3412
		public sealed class SettingsCmdRegressionGraphOption : TreeOidWrapper
		{
			// Token: 0x17000B8E RID: 2958
			// (get) Token: 0x06001898 RID: 6296
			public extern PropertyBoolean SplineFitForRegressionAnalysisGraph { get; }
		}

		// Token: 0x02000D55 RID: 3413
		public sealed class SettingsCmdAlignmentTypeOption : TreeOidWrapper
		{
			// Token: 0x17000B8F RID: 2959
			// (get) Token: 0x06001899 RID: 6297
			public extern PropertyEnum<AlignmentType> AlignmentType { get; }
		}
	}
}
