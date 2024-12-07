using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000098 RID: 152
	[Wrapper("AeccDbGraphSectionBandStyleSet")]
	public sealed class SectionViewBandSetStyle : BandSetStyle
	{
		// Token: 0x060006A2 RID: 1698
		public extern SectionViewBandSetItemCollection GetTopBandSetItems();

		// Token: 0x060006A3 RID: 1699
		public extern void SetTopBandSetItems(SectionViewBandSetItemCollection bandSetItems);

		// Token: 0x060006A4 RID: 1700
		public extern SectionViewBandSetItemCollection GetBottomBandSetItems();

		// Token: 0x060006A5 RID: 1701
		public extern void SetBottomBandSetItems(SectionViewBandSetItemCollection bandSetItems);
	}
}
