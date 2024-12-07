using System;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000AC RID: 172
	[Wrapper("AeccDbGraphStyleVertGeometryBands")]
	public sealed class VerticalGeometryBandStyle : BandStyle
	{
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x060007AE RID: 1966
		public override extern BandType BandType { get; }

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x060007AF RID: 1967
		public override extern ObjectId TitleTextLabelStyleId { get; }

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x060007B0 RID: 1968
		public extern ObjectId UphillTangentLabelStyleId { get; }

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x060007B1 RID: 1969
		public extern ObjectId DownhillTangentLabelStyleId { get; }

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x060007B2 RID: 1970
		public extern ObjectId CrestCurveLabelStyleId { get; }

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x060007B3 RID: 1971
		public extern ObjectId SagCurveLabelStyleId { get; }

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x060007B4 RID: 1972
		public extern BandTickStyle UphillTangentTickStyle { get; }

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x060007B5 RID: 1973
		public extern BandTickStyle DownhillTangentTickStyle { get; }

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x060007B6 RID: 1974
		public extern BandTickStyle CrestCurveTickStyle { get; }

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x060007B7 RID: 1975
		public extern BandTickStyle SagCurveTickStyle { get; }

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x060007B8 RID: 1976
		// (set) Token: 0x060007B9 RID: 1977
		public extern bool LabelOnlyTangents { [return: MarshalAs(UnmanagedType.U1)] get; [param: MarshalAs(UnmanagedType.U1)] set; }

		// Token: 0x060007BA RID: 1978
		public extern DisplayStyle GetDisplayStylePlan(VerticalGeometryDisplayStyleType type);
	}
}
