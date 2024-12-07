using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000EF6 RID: 3830
	public sealed class ProfileViewSplitData : CivilWrapper<AeccDbGraphProfile>
	{
		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06001CB0 RID: 7344
		// (set) Token: 0x06001CB1 RID: 7345
		public extern double SplitStation { get; set; }

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06001CB2 RID: 7346
		// (set) Token: 0x06001CB3 RID: 7347
		public extern double AdjustedDatum { get; set; }

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06001CB4 RID: 7348
		// (set) Token: 0x06001CB5 RID: 7349
		public extern string ProfileViewStyleName { get; set; }

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06001CB6 RID: 7350
		// (set) Token: 0x06001CB7 RID: 7351
		public extern ObjectId ProfileViewStyleId { get; set; }

		// Token: 0x040017C9 RID: 6089
		private int <SyntheticNonEmptyStructMarker>;
	}
}
