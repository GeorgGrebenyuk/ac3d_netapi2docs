using System;

namespace Autodesk.Civil.Settings
{
	// Token: 0x02001106 RID: 4358
	public sealed class SettingsCmdTakeOff : SettingsQuantityTakeoff
	{
		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06002385 RID: 9093
		public extern SettingsCmdTakeOff.SettingsCmdComputeTakeOff ComputeTakeOffOption { get; }

		// Token: 0x02001107 RID: 4359
		public sealed class SettingsCmdComputeTakeOff : TreeOidWrapper
		{
			// Token: 0x1700126F RID: 4719
			// (get) Token: 0x06002386 RID: 9094
			public extern PropertyEnum<QuantityTakeoffReportType> ReportType { get; }

			// Token: 0x1700126E RID: 4718
			// (get) Token: 0x06002387 RID: 9095
			public extern PropertyEnum<QuantityTakeoffReportExtentType> ReportExtentsType { get; }

			// Token: 0x1700126D RID: 4717
			// (get) Token: 0x06002388 RID: 9096
			public extern PropertyBoolean ReportSelectedPayItemOnly { get; }

			// Token: 0x1700126C RID: 4716
			// (get) Token: 0x06002389 RID: 9097
			public extern PropertyBoolean LimitToAlignmentStation { get; }

			// Token: 0x1700126B RID: 4715
			// (get) Token: 0x0600238A RID: 9098
			public extern PropertyString DefaultReportStyle { get; }

			// Token: 0x1700126A RID: 4714
			// (get) Token: 0x0600238B RID: 9099
			public extern PropertyString DrawingBasedReportTableFont { get; }

			// Token: 0x17001269 RID: 4713
			// (get) Token: 0x0600238C RID: 9100
			public extern PropertyEnum<QuantityTakeoffLengthComputeType> LengthComputeType { get; }

			// Token: 0x17001268 RID: 4712
			// (get) Token: 0x0600238D RID: 9101
			public extern PropertyEnum<QuantityTakeoffPipeLengthType> PipeLengthType { get; }

			// Token: 0x17001267 RID: 4711
			// (get) Token: 0x0600238E RID: 9102
			public extern PropertyBoolean IncludeFormulasInReports { get; }
		}
	}
}
