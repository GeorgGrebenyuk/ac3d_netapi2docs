using System;
using Autodesk.AutoCAD.Geometry;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DD3 RID: 3539
	public class SectionPoint : CivilWrapper<AeccDbSection>
	{
		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06001A3B RID: 6715
		public extern Point3d Location { get; }

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06001A3C RID: 6716
		public extern int SegmentTo { get; }

		// Token: 0x0400167F RID: 5759
		private int <SyntheticNonEmptyStructMarker>;
	}
}
