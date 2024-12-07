using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000AF RID: 175
	[Wrapper("AeccDbLabelStyleRadialLine")]
	public class LabelStyleLineComponent : LabelStyleComponent
	{
		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060007BF RID: 1983
		public extern LabelStyleLineComponent.StyleGeneral General { get; }

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x060007C0 RID: 1984
		public extern LabelStyleLineComponent.StyleLine Line { get; }

		// Token: 0x060007C1 RID: 1985
		protected internal extern LabelStyleLineComponent(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x02001284 RID: 4740
		public sealed class StyleGeneral : CivilWrapper<AeccDbLabelStyleRadialLine>
		{
			// Token: 0x17001574 RID: 5492
			// (get) Token: 0x0600296C RID: 10604
			// (set) Token: 0x0600296D RID: 10605
			public extern string Name { get; set; }

			// Token: 0x17001573 RID: 5491
			// (get) Token: 0x0600296E RID: 10606
			public extern PropertyBoolean Visible { get; }

			// Token: 0x17001572 RID: 5490
			// (get) Token: 0x0600296F RID: 10607
			public extern PropertyEnum<LayoutModeType> UsedIn { get; }

			// Token: 0x17001571 RID: 5489
			// (get) Token: 0x06002970 RID: 10608
			public extern PropertyString StartPointAnchorComponent { get; }

			// Token: 0x17001570 RID: 5488
			// (get) Token: 0x06002971 RID: 10609
			[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.LabelStyleLineComponent.StyleGeneral.StartAnchorPoint instead.", false)]
			[DeprecatedVersion(CivilVersion.Civil2010)]
			public extern PropertyEnum<AnchorLocationType> StartPointAnchorPoint { get; }

			// Token: 0x1700156F RID: 5487
			// (get) Token: 0x06002972 RID: 10610
			public extern PropertyAnchorPoint StartAnchorPoint { get; }

			// Token: 0x1700156E RID: 5486
			// (get) Token: 0x06002973 RID: 10611
			public extern PropertyBoolean UseEndPointAnchor { get; }

			// Token: 0x1700156D RID: 5485
			// (get) Token: 0x06002974 RID: 10612
			public extern PropertyString EndPointAnchorComponent { get; }

			// Token: 0x1700156C RID: 5484
			// (get) Token: 0x06002975 RID: 10613
			[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.LabelStyleLineComponent.StyleGeneral.EndAnchorPoint instead.", false)]
			[DeprecatedVersion(CivilVersion.Civil2010)]
			public extern PropertyEnum<AnchorLocationType> EndPointAnchorPoint { get; }

			// Token: 0x1700156B RID: 5483
			// (get) Token: 0x06002976 RID: 10614
			public extern PropertyAnchorPoint EndAnchorPoint { get; }
		}

		// Token: 0x02001285 RID: 4741
		public sealed class StyleLine : CivilWrapper<AeccDbLabelStyleRadialLine>
		{
			// Token: 0x17001580 RID: 5504
			// (get) Token: 0x06002977 RID: 10615
			public extern PropertyEnum<LabelStyleLengthType> LengthType { get; }

			// Token: 0x1700157F RID: 5503
			// (get) Token: 0x06002978 RID: 10616
			public extern PropertyDouble FixedLength { get; }

			// Token: 0x1700157E RID: 5502
			// (get) Token: 0x06002979 RID: 10617
			public extern PropertyDouble PercentLength { get; }

			// Token: 0x1700157D RID: 5501
			// (get) Token: 0x0600297A RID: 10618
			[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.LabelStyleLineComponent.StyleLine.FixedLength instead.", false)]
			[DeprecatedVersion(CivilVersion.Civil2012)]
			public extern PropertyDouble Length { get; }

			// Token: 0x1700157C RID: 5500
			// (get) Token: 0x0600297B RID: 10619
			public extern PropertyDouble Angle { get; }

			// Token: 0x1700157B RID: 5499
			// (get) Token: 0x0600297C RID: 10620
			public extern PropertyDouble StartPointXOffset { get; }

			// Token: 0x1700157A RID: 5498
			// (get) Token: 0x0600297D RID: 10621
			public extern PropertyDouble StartPointYOffset { get; }

			// Token: 0x17001579 RID: 5497
			// (get) Token: 0x0600297E RID: 10622
			public extern PropertyDouble EndPointXOffset { get; }

			// Token: 0x17001578 RID: 5496
			// (get) Token: 0x0600297F RID: 10623
			public extern PropertyDouble EndPointYOffset { get; }

			// Token: 0x17001577 RID: 5495
			// (get) Token: 0x06002980 RID: 10624
			public extern PropertyColor Color { get; }

			// Token: 0x17001576 RID: 5494
			// (get) Token: 0x06002981 RID: 10625
			public extern PropertyLinetype Linetype { get; }

			// Token: 0x17001575 RID: 5493
			// (get) Token: 0x06002982 RID: 10626
			public extern PropertyEnum<LineWeight> Lineweight { get; }
		}
	}
}
