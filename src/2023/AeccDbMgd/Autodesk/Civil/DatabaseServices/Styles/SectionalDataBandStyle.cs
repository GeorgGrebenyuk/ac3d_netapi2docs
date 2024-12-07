using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x020000A8 RID: 168
	[Wrapper("AeccDbGraphStyleSectionalDataBands")]
	public sealed class SectionalDataBandStyle : BandStyle
	{
		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000785 RID: 1925
		public override extern BandType BandType { get; }

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000786 RID: 1926
		public override extern ObjectId TitleTextLabelStyleId { get; }

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000787 RID: 1927
		public extern ObjectId SampleLineStationLabelStyleId { get; }

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000788 RID: 1928
		public extern ObjectId IncrementalSectionDataLabelStyleId { get; }

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000789 RID: 1929
		public extern BandTickStyle SampleLineStationTickStyle { get; }

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600078A RID: 1930
		public extern BandTickStyle IncrementalSectionDataTickStyle { get; }

		// Token: 0x0600078B RID: 1931
		public extern DisplayStyle GetDisplayStylePlan(SectionalDataDisplayStyleType type);
	}
}
