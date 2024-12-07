using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000AE RID: 174
	[Wrapper("AeccDbLabelStyleVectorArrow")]
	public class LabelStyleDirectionArrowComponent : LabelStyleComponent
	{
		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060007BC RID: 1980
		public extern LabelStyleDirectionArrowComponent.StyleGeneral General { get; }

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x060007BD RID: 1981
		public extern LabelStyleDirectionArrowComponent.StyleDirectionArrow DirectionArrow { get; }

		// Token: 0x060007BE RID: 1982
		protected internal extern LabelStyleDirectionArrowComponent(IntPtr unmanagedPointer, [MarshalAs(UnmanagedType.U1)] bool autoDelete);

		// Token: 0x02001281 RID: 4737
		public sealed class StyleGeneral : CivilWrapper<AeccDbLabelStyleVectorArrow>
		{
			// Token: 0x17001560 RID: 5472
			// (get) Token: 0x06002957 RID: 10583
			// (set) Token: 0x06002958 RID: 10584
			public extern string Name { get; set; }

			// Token: 0x1700155F RID: 5471
			// (get) Token: 0x06002959 RID: 10585
			public extern PropertyBoolean Visible { get; }

			// Token: 0x1700155E RID: 5470
			// (get) Token: 0x0600295A RID: 10586
			public extern PropertyEnum<LayoutModeType> UsedIn { get; }

			// Token: 0x1700155D RID: 5469
			// (get) Token: 0x0600295B RID: 10587
			public extern PropertyString AnchorComponent { get; }

			// Token: 0x1700155C RID: 5468
			// (get) Token: 0x0600295C RID: 10588
			[DeprecatedVersion(CivilVersion.Civil2010)]
			[Obsolete("Use Autodesk.Civil.DatabaseServices.Styles.LabelStyleDirectionArrowComponent.StyleGeneral.AnchorLocation instead.", false)]
			public extern PropertyEnum<AnchorLocationType> AnchorPoint { get; }

			// Token: 0x1700155B RID: 5467
			// (get) Token: 0x0600295D RID: 10589
			public extern PropertyAnchorPoint AnchorLocation { get; }

			// Token: 0x1700155A RID: 5466
			// (get) Token: 0x0600295E RID: 10590
			public extern PropertyBoolean SpanOutsideSegments { get; }
		}

		// Token: 0x02001282 RID: 4738
		public sealed class StyleDirectionArrow : CivilWrapper<AeccDbLabelStyleVectorArrow>
		{
			// Token: 0x1700156A RID: 5482
			// (get) Token: 0x0600295F RID: 10591
			public extern PropertyString ArrowheadStyle { get; }

			// Token: 0x17001569 RID: 5481
			// (get) Token: 0x06002960 RID: 10592
			public extern PropertyDouble ArrowheadSize { get; }

			// Token: 0x17001568 RID: 5480
			// (get) Token: 0x06002961 RID: 10593
			public extern PropertyDouble RotationAngle { get; }

			// Token: 0x17001567 RID: 5479
			// (get) Token: 0x06002962 RID: 10594
			public extern PropertyBoolean FixedLength { get; }

			// Token: 0x17001566 RID: 5478
			// (get) Token: 0x06002963 RID: 10595
			public extern PropertyDouble LengthOrMinimumLength { get; }

			// Token: 0x17001565 RID: 5477
			// (get) Token: 0x06002964 RID: 10596
			public extern PropertyDouble XOffset { get; }

			// Token: 0x17001564 RID: 5476
			// (get) Token: 0x06002965 RID: 10597
			public extern PropertyDouble YOffset { get; }

			// Token: 0x17001563 RID: 5475
			// (get) Token: 0x06002966 RID: 10598
			public extern PropertyColor Color { get; }

			// Token: 0x17001562 RID: 5474
			// (get) Token: 0x06002967 RID: 10599
			public extern PropertyLinetype Linetype { get; }

			// Token: 0x17001561 RID: 5473
			// (get) Token: 0x06002968 RID: 10600
			public extern PropertyEnum<LineWeight> Lineweight { get; }
		}
	}
}
