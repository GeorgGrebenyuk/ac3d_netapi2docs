using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000B3 RID: 179
	[Wrapper("AeccDbLabelStyleBlock")]
	public class LabelStyleBlockComponent : LabelStyleComponent
	{
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060007CD RID: 1997
		public extern LabelStyleBlockComponent.StyleGeneral General { get; }

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060007CE RID: 1998
		public extern LabelStyleBlockComponent.StyleBlock Block { get; }

		// Token: 0x060007CF RID: 1999
		protected internal extern LabelStyleBlockComponent(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x02001275 RID: 4725
		public sealed class StyleGeneral : CivilWrapper<AeccDbLabelStyleBlock>
		{
			// Token: 0x1700152A RID: 5418
			// (get) Token: 0x0600291E RID: 10526
			// (set) Token: 0x0600291F RID: 10527
			public extern string Name { get; set; }

			// Token: 0x17001529 RID: 5417
			// (get) Token: 0x06002920 RID: 10528
			public extern PropertyBoolean Visible { get; }

			// Token: 0x17001528 RID: 5416
			// (get) Token: 0x06002921 RID: 10529
			public extern PropertyEnum<LayoutModeType> UsedIn { get; }

			// Token: 0x17001527 RID: 5415
			// (get) Token: 0x06002922 RID: 10530
			public extern PropertyString AnchorComponent { get; }

			// Token: 0x17001526 RID: 5414
			// (get) Token: 0x06002923 RID: 10531
			[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.LabelStyleBlockComponent.StyleGeneral.AnchorLocation instead.", false)]
			[DeprecatedVersion(CivilVersion.Civil2010)]
			public extern PropertyEnum<AnchorLocationType> AnchorPoint { get; }

			// Token: 0x17001525 RID: 5413
			// (get) Token: 0x06002924 RID: 10532
			public extern PropertyAnchorPoint AnchorLocation { get; }
		}

		// Token: 0x02001276 RID: 4726
		public sealed class StyleBlock : CivilWrapper<AeccDbLabelStyleBlock>
		{
			// Token: 0x17001533 RID: 5427
			// (get) Token: 0x06002925 RID: 10533
			public extern PropertyString BlockName { get; }

			// Token: 0x17001532 RID: 5426
			// (get) Token: 0x06002926 RID: 10534
			public extern PropertyDouble BlockHeight { get; }

			// Token: 0x17001531 RID: 5425
			// (get) Token: 0x06002927 RID: 10535
			public extern PropertyDouble RotationAngle { get; }

			// Token: 0x17001530 RID: 5424
			// (get) Token: 0x06002928 RID: 10536
			public extern PropertyEnum<BlockAttachmentType> Attachment { get; }

			// Token: 0x1700152F RID: 5423
			// (get) Token: 0x06002929 RID: 10537
			public extern PropertyDouble XOffset { get; }

			// Token: 0x1700152E RID: 5422
			// (get) Token: 0x0600292A RID: 10538
			public extern PropertyDouble YOffset { get; }

			// Token: 0x1700152D RID: 5421
			// (get) Token: 0x0600292B RID: 10539
			public extern PropertyColor Color { get; }

			// Token: 0x1700152C RID: 5420
			// (get) Token: 0x0600292C RID: 10540
			public extern PropertyLinetype Linetype { get; }

			// Token: 0x1700152B RID: 5419
			// (get) Token: 0x0600292D RID: 10541
			public extern PropertyEnum<LineWeight> Lineweight { get; }
		}
	}
}
