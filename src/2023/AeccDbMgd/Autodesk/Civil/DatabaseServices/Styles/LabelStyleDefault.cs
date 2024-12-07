using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001277 RID: 4727
	public sealed class LabelStyleDefault : TreeOidWrapper
	{
		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x0600292E RID: 10542
		public extern LabelStyleDefault.DefaultLabel Label { get; }

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x0600292F RID: 10543
		public extern LabelStyleDefault.DefaultBehavior Behavior { get; }

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x06002930 RID: 10544
		public extern LabelStyleDefault.DefaultPlanReadability PlanReadability { get; }

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06002931 RID: 10545
		public extern LabelStyleDefault.DefaultComponents Components { get; }

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06002932 RID: 10546
		public extern LabelStyleDefault.DefaultLeader Leader { get; }

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06002933 RID: 10547
		public extern LabelStyleDefault.DefaultDraggedStateComponents DraggedStateComponents { get; }

		// Token: 0x0200127A RID: 4730
		public sealed class DefaultLabel : TreeOidWrapper
		{
			// Token: 0x1700153C RID: 5436
			// (get) Token: 0x06002934 RID: 10548
			public extern PropertyString TextStyle { get; }

			// Token: 0x1700153B RID: 5435
			// (get) Token: 0x06002935 RID: 10549
			public extern PropertyBoolean Visibility { get; }

			// Token: 0x1700153A RID: 5434
			// (get) Token: 0x06002936 RID: 10550
			public extern PropertyLayer Layer { get; }
		}

		// Token: 0x0200127B RID: 4731
		public sealed class DefaultBehavior : TreeOidWrapper
		{
			// Token: 0x1700153F RID: 5439
			// (get) Token: 0x06002937 RID: 10551
			public extern PropertyEnum<OrientationReferenceType> OrientationReference { get; }

			// Token: 0x1700153E RID: 5438
			// (get) Token: 0x06002938 RID: 10552
			public extern PropertyEnum<LabelInsideCurveType> InsideCurveOption { get; }

			// Token: 0x1700153D RID: 5437
			// (get) Token: 0x06002939 RID: 10553
			public extern PropertyEnum<LabelInsertionType> InsertOption { get; }
		}

		// Token: 0x0200127C RID: 4732
		public sealed class DefaultPlanReadability : TreeOidWrapper
		{
			// Token: 0x17001542 RID: 5442
			// (get) Token: 0x0600293A RID: 10554
			public extern PropertyBoolean PlanReadable { get; }

			// Token: 0x17001541 RID: 5441
			// (get) Token: 0x0600293B RID: 10555
			public extern PropertyDouble PlanReadableBias { get; }

			// Token: 0x17001540 RID: 5440
			// (get) Token: 0x0600293C RID: 10556
			public extern PropertyBoolean FlipAnchorsWithText { get; }
		}

		// Token: 0x0200127D RID: 4733
		public sealed class DefaultComponents : TreeOidWrapper
		{
			// Token: 0x17001546 RID: 5446
			// (get) Token: 0x0600293D RID: 10557
			public extern PropertyDouble TextHeight { get; }

			// Token: 0x17001545 RID: 5445
			// (get) Token: 0x0600293E RID: 10558
			public extern PropertyColor Color { get; }

			// Token: 0x17001544 RID: 5444
			// (get) Token: 0x0600293F RID: 10559
			public extern PropertyLinetype Linetype { get; }

			// Token: 0x17001543 RID: 5443
			// (get) Token: 0x06002940 RID: 10560
			public extern PropertyEnum<LineWeight> Lineweight { get; }
		}

		// Token: 0x0200127E RID: 4734
		public sealed class DefaultLeader : TreeOidWrapper
		{
			// Token: 0x1700154D RID: 5453
			// (get) Token: 0x06002941 RID: 10561
			public extern PropertyString ArrowheadStyle { get; }

			// Token: 0x1700154C RID: 5452
			// (get) Token: 0x06002942 RID: 10562
			public extern PropertyDouble ArrowheadSize { get; }

			// Token: 0x1700154B RID: 5451
			// (get) Token: 0x06002943 RID: 10563
			public extern PropertyBoolean Visibility { get; }

			// Token: 0x1700154A RID: 5450
			// (get) Token: 0x06002944 RID: 10564
			public extern PropertyEnum<LeaderShapeType> Shape { get; }

			// Token: 0x17001549 RID: 5449
			// (get) Token: 0x06002945 RID: 10565
			public extern PropertyColor Color { get; }

			// Token: 0x17001548 RID: 5448
			// (get) Token: 0x06002946 RID: 10566
			public extern PropertyLinetype Linetype { get; }

			// Token: 0x17001547 RID: 5447
			// (get) Token: 0x06002947 RID: 10567
			public extern PropertyEnum<LineWeight> Lineweight { get; }
		}

		// Token: 0x0200127F RID: 4735
		public sealed class DefaultDraggedStateComponents : TreeOidWrapper
		{
			// Token: 0x17001559 RID: 5465
			// (get) Token: 0x06002948 RID: 10568
			public extern PropertyEnum<LabelContentDisplayType> DisplayType { get; }

			// Token: 0x17001558 RID: 5464
			// (get) Token: 0x06002949 RID: 10569
			public extern PropertyBoolean BorderVisibility { get; }

			// Token: 0x17001557 RID: 5463
			// (get) Token: 0x0600294A RID: 10570
			public extern PropertyEnum<TextBorderType> BorderType { get; }

			// Token: 0x17001556 RID: 5462
			// (get) Token: 0x0600294B RID: 10571
			public extern PropertyBoolean UseBackgroundMask { get; }

			// Token: 0x17001555 RID: 5461
			// (get) Token: 0x0600294C RID: 10572
			public extern PropertyDouble Gap { get; }

			// Token: 0x17001554 RID: 5460
			// (get) Token: 0x0600294D RID: 10573
			public extern PropertyDouble TextHeight { get; }

			// Token: 0x17001553 RID: 5459
			// (get) Token: 0x0600294E RID: 10574
			public extern PropertyDouble MaxTextWidth { get; }

			// Token: 0x17001552 RID: 5458
			// (get) Token: 0x0600294F RID: 10575
			public extern PropertyEnum<LeaderAttachmentType> LeaderAttachment { get; }

			// Token: 0x17001551 RID: 5457
			// (get) Token: 0x06002950 RID: 10576
			public extern PropertyBoolean LeaderJustification { get; }

			// Token: 0x17001550 RID: 5456
			// (get) Token: 0x06002951 RID: 10577
			public extern PropertyColor Color { get; }

			// Token: 0x1700154F RID: 5455
			// (get) Token: 0x06002952 RID: 10578
			public extern PropertyLinetype Linetype { get; }

			// Token: 0x1700154E RID: 5454
			// (get) Token: 0x06002953 RID: 10579
			public extern PropertyEnum<LineWeight> Lineweight { get; }
		}
	}
}
