using System;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000765 RID: 1893
	public class RailAlignmentInfo
	{
		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06000EE7 RID: 3815
		// (set) Token: 0x06000EE8 RID: 3816
		public extern double TrackWidth { get; set; }

		// Token: 0x06000EE9 RID: 3817
		public extern RailCANTInfo GetCantInfoAtStation(double station);

		// Token: 0x06000EEA RID: 3818
		public extern RailCANTInfo[] GetCantInfoAtStations(IEnumerable<double> stations);

		// Token: 0x0400115A RID: 4442
		private int <SyntheticNonEmptyStructMarker>;
	}
}
