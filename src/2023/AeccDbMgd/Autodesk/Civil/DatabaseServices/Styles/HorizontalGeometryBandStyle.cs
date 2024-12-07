using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000A7 RID: 167
	[Wrapper("AeccDbGraphStyleHorGeometryBands")]
	public sealed class HorizontalGeometryBandStyle : BandStyle
	{
		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000778 RID: 1912
		public override extern BandType BandType { get; }

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000779 RID: 1913
		public override extern ObjectId TitleTextLabelStyleId { get; }

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600077A RID: 1914
		// (set) Token: 0x0600077B RID: 1915
		public extern SchematicLineOption SchematicLineType { get; set; }

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x0600077C RID: 1916
		public extern ObjectId TangentLabelStyleId { get; }

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600077D RID: 1917
		public extern ObjectId CurveLabelStyleId { get; }

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600077E RID: 1918
		public extern ObjectId SpiralLabelStyleId { get; }

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600077F RID: 1919
		public extern ObjectId PointOfIntersectionLabelStyleId { get; }

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000780 RID: 1920
		public extern BandTickStyle TangentTickStyle { get; }

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000781 RID: 1921
		public extern BandTickStyle CurveTickStyle { get; }

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000782 RID: 1922
		public extern BandTickStyle SpiralTickStyle { get; }

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000783 RID: 1923
		public extern BandTickStyle PointOfIntersectionTickStyle { get; }

		// Token: 0x06000784 RID: 1924
		public extern DisplayStyle GetDisplayStylePlan(HorizontalGeometryDisplayStyleType type);
	}
}
