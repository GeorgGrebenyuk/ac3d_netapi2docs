using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000755 RID: 1877
	public sealed class CANTCriticalStationCollection : IEnumerable<CANTCriticalStation>
	{
		// Token: 0x170005D4 RID: 1492
		public extern CANTCriticalStation this[int index]
		{
			get;
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000E72 RID: 3698
		public extern int Count { get; }

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000E73 RID: 3699
		public extern ObjectId ParentAlignmentId { get; }

		// Token: 0x06000E74 RID: 3700
		public extern void Add(double station, SuperelevationCriticalStationType criticalStationType, SuperelevationAttainmentRegionType attainmentRegionType);

		// Token: 0x06000E75 RID: 3701
		[Obsolete("Use the override methods with attainment region type as input parameter instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2016)]
		public extern void Add(double station, SuperelevationCriticalStationType criticalStationType);

		// Token: 0x06000E76 RID: 3702
		public extern void RemoveAt(int index);

		// Token: 0x06000E77 RID: 3703
		public extern CANTCriticalStation GetCriticalStationAt(double station, double tolerance);

		// Token: 0x06000E78 RID: 3704
		[return: MarshalAs(UnmanagedType.U1)]
		public extern bool IsCriticalStation(double station, double tolerance);

		// Token: 0x06000E79 RID: 3705
		public extern IEnumerator<CANTCriticalStation> GetEnumerator();

		// Token: 0x06000E7A RID: 3706
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x0400114F RID: 4431
		private int <SyntheticNonEmptyStructMarker>;
	}
}
