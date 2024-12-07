using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000FAB RID: 4011
	public sealed class LabelStylesProfileRoot : LabelStylesNode
	{
		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06001FA2 RID: 8098
		public extern LabelStyleCollection CurveLabelStyles { get; }

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06001FA3 RID: 8099
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.LabelStylesProfileRoot.GradeBreakLabelStyles instead.", false)]
		public extern LabelStyleCollection GradeBreadLabelStyles { get; }

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06001FA4 RID: 8100
		public extern LabelStyleCollection GradeBreakLabelStyles { get; }

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06001FA5 RID: 8101
		public extern LabelStyleCollection HorizontalGeometryPointLabelStyles { get; }

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06001FA6 RID: 8102
		public extern LabelStyleCollection LineLabelStyles { get; }

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06001FA7 RID: 8103
		public extern LabelStyleCollection MajorStationLabelStyles { get; }

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06001FA8 RID: 8104
		public extern LabelStyleCollection MinorStationLabelStyles { get; }
	}
}
