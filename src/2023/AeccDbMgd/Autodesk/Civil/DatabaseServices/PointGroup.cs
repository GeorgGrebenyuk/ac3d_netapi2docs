using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200013D RID: 317
	[Wrapper("AeccDbPG")]
	public class PointGroup : DBObject
	{
		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000D58 RID: 3416
		// (set) Token: 0x06000D59 RID: 3417
		public override extern string Name { get; set; }

		// Token: 0x17000587 RID: 1415
		// (set) Token: 0x06000D5A RID: 3418
		public override extern string Description { set; }

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000D5B RID: 3419
		public extern bool IsAllPointsGroup { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000D5C RID: 3420
		public extern uint PointsCount { get; }

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000D5D RID: 3421
		public extern string RawDescription { get; }

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000D5E RID: 3422
		public extern bool IsOutOfDate { [return: MarshalAs(UnmanagedType.U1)] get; }

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000D5F RID: 3423
		// (set) Token: 0x06000D60 RID: 3424
		public extern bool IsLocked { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x06000D61 RID: 3425
		public extern PointGroupChangeInfo GetPendingChanges();

		// Token: 0x06000D62 RID: 3426
		public extern void Update();

		// Token: 0x06000D63 RID: 3427
		public extern uint[] GetPointNumbers();

		// Token: 0x06000D64 RID: 3428
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool ContainsPoint(uint pointNumber);

		// Token: 0x06000D65 RID: 3429
		public extern void LockPoints();

		// Token: 0x06000D66 RID: 3430
		public extern void UnlockPoints();

		// Token: 0x06000D67 RID: 3431
		public extern void DeletePoints();

		// Token: 0x06000D68 RID: 3432
		public extern void ApplyDescriptionKeys();

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000D69 RID: 3433
		// (set) Token: 0x06000D6A RID: 3434
		public extern bool IsRawDescriptionOverridden { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000D6B RID: 3435
		public extern PointGroupRawDescriptionOverrideInfo RawDescriptionOverride { get; }

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000D6C RID: 3436
		// (set) Token: 0x06000D6D RID: 3437
		public extern bool IsElevationOverridden { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000D6E RID: 3438
		public extern PointGroupElevationOverrideInfo ElevationOverride { get; }

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000D6F RID: 3439
		// (set) Token: 0x06000D70 RID: 3440
		public extern bool IsPointStyleOverridden { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000D71 RID: 3441
		// (set) Token: 0x06000D72 RID: 3442
		public extern ObjectId PointStyleId { get; set; }

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000D73 RID: 3443
		// (set) Token: 0x06000D74 RID: 3444
		public extern bool IsPointLabelStyleOverridden { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000D75 RID: 3445
		// (set) Token: 0x06000D76 RID: 3446
		public extern ObjectId PointLabelStyleId { get; set; }

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000D77 RID: 3447
		public static extern string AllPointsGroupName { get; }

		// Token: 0x06000D78 RID: 3448
		public extern void UseAllClassifications();

		// Token: 0x06000D79 RID: 3449
		public extern void UseNoneClassification();

		// Token: 0x06000D7A RID: 3450
		public extern void UseCustomClassification(UDPClassification udpClassification);

		// Token: 0x06000D7B RID: 3451
		public extern void UseCustomClassification(string name);

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000D7C RID: 3452
		public extern string UDPClassificationName { get; }

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000D7D RID: 3453
		public extern UDPClassificationApplyType UDPClassificationApplyType { get; }

		// Token: 0x06000D7E RID: 3454
		public extern void SetQuery(PointGroupQuery query);

		// Token: 0x06000D7F RID: 3455
		public extern PointGroupQuery GetQuery();

		// Token: 0x06000D80 RID: 3456
		protected internal extern PointGroup(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);
	}
}
