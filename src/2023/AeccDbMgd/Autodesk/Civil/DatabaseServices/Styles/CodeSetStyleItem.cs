using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000E6 RID: 230
	public sealed class CodeSetStyleItem : CivilWrapper<AeccDbRoadwayStyleSet>
	{
		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000A4A RID: 2634
		// (set) Token: 0x06000A4B RID: 2635
		public extern string Code { get; set; }

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000A4C RID: 2636
		// (set) Token: 0x06000A4D RID: 2637
		public extern ObjectId CodeStyleId { get; set; }

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000A4E RID: 2638
		// (set) Token: 0x06000A4F RID: 2639
		public extern string CodeStyleName { get; set; }

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000A50 RID: 2640
		// (set) Token: 0x06000A51 RID: 2641
		public extern string Classification { get; set; }

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000A52 RID: 2642
		// (set) Token: 0x06000A53 RID: 2643
		public extern string Description { get; set; }

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000A54 RID: 2644
		public extern SubassemblySubentityStyleType StyleType { get; }

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000A55 RID: 2645
		public extern CodeSetStyleItemType ItemType { get; }

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000A56 RID: 2646
		// (set) Token: 0x06000A57 RID: 2647
		public extern ObjectId LabelStyleId { get; set; }

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000A58 RID: 2648
		// (set) Token: 0x06000A59 RID: 2649
		public extern string LabelStyleName { get; set; }

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000A5A RID: 2650
		// (set) Token: 0x06000A5B RID: 2651
		public extern ObjectId FeatureLineStyleId { get; set; }

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000A5C RID: 2652
		// (set) Token: 0x06000A5D RID: 2653
		public extern string FeatureLineStyleName { get; set; }

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000A5E RID: 2654
		// (set) Token: 0x06000A5F RID: 2655
		public extern ObjectId MaterialAreaFillStyleId { get; set; }

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000A60 RID: 2656
		// (set) Token: 0x06000A61 RID: 2657
		public extern string MaterialAreaFillStyleName { get; set; }

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000A62 RID: 2658
		// (set) Token: 0x06000A63 RID: 2659
		public extern ObjectId RenderMaterialStyleId { get; set; }

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000A64 RID: 2660
		// (set) Token: 0x06000A65 RID: 2661
		public extern string RenderMaterialStyleName { get; set; }

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000A66 RID: 2662
		// (set) Token: 0x06000A67 RID: 2663
		public extern string[] PayItems { get; set; }

		// Token: 0x0400030F RID: 783
		private int <SyntheticNonEmptyStructMarker>;
	}
}
