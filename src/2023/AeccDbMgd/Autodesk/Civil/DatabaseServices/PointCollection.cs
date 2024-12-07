using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011B2 RID: 4530
	public sealed class PointCollection : CivilWrapper<AeccDbEntity>, IEnumerable<Point>
	{
		// Token: 0x060025E3 RID: 9699
		public extern Point Add(double offset, double elevation, string[] codes);

		// Token: 0x060025E4 RID: 9700
		public extern Point Add(double offset, double elevation, string code);

		// Token: 0x060025E5 RID: 9701
		public extern IEnumerator<Point> GetEnumerator();

		// Token: 0x060025E6 RID: 9702
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x170013AA RID: 5034
		public extern Point this[int index]
		{
			get;
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x060025E8 RID: 9704
		public extern int Count { get; }

		// Token: 0x060025E9 RID: 9705
		public extern void Remove(Point point);

		// Token: 0x060025EA RID: 9706
		public extern void Remove(int index);

		// Token: 0x04001AF9 RID: 6905
		private int <SyntheticNonEmptyStructMarker>;
	}
}
