using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011A7 RID: 4519
	public sealed class IntersectionRoad : CivilWrapper<AeccDbIntersection>
	{
		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x060025C8 RID: 9672
		public extern ObjectId CenterlineAlignmentId { get; }

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x060025C9 RID: 9673
		public extern ObjectId CenterlineProfileId { get; }

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x060025CA RID: 9674
		public extern ObjectId OffsetLeftAlignmentId { get; }

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x060025CB RID: 9675
		public extern ObjectId OffsetLeftProfileId { get; }

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x060025CC RID: 9676
		public extern ObjectId OffsetRightAlignmentId { get; }

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x060025CD RID: 9677
		public extern ObjectId OffsetRightProfileId { get; }

		// Token: 0x04001AF0 RID: 6896
		private int <SyntheticNonEmptyStructMarker>;
	}
}
