using System;
using System.Runtime.InteropServices;
using Autodesk.Aec.DatabaseServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200013F RID: 319
	[Wrapper("AeccDbPointDescKey2")]
	public class PointDescriptionKey : DBObject
	{
		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000D89 RID: 3465
		// (set) Token: 0x06000D8A RID: 3466
		public extern string Code { get; set; }

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000D8B RID: 3467
		// (set) Token: 0x06000D8C RID: 3468
		public extern bool ApplyStyleId { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000D8D RID: 3469
		// (set) Token: 0x06000D8E RID: 3470
		public extern ObjectId StyleId { get; set; }

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000D8F RID: 3471
		// (set) Token: 0x06000D90 RID: 3472
		public extern bool ApplyLabelStyleId { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000D91 RID: 3473
		// (set) Token: 0x06000D92 RID: 3474
		public extern ObjectId LabelStyleId { get; set; }

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000D93 RID: 3475
		// (set) Token: 0x06000D94 RID: 3476
		public extern string Format { get; set; }

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000D95 RID: 3477
		// (set) Token: 0x06000D96 RID: 3478
		public extern bool ApplyLayerId { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000D97 RID: 3479
		// (set) Token: 0x06000D98 RID: 3480
		public extern ObjectId LayerId { get; set; }

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000D99 RID: 3481
		// (set) Token: 0x06000D9A RID: 3482
		public extern bool ApplyScaleParameter { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000D9B RID: 3483
		// (set) Token: 0x06000D9C RID: 3484
		public extern int ScaleParameter { get; set; }

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000D9D RID: 3485
		// (set) Token: 0x06000D9E RID: 3486
		public extern bool ApplyFixedScaleFactor { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000D9F RID: 3487
		// (set) Token: 0x06000DA0 RID: 3488
		public extern double FixedScaleFactor { get; set; }

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000DA1 RID: 3489
		// (set) Token: 0x06000DA2 RID: 3490
		public extern bool ApplyDrawingScale { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000DA3 RID: 3491
		// (set) Token: 0x06000DA4 RID: 3492
		public extern bool ApplyScaleXY { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000DA5 RID: 3493
		// (set) Token: 0x06000DA6 RID: 3494
		public extern bool ApplyScaleZ { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000DA7 RID: 3495
		// (set) Token: 0x06000DA8 RID: 3496
		public extern bool ApplyMarkerRotationParameter { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000DA9 RID: 3497
		// (set) Token: 0x06000DAA RID: 3498
		public extern int MarkerRotationParameter { get; set; }

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000DAB RID: 3499
		// (set) Token: 0x06000DAC RID: 3500
		public extern bool ApplyFixedMarkerRotation { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000DAD RID: 3501
		// (set) Token: 0x06000DAE RID: 3502
		public extern double FixedMarkerRotation { get; set; }

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000DAF RID: 3503
		// (set) Token: 0x06000DB0 RID: 3504
		public extern bool ApplyLabelRotationParameter { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000DB1 RID: 3505
		// (set) Token: 0x06000DB2 RID: 3506
		public extern int LabelRotationParameter { get; set; }

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000DB3 RID: 3507
		// (set) Token: 0x06000DB4 RID: 3508
		public extern bool ApplyFixedLabelRotation { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000DB5 RID: 3509
		// (set) Token: 0x06000DB6 RID: 3510
		public extern double FixedLabelRotation { get; set; }

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000DB7 RID: 3511
		// (set) Token: 0x06000DB8 RID: 3512
		public extern RotationDirType RotationDirection { get; set; }
	}
}
