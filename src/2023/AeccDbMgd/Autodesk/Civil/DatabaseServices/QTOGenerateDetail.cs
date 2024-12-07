using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001064 RID: 4196
	public class QTOGenerateDetail
	{
		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x0600218B RID: 8587
		public extern int Properties { get; }

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x0600218C RID: 8588
		// (set) Token: 0x0600218D RID: 8589
		public extern QTOReportType ReportType { get; set; }

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x0600218E RID: 8590
		// (set) Token: 0x0600218F RID: 8591
		public extern QTOReportExtent ReportExtent { get; set; }

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06002190 RID: 8592
		// (set) Token: 0x06002191 RID: 8593
		public extern bool ReportSheetOnly { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06002192 RID: 8594
		// (set) Token: 0x06002193 RID: 8595
		public extern ObjectId AlignmentId { get; set; }

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06002194 RID: 8596
		// (set) Token: 0x06002195 RID: 8597
		public extern double StartStation { get; set; }

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06002196 RID: 8598
		// (set) Token: 0x06002197 RID: 8599
		public extern double EndStation { get; set; }

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06002198 RID: 8600
		// (set) Token: 0x06002199 RID: 8601
		public extern bool ReportSelectedPayItemsOnly { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x0600219A RID: 8602
		// (set) Token: 0x0600219B RID: 8603
		public extern ObjectId AlignmentOffsetId { get; set; }

		// Token: 0x0600219C RID: 8604
		public extern QTOGenerateDetail();

		// Token: 0x0400196D RID: 6509
		private int <SyntheticNonEmptyStructMarker>;
	}
}
