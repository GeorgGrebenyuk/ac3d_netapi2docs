using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000DF7 RID: 3575
	public sealed class StationEquationCollection : CivilWrapper<AeccDbAlignment>, IEnumerable<StationEquation>
	{
		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06001A65 RID: 6757
		public extern int Count { get; }

		// Token: 0x17000D33 RID: 3379
		public extern StationEquation this[int index]
		{
			get;
		}

		// Token: 0x06001A67 RID: 6759
		public extern StationEquation GetStationEquation(double rawStationBack);

		// Token: 0x06001A68 RID: 6760
		public extern IEnumerator<StationEquation> GetEnumerator();

		// Token: 0x06001A69 RID: 6761
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06001A6A RID: 6762
		public extern StationEquation Add(double rawStationBack, double stationAhead, StationEquationType stationEquationType);

		// Token: 0x06001A6B RID: 6763
		public extern void Remove(double rawStationBack);

		// Token: 0x06001A6C RID: 6764
		public extern void Remove(int index);
	}
}
