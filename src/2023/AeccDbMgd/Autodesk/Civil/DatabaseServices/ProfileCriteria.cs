using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E93 RID: 3731
	public sealed class ProfileCriteria : CivilWrapper<AeccDbGraphProfile>
	{
		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06001C58 RID: 7256
		// (set) Token: 0x06001C59 RID: 7257
		public extern ObjectId ProfileId { get; set; }

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06001C5A RID: 7258
		// (set) Token: 0x06001C5B RID: 7259
		public extern string ProfileName { get; set; }

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06001C5C RID: 7260
		public extern HatchCriteriaBoundaryType BoundaryType { get; }

		// Token: 0x04001771 RID: 6001
		private int <SyntheticNonEmptyStructMarker>;
	}
}
