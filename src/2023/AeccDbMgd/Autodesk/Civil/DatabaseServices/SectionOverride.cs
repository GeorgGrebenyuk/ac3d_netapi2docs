using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200092B RID: 2347
	public sealed class SectionOverride : GraphOverride
	{
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060011DB RID: 4571
		public extern ObjectId SectionId { get; }

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060011DC RID: 4572
		public extern string SectionName { get; }

		// Token: 0x060011DD RID: 4573
		public extern ObjectIdCollection GetSectionLabelGroupIds();

		// Token: 0x17000755 RID: 1877
		// (set) Token: 0x060011DE RID: 4574
		public override extern string OverrideStyleName { set; }

		// Token: 0x17000754 RID: 1876
		// (set) Token: 0x060011DF RID: 4575
		public override extern ObjectId OverrideStyleId { set; }

		// Token: 0x060011E0 RID: 4576
		public extern void ImportLabelSet(ObjectId sectionLabelSetId);
	}
}
