using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000188 RID: 392
	public sealed class LabelStylesPressurePipeRoot : LabelStylesNode
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600019A RID: 410
		[DeprecatedVersion(CivilVersion.Civil2021)]
		[Obsolete("Use LabelStylePressurePipeRoot.PlanProfileLabelStyles instead.", false)]
		public extern LabelStyleCollection LabelStyles { get; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600019B RID: 411
		public extern LabelStyleCollection PlanProfileLabelStyles { get; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600019C RID: 412
		public extern LabelStyleCollection CrossingSectionLabelStyles { get; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600019D RID: 413
		public extern LabelStyleCollection CrossingProfileLabelStyles { get; }
	}
}
