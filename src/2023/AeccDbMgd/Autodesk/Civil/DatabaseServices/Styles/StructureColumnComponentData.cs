using System;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02001266 RID: 4710
	public sealed class StructureColumnComponentData : CivilWrapper<tableCellComponentVec>
	{
		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x060028F1 RID: 10481
		// (set) Token: 0x060028F2 RID: 10482
		public extern string Name { get; set; }

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x060028F3 RID: 10483
		// (set) Token: 0x060028F4 RID: 10484
		public extern string Content { get; set; }

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x060028F5 RID: 10485
		public extern StructureColumnComponentType ComponentType { get; }

		// Token: 0x04001BBE RID: 7102
		private int <SyntheticNonEmptyStructMarker>;
	}
}
