using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000080 RID: 128
	[Wrapper("AeccDbScheduleTableStyle")]
	public sealed class TableStyle : StyleBase
	{
		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060005CB RID: 1483
		public extern TableStyleType TableType { get; }

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060005CC RID: 1484
		// (set) Token: 0x060005CD RID: 1485
		public extern string Title { get; set; }

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060005CE RID: 1486
		// (set) Token: 0x060005CF RID: 1487
		public extern string TitleUnformatted { get; set; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060005D0 RID: 1488
		// (set) Token: 0x060005D1 RID: 1489
		public extern TextJustificationType TitleJustification { get; set; }

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060005D2 RID: 1490
		// (set) Token: 0x060005D3 RID: 1491
		public extern bool RepeatTitleInSplitTables { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060005D4 RID: 1492
		// (set) Token: 0x060005D5 RID: 1493
		public extern bool RepeatHeaderInSplitTables { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060005D6 RID: 1494
		// (set) Token: 0x060005D7 RID: 1495
		public extern bool TransposeSectionViewTable { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060005D8 RID: 1496
		// (set) Token: 0x060005D9 RID: 1497
		public extern bool SortData { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060005DA RID: 1498
		// (set) Token: 0x060005DB RID: 1499
		public extern TableSortingOrderType SortingOrder { get; set; }

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060005DC RID: 1500
		// (set) Token: 0x060005DD RID: 1501
		public extern int SortingColumn { get; set; }

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060005DE RID: 1502
		// (set) Token: 0x060005DF RID: 1503
		public extern bool EnableWordWrapping { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060005E0 RID: 1504
		// (set) Token: 0x060005E1 RID: 1505
		public extern bool MaintainViewOrientation { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060005E2 RID: 1506
		// (set) Token: 0x060005E3 RID: 1507
		public extern string TitleTextStyle { get; set; }

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060005E4 RID: 1508
		// (set) Token: 0x060005E5 RID: 1509
		public extern string HeaderTextStyle { get; set; }

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060005E6 RID: 1510
		// (set) Token: 0x060005E7 RID: 1511
		public extern string DataTextStyle { get; set; }

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060005E8 RID: 1512
		// (set) Token: 0x060005E9 RID: 1513
		public extern double TitleTextHeight { get; set; }

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060005EA RID: 1514
		// (set) Token: 0x060005EB RID: 1515
		public extern double HeaderTextHeight { get; set; }

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060005EC RID: 1516
		// (set) Token: 0x060005ED RID: 1517
		public extern double DataTextHeight { get; set; }

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060005EE RID: 1518
		public extern ColumnStyleCollection ColumnStyles { get; }

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060005EF RID: 1519
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetBorderDisplayStylePlan instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle BorderDisplayStylePlan { get; }

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060005F0 RID: 1520
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetBorderDisplayStyleModel instead.", false)]
		public extern DisplayStyle BorderDisplayStyleModel { get; }

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060005F1 RID: 1521
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetTitleSeparatorDisplayStylePlan instead.", false)]
		public extern DisplayStyle TitleSeparatorDisplayStylePlan { get; }

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060005F2 RID: 1522
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetTitleSeparatorDisplayStyleModel instead.", false)]
		public extern DisplayStyle TitleSeparatorDisplayStyleModel { get; }

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060005F3 RID: 1523
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetHeaderSeparatorDisplayStylePlan instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle HeaderSeparatorDisplayStylePlan { get; }

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060005F4 RID: 1524
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetHeaderSeparatorDisplayStyleModel instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle HeaderSeparatorDisplayStyleModel { get; }

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060005F5 RID: 1525
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetDataSeparatorDisplayStylePlan instead.", false)]
		public extern DisplayStyle DataSeparatorDisplayStylePlan { get; }

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060005F6 RID: 1526
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetDataSeparatorDisplayStyleModel instead.", false)]
		public extern DisplayStyle DataSeparatorDisplayStyleModel { get; }

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060005F7 RID: 1527
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetDataDividerDisplayStylePlan instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle DataDividerDisplayStylePlan { get; }

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060005F8 RID: 1528
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetDataDividerDisplayStyleModel instead.", false)]
		public extern DisplayStyle DataDividerDisplayStyleModel { get; }

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060005F9 RID: 1529
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetTitleAreaFillDisplayStylePlan instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle TitleAreaFillDisplayStylePlan { get; }

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060005FA RID: 1530
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetTitleAreaFillDisplayStyleModel instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle TitleAreaFillDisplayStyleModel { get; }

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060005FB RID: 1531
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetHeaderAreaFillDisplayStylePlan instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle HeaderAreaFillDisplayStylePlan { get; }

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060005FC RID: 1532
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetHeaderAreaFillDisplayStyleModel instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle HeaderAreaFillDisplayStyleModel { get; }

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060005FD RID: 1533
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetDataAreaFillDisplayStylePlan instead.", false)]
		public extern DisplayStyle DataAreaFillDisplayStylePlan { get; }

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060005FE RID: 1534
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetDataAreaFillDisplayStyleModel instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle DataAreaFillDisplayStyleModel { get; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060005FF RID: 1535
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetTitleTextDisplayStylePlan instead.", false)]
		public extern DisplayStyle TitleTextDisplayStylePlan { get; }

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000600 RID: 1536
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetTitleTextDisplayStyleModel instead.", false)]
		public extern DisplayStyle TitleTextDisplayStyleModel { get; }

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000601 RID: 1537
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetHeaderTextDisplayStylePlan instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle HeaderTextDisplayStylePlan { get; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000602 RID: 1538
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetHeaderTextDisplayStyleModel instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2010)]
		public extern DisplayStyle HeaderTextDisplayStyleModel { get; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000603 RID: 1539
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetDataTextDisplayStylePlan instead.", false)]
		public extern DisplayStyle DataTextDisplayStylePlan { get; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000604 RID: 1540
		[DeprecatedVersion(CivilVersion.Civil2010)]
		[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.TableStyle.GetDataTextDisplayStyleModel instead.", false)]
		public extern DisplayStyle DataTextDisplayStyleModel { get; }

		// Token: 0x06000605 RID: 1541
		public extern DisplayStyle GetDisplayStylePlan(TableDisplayStyleType type);

		// Token: 0x06000606 RID: 1542
		public extern DisplayStyle GetDisplayStyleModel(TableDisplayStyleType type);
	}
}
