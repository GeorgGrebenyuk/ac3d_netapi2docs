using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000A9 RID: 169
	[Wrapper("AeccDbGraphStyleSectionRoadSurfaceBands")]
	public sealed class SectionSegmentBandStyle : BandStyle
	{
		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600078C RID: 1932
		public override extern BandType BandType { get; }

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x0600078D RID: 1933
		public override extern ObjectId TitleTextLabelStyleId { get; }

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600078E RID: 1934
		public extern ObjectId SegmentsLabelStyleId { get; }

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600078F RID: 1935
		public extern BandTickStyle SegmentLabelsTickStyle { get; }

		// Token: 0x06000790 RID: 1936
		public extern DisplayStyle GetDisplayStylePlan(SectionSegmentDisplayStyleType type);
	}
}
