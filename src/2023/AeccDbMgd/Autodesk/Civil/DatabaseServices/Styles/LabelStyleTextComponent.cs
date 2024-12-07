using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000B1 RID: 177
	[Wrapper("AeccDbLabelStyleText")]
	public class LabelStyleTextComponent : LabelStyleComponent
	{
		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060007C6 RID: 1990
		public extern LabelStyleTextComponent.StyleGeneral General { get; }

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060007C7 RID: 1991
		public extern LabelStyleTextComponent.StyleText Text { get; }

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060007C8 RID: 1992
		public extern LabelStyleTextComponent.StyleBorder Border { get; }

		// Token: 0x060007C9 RID: 1993
		protected internal extern LabelStyleTextComponent(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x02001287 RID: 4743
		public class StyleGeneral : CivilWrapper<AeccDbLabelStyleText>
		{
			// Token: 0x17001587 RID: 5511
			// (get) Token: 0x06002986 RID: 10630
			// (set) Token: 0x06002987 RID: 10631
			public extern string Name { get; set; }

			// Token: 0x17001586 RID: 5510
			// (get) Token: 0x06002988 RID: 10632
			public extern PropertyBoolean Visible { get; }

			// Token: 0x17001585 RID: 5509
			// (get) Token: 0x06002989 RID: 10633
			public extern PropertyEnum<LayoutModeType> UsedIn { get; }

			// Token: 0x17001584 RID: 5508
			// (get) Token: 0x0600298A RID: 10634
			public extern PropertyString AnchorComponent { get; }

			// Token: 0x17001583 RID: 5507
			// (get) Token: 0x0600298B RID: 10635
			[DeprecatedVersion(CivilVersion.Civil2010)]
			[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.LabelStyleTextComponent.StyleGeneral.AnchorLocation instead.", false)]
			public extern PropertyEnum<AnchorLocationType> AnchorPoint { get; }

			// Token: 0x17001582 RID: 5506
			// (get) Token: 0x0600298C RID: 10636
			public extern PropertyAnchorPoint AnchorLocation { get; }

			// Token: 0x17001581 RID: 5505
			// (get) Token: 0x0600298D RID: 10637
			public extern PropertyBoolean SpanOutsideSegments { get; }
		}

		// Token: 0x02001288 RID: 4744
		public class StyleText : CivilWrapper<AeccDbLabelStyleText>
		{
			// Token: 0x17001590 RID: 5520
			// (get) Token: 0x0600298E RID: 10638
			public extern PropertyString Contents { get; }

			// Token: 0x1700158F RID: 5519
			// (get) Token: 0x0600298F RID: 10639
			public extern PropertyDouble Height { get; }

			// Token: 0x1700158E RID: 5518
			// (get) Token: 0x06002990 RID: 10640
			public extern PropertyDouble MaxWidth { get; }

			// Token: 0x1700158D RID: 5517
			// (get) Token: 0x06002991 RID: 10641
			public extern PropertyDouble Angle { get; }

			// Token: 0x1700158C RID: 5516
			// (get) Token: 0x06002992 RID: 10642
			public extern PropertyEnum<LabelTextAttachmentType> Attachment { get; }

			// Token: 0x1700158B RID: 5515
			// (get) Token: 0x06002993 RID: 10643
			public extern PropertyDouble XOffset { get; }

			// Token: 0x1700158A RID: 5514
			// (get) Token: 0x06002994 RID: 10644
			public extern PropertyDouble YOffset { get; }

			// Token: 0x17001589 RID: 5513
			// (get) Token: 0x06002995 RID: 10645
			public extern PropertyColor Color { get; }

			// Token: 0x17001588 RID: 5512
			// (get) Token: 0x06002996 RID: 10646
			public extern PropertyEnum<LineWeight> Lineweight { get; }
		}

		// Token: 0x02001289 RID: 4745
		public class StyleBorder : CivilWrapper<AeccDbLabelStyleText>
		{
			// Token: 0x17001597 RID: 5527
			// (get) Token: 0x06002997 RID: 10647
			public extern PropertyBoolean Visible { get; }

			// Token: 0x17001596 RID: 5526
			// (get) Token: 0x06002998 RID: 10648
			public extern PropertyEnum<TextBorderType> BorderType { get; }

			// Token: 0x17001595 RID: 5525
			// (get) Token: 0x06002999 RID: 10649
			public extern PropertyBoolean BackgroundMask { get; }

			// Token: 0x17001594 RID: 5524
			// (get) Token: 0x0600299A RID: 10650
			public extern PropertyDouble Gap { get; }

			// Token: 0x17001593 RID: 5523
			// (get) Token: 0x0600299B RID: 10651
			public extern PropertyColor Color { get; }

			// Token: 0x17001592 RID: 5522
			// (get) Token: 0x0600299C RID: 10652
			public extern PropertyLinetype Linetype { get; }

			// Token: 0x17001591 RID: 5521
			// (get) Token: 0x0600299D RID: 10653
			public extern PropertyEnum<LineWeight> Lineweight { get; }
		}
	}
}
