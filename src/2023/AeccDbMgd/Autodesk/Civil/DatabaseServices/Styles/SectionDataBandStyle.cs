using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000AA RID: 170
	[Wrapper("AeccDbGraphStyleSectionDataBands")]
	public sealed class SectionDataBandStyle : BandStyle
	{
		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000791 RID: 1937
		public override extern BandType BandType { get; }

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000792 RID: 1938
		public override extern ObjectId TitleTextLabelStyleId { get; }

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000793 RID: 1939
		public extern ObjectId MajorIncrementLabelStyleId { get; }

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000794 RID: 1940
		public extern ObjectId MinorIncrementLabelStyleId { get; }

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000795 RID: 1941
		public extern ObjectId CenterlineLabelStyleId { get; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000796 RID: 1942
		public extern ObjectId SampleLineVerticesLabelStyleId { get; }

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000797 RID: 1943
		public extern ObjectId GradeBreaksLabelStyleId { get; }

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000798 RID: 1944
		public extern ObjectId IncrementalDistanceLabelStyleId { get; }

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000799 RID: 1945
		public extern BandTickStyle MajorIncrementTickStyle { get; }

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600079A RID: 1946
		public extern BandTickStyle MinorIncrementTickStyle { get; }

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600079B RID: 1947
		public extern BandTickStyle CenterlineTickStyle { get; }

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600079C RID: 1948
		public extern BandTickStyle SampleLineVerticesTickStyle { get; }

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600079D RID: 1949
		public extern BandTickStyle GradeBreaksTickStyle { get; }

		// Token: 0x0600079E RID: 1950
		public extern DisplayStyle GetDisplayStylePlan(SectionDataDisplayStyleType type);
	}
}
