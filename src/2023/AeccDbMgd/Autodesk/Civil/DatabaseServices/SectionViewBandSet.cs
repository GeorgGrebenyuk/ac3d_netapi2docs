using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000942 RID: 2370
	public sealed class SectionViewBandSet : GraphBandSet
	{
		// Token: 0x0600121B RID: 4635
		public extern SectionViewBandItemCollection GetTopBandItems();

		// Token: 0x0600121C RID: 4636
		public extern void SetTopBandItems(SectionViewBandItemCollection bandItems);

		// Token: 0x0600121D RID: 4637
		public extern SectionViewBandItemCollection GetBottomBandItems();

		// Token: 0x0600121E RID: 4638
		public extern void SetBottomBandItems(SectionViewBandItemCollection bandItems);

		// Token: 0x0600121F RID: 4639
		public sealed override extern void ImportBandSetStyle(ObjectId bandSetId);
	}
}
