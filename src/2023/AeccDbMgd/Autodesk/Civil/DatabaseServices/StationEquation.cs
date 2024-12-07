using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DF5 RID: 3573
	public class StationEquation : CivilWrapper<AeccDbAlignment>
	{
		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06001A5E RID: 6750
		// (set) Token: 0x06001A5F RID: 6751
		public extern double RawStationBack { get; set; }

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06001A60 RID: 6752
		public extern double StationBack { get; }

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06001A61 RID: 6753
		// (set) Token: 0x06001A62 RID: 6754
		public extern double StationAhead { get; set; }

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06001A63 RID: 6755
		// (set) Token: 0x06001A64 RID: 6756
		public extern StationEquationType EquationType { get; set; }

		// Token: 0x040016A1 RID: 5793
		private int <SyntheticNonEmptyStructMarker>;

		// Token: 0x02000DF6 RID: 3574
		private enum PropertyType
		{
			// Token: 0x040016A3 RID: 5795
			RawStationBack = 1,
			// Token: 0x040016A4 RID: 5796
			StationBack,
			// Token: 0x040016A5 RID: 5797
			StationAhead
		}
	}
}
