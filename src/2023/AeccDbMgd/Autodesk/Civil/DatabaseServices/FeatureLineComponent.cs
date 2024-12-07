using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200116C RID: 4460
	public sealed class FeatureLineComponent : CivilWrapper<AeccDbCorridor>
	{
		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06002505 RID: 9477
		public extern ObjectId CorridorId { get; }

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06002506 RID: 9478
		public extern ObjectId BaselineAlignmentId { get; }

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06002507 RID: 9479
		public extern CorridorFeatureLine FeatureLine { get; }

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06002508 RID: 9480
		// (set) Token: 0x06002509 RID: 9481
		public extern bool IsReversed { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x0600250A RID: 9482
		// (set) Token: 0x0600250B RID: 9483
		public extern double StartStation { get; set; }

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x0600250C RID: 9484
		// (set) Token: 0x0600250D RID: 9485
		public extern double EndStation { get; set; }

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x0600250E RID: 9486
		public extern bool UseStartStation { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x0600250F RID: 9487
		public extern bool UseEndStation { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x04001ABB RID: 6843
		private int <SyntheticNonEmptyStructMarker>;
	}
}
