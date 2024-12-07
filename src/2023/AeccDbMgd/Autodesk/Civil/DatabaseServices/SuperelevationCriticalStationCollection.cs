using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000E01 RID: 3585
	public sealed class SuperelevationCriticalStationCollection : IEnumerable<SuperelevationCriticalStation>
	{
		// Token: 0x17000D9F RID: 3487
		public extern SuperelevationCriticalStation this[int index]
		{
			get;
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06001B34 RID: 6964
		public extern int Count { get; }

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06001B35 RID: 6965
		public extern ObjectId ParentAlignmentId { get; }

		// Token: 0x06001B36 RID: 6966
		public extern void Add(double station, SuperelevationCriticalStationType criticalStationType, SuperelevationAttainmentRegionType attainmentRegionType);

		// Token: 0x06001B37 RID: 6967
		[Obsolete("Use the override methods with attainment region type as input parameter instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2016)]
		public extern void Add(double station, SuperelevationCriticalStationType criticalStationType);

		// Token: 0x06001B38 RID: 6968
		public extern void RemoveAt(int index);

		// Token: 0x06001B39 RID: 6969
		public extern SuperelevationCriticalStation GetCriticalStationAt(double station, double tolerance);

		// Token: 0x06001B3A RID: 6970
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsCriticalStation(double station, double tolerance);

		// Token: 0x06001B3B RID: 6971
		public extern IEnumerator<SuperelevationCriticalStation> GetEnumerator();

		// Token: 0x06001B3C RID: 6972
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x040016A8 RID: 5800
		private int <SyntheticNonEmptyStructMarker>;
	}
}
