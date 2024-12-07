using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000055 RID: 85
	public class StackedProfileViewsCreationOptions
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000373 RID: 883
		// (set) Token: 0x06000374 RID: 884
		public extern int NumberOfViews { get; set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000375 RID: 885
		// (set) Token: 0x06000376 RID: 886
		public extern double GapBetweenViews { get; set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000377 RID: 887
		// (set) Token: 0x06000378 RID: 888
		public extern ObjectId TopViewStyleId { get; set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000379 RID: 889
		// (set) Token: 0x0600037A RID: 890
		public extern ObjectId MiddleViewStyleId { get; set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600037B RID: 891
		// (set) Token: 0x0600037C RID: 892
		public extern ObjectId BottomViewStyleId { get; set; }

		// Token: 0x0600037D RID: 893
		public extern StackedProfileViewsCreationOptions(ObjectId topViewStyleId, ObjectId middleViewStyleId, ObjectId bottomViewStyleId);

		// Token: 0x040002F6 RID: 758
		private int <SyntheticNonEmptyStructMarker>;
	}
}
