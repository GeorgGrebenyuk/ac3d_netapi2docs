using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200007C RID: 124
	[Wrapper("AeccDbMatchLine")]
	public sealed class MatchLine : GeoEntity
	{
		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000586 RID: 1414
		public extern ObjectId GroupId { get; }

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000587 RID: 1415
		// (set) Token: 0x06000588 RID: 1416
		public extern MatchLineLabelLocationType LeftLabelAnchorPosition { get; set; }

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000589 RID: 1417
		// (set) Token: 0x0600058A RID: 1418
		public extern MatchLineLabelLocationType RightLabelAnchorPosition { get; set; }

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600058B RID: 1419
		// (set) Token: 0x0600058C RID: 1420
		public extern ObjectId LeftLabelStyleId { get; set; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600058D RID: 1421
		// (set) Token: 0x0600058E RID: 1422
		public extern ObjectId RightLabelStyleId { get; set; }

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600058F RID: 1423
		// (set) Token: 0x06000590 RID: 1424
		public extern bool IsLeftLabelVisible { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000591 RID: 1425
		// (set) Token: 0x06000592 RID: 1426
		public extern bool IsRightLabelVisible { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000593 RID: 1427
		public extern ObjectId AlignmentId { get; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000594 RID: 1428
		public extern double Station { get; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000595 RID: 1429
		public extern int Number { get; }
	}
}
