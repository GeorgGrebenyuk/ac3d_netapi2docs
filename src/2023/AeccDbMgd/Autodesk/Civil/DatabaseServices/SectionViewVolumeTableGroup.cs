using System;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000959 RID: 2393
	public sealed class SectionViewVolumeTableGroup
	{
		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001233 RID: 4659
		// (set) Token: 0x06001234 RID: 4660
		public extern SectionViewVolumeTableAnchorType SectionViewAnchorType { get; set; }

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001235 RID: 4661
		// (set) Token: 0x06001236 RID: 4662
		public extern SectionViewVolumeTableAnchorType TableAnchorType { get; set; }

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001237 RID: 4663
		// (set) Token: 0x06001238 RID: 4664
		public extern SectionViewVolumeTableLayoutType TableLayoutType { get; set; }

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001239 RID: 4665
		// (set) Token: 0x0600123A RID: 4666
		public extern double OffsetX { get; set; }

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x0600123B RID: 4667
		// (set) Token: 0x0600123C RID: 4668
		public extern double OffsetY { get; set; }

		// Token: 0x0600123D RID: 4669
		public extern ObjectIdCollection GetVolumeTableIds();

		// Token: 0x0600123E RID: 4670
		public extern void SwapAt(int index1, int index2);

		// Token: 0x0600123F RID: 4671
		public extern void Swap(ObjectId tableId1, ObjectId tableId2);

		// Token: 0x06001240 RID: 4672
		public extern ObjectId CreateVolumeTable(VolumeTableType type, Guid materialListGuid);

		// Token: 0x04001356 RID: 4950
		private int <SyntheticNonEmptyStructMarker>;
	}
}
