using System;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000F9C RID: 3996
	public class AlignmentLabelSetItem : BaseLabelSetItem
	{
		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06001F57 RID: 8023
		// (set) Token: 0x06001F58 RID: 8024
		public extern double Increment { get; set; }

		// Token: 0x06001F59 RID: 8025
		public extern Dictionary<AlignmentPointType, bool> GetLabeledAlignmentGeometryPoints();

		// Token: 0x06001F5A RID: 8026
		public extern void SetLabeledAlignmentGeometryPoints(Dictionary<AlignmentPointType, bool> pointTypes);

		// Token: 0x06001F5B RID: 8027
		public extern Dictionary<ProfilePointType, bool> GetLabeledProfileGeometryPoints();

		// Token: 0x06001F5C RID: 8028
		public extern void SetLabeledProfileGeometryPoints(Dictionary<ProfilePointType, bool> pointTypes);

		// Token: 0x06001F5D RID: 8029
		public extern Dictionary<SuperelevationPointType, bool> GetLabeledSuperelevationTransitionPoints();

		// Token: 0x06001F5E RID: 8030
		public extern void SetLabeledSuperelevationTransitionPoints(Dictionary<SuperelevationPointType, bool> pointTypes);
	}
}
