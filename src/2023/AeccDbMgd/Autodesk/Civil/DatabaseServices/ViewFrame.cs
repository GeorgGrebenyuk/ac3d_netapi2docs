using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200007A RID: 122
	[Wrapper("AeccDbViewFrame")]
	public sealed class ViewFrame : GeoEntity
	{
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000575 RID: 1397
		public extern ObjectId GroupId { get; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000576 RID: 1398
		// (set) Token: 0x06000577 RID: 1399
		public extern ViewFrameLabelLocationType LabelAnchorPosition { get; set; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000578 RID: 1400
		// (set) Token: 0x06000579 RID: 1401
		public extern ObjectId LabelStyleId { get; set; }

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600057A RID: 1402
		// (set) Token: 0x0600057B RID: 1403
		public extern bool IsLabelVisible { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600057C RID: 1404
		public extern ObjectId AlignmentId { get; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600057D RID: 1405
		public extern double StartStation { get; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600057E RID: 1406
		public extern double EndStation { get; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600057F RID: 1407
		public extern string Sheet { get; }

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000580 RID: 1408
		public extern string SheetSet { get; }
	}
}
