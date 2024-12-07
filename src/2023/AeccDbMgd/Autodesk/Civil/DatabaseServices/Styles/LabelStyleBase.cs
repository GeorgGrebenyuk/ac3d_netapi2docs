using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x0200008D RID: 141
	public class LabelStyleBase : CivilWrapper<AeccDbLabelStyleCollector>
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000638 RID: 1592
		public extern LabelStyleBase.BaseLabel Label { get; }

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000639 RID: 1593
		public extern LabelStyleBase.BaseBehavior Behavior { get; }

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600063A RID: 1594
		public extern LabelStyleBase.BasePlanReadability PlanReadability { get; }

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600063B RID: 1595
		public extern LabelStyleBase.BaseLeader Leader { get; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600063C RID: 1596
		public extern LabelStyleBase.BaseDraggedStateComponents DraggedStateComponents { get; }

		// Token: 0x0200126E RID: 4718
		public sealed class BaseLabel : CivilWrapper<AeccDbLabelStyleCollector>
		{
			// Token: 0x1700150B RID: 5387
			// (get) Token: 0x060028FE RID: 10494
			public extern PropertyString TextStyle { get; }

			// Token: 0x1700150A RID: 5386
			// (get) Token: 0x060028FF RID: 10495
			public extern PropertyBoolean Visibility { get; }

			// Token: 0x17001509 RID: 5385
			// (get) Token: 0x06002900 RID: 10496
			public extern PropertyLayer Layer { get; }

			// Token: 0x17001508 RID: 5384
			// (get) Token: 0x06002901 RID: 10497
			public extern PropertyEnum<LabelDisplayModeType> DisplayMode { get; }
		}

		// Token: 0x0200126F RID: 4719
		public sealed class BaseBehavior : CivilWrapper<AeccDbLabelStyleCollector>
		{
			// Token: 0x1700150E RID: 5390
			// (get) Token: 0x06002902 RID: 10498
			public extern PropertyEnum<OrientationReferenceType> OrientationReference { get; }

			// Token: 0x1700150D RID: 5389
			// (get) Token: 0x06002903 RID: 10499
			public extern PropertyEnum<LabelInsideCurveType> InsideCurveOption { get; }

			// Token: 0x1700150C RID: 5388
			// (get) Token: 0x06002904 RID: 10500
			public extern PropertyEnum<LabelInsertionType> InsertOption { get; }
		}

		// Token: 0x02001270 RID: 4720
		public sealed class BasePlanReadability : CivilWrapper<AeccDbLabelStyleCollector>
		{
			// Token: 0x17001511 RID: 5393
			// (get) Token: 0x06002905 RID: 10501
			public extern PropertyBoolean PlanReadable { get; }

			// Token: 0x17001510 RID: 5392
			// (get) Token: 0x06002906 RID: 10502
			public extern PropertyDouble PlanReadableBias { get; }

			// Token: 0x1700150F RID: 5391
			// (get) Token: 0x06002907 RID: 10503
			public extern PropertyBoolean FlipAnchorsWithText { get; }
		}

		// Token: 0x02001271 RID: 4721
		public sealed class BaseLeader : CivilWrapper<AeccDbLabelStyleCollector>
		{
			// Token: 0x17001518 RID: 5400
			// (get) Token: 0x06002908 RID: 10504
			public extern PropertyString ArrowheadStyle { get; }

			// Token: 0x17001517 RID: 5399
			// (get) Token: 0x06002909 RID: 10505
			public extern PropertyDouble ArrowheadSize { get; }

			// Token: 0x17001516 RID: 5398
			// (get) Token: 0x0600290A RID: 10506
			public extern PropertyBoolean Visibility { get; }

			// Token: 0x17001515 RID: 5397
			// (get) Token: 0x0600290B RID: 10507
			public extern PropertyEnum<LeaderShapeType> Shape { get; }

			// Token: 0x17001514 RID: 5396
			// (get) Token: 0x0600290C RID: 10508
			public extern PropertyColor Color { get; }

			// Token: 0x17001513 RID: 5395
			// (get) Token: 0x0600290D RID: 10509
			public extern PropertyLinetype Linetype { get; }

			// Token: 0x17001512 RID: 5394
			// (get) Token: 0x0600290E RID: 10510
			public extern PropertyEnum<LineWeight> Lineweight { get; }
		}

		// Token: 0x02001272 RID: 4722
		public sealed class BaseDraggedStateComponents : CivilWrapper<AeccDbLabelStyleCollector>
		{
			// Token: 0x17001524 RID: 5412
			// (get) Token: 0x0600290F RID: 10511
			public extern PropertyEnum<LabelContentDisplayType> DisplayType { get; }

			// Token: 0x17001523 RID: 5411
			// (get) Token: 0x06002910 RID: 10512
			public extern PropertyBoolean BorderVisibility { get; }

			// Token: 0x17001522 RID: 5410
			// (get) Token: 0x06002911 RID: 10513
			public extern PropertyEnum<TextBorderType> BorderType { get; }

			// Token: 0x17001521 RID: 5409
			// (get) Token: 0x06002912 RID: 10514
			public extern PropertyBoolean UseBackgroundMask { get; }

			// Token: 0x17001520 RID: 5408
			// (get) Token: 0x06002913 RID: 10515
			public extern PropertyDouble Gap { get; }

			// Token: 0x1700151F RID: 5407
			// (get) Token: 0x06002914 RID: 10516
			public extern PropertyDouble TextHeight { get; }

			// Token: 0x1700151E RID: 5406
			// (get) Token: 0x06002915 RID: 10517
			public extern PropertyDouble MaxTextWidth { get; }

			// Token: 0x1700151D RID: 5405
			// (get) Token: 0x06002916 RID: 10518
			public extern PropertyEnum<LeaderAttachmentType> LeaderAttachment { get; }

			// Token: 0x1700151C RID: 5404
			// (get) Token: 0x06002917 RID: 10519
			public extern PropertyBoolean LeaderJustification { get; }

			// Token: 0x1700151B RID: 5403
			// (get) Token: 0x06002918 RID: 10520
			public extern PropertyColor Color { get; }

			// Token: 0x1700151A RID: 5402
			// (get) Token: 0x06002919 RID: 10521
			public extern PropertyLinetype Linetype { get; }

			// Token: 0x17001519 RID: 5401
			// (get) Token: 0x0600291A RID: 10522
			public extern PropertyEnum<LineWeight> Lineweight { get; }
		}
	}
}
