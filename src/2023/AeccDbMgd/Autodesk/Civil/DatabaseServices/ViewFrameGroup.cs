using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200007F RID: 127
	[Wrapper("AeccDbViewFrameGroup")]
	public sealed class ViewFrameGroup : GeoEntity
	{
		// Token: 0x060005BA RID: 1466
		public extern ObjectIdCollection GetMatchLineIds();

		// Token: 0x060005BB RID: 1467
		public extern ObjectIdCollection GetViewFrameIds();

		// Token: 0x060005BC RID: 1468
		public extern ObjectIdCollection GetAvailableViewFrameLabelGroupIds();

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060005BD RID: 1469
		// (set) Token: 0x060005BE RID: 1470
		public extern ViewFrameLabelLocationType DefaultViewFrameLabelAnchorPosition { get; set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060005BF RID: 1471
		// (set) Token: 0x060005C0 RID: 1472
		public extern ObjectId DefaultViewFrameLabelStyleId { get; set; }

		// Token: 0x060005C1 RID: 1473
		public extern ObjectIdCollection GetAvailableMatchLineLabelGroupIds();

		// Token: 0x060005C2 RID: 1474
		public extern ObjectId GetMatchLineLabelGroupIdBySide(EntitySideType side);

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060005C3 RID: 1475
		// (set) Token: 0x060005C4 RID: 1476
		public extern MatchLineLabelLocationType DefaultLeftMatchLineLabelAnchorPosition { get; set; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060005C5 RID: 1477
		// (set) Token: 0x060005C6 RID: 1478
		public extern MatchLineLabelLocationType DefaultRightMatchLineLabelAnchorPosition { get; set; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060005C7 RID: 1479
		// (set) Token: 0x060005C8 RID: 1480
		public extern ObjectId DefaultLeftMatchLineLabelStyleId { get; set; }

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060005C9 RID: 1481
		// (set) Token: 0x060005CA RID: 1482
		public extern ObjectId DefaultRightMatchLineLabelStyleId { get; set; }
	}
}
