using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A5E RID: 2654
	public sealed class SurfaceMaskCollection : IEnumerable<SurfaceMask>
	{
		// Token: 0x17000853 RID: 2131
		public extern SurfaceMask this[string name]
		{
			get;
		}

		// Token: 0x17000854 RID: 2132
		public extern SurfaceMask this[int index]
		{
			get;
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001400 RID: 5120
		public extern int Count { get; }

		// Token: 0x06001401 RID: 5121
		public extern int IndexOf(SurfaceMask mask);

		// Token: 0x06001402 RID: 5122
		public extern SurfaceMask Add(SurfaceMaskCreationData creationData);

		// Token: 0x06001403 RID: 5123
		public extern void Remove(SurfaceMask mask);

		// Token: 0x06001404 RID: 5124
		public extern void RemoveAt(int index);

		// Token: 0x06001405 RID: 5125
		public extern void Swap(SurfaceMask mask1, SurfaceMask mask2);

		// Token: 0x06001406 RID: 5126
		public extern void MoveUp(SurfaceMask mask);

		// Token: 0x06001407 RID: 5127
		public extern void MoveDown(SurfaceMask mask);

		// Token: 0x06001408 RID: 5128
		public extern IEnumerator<SurfaceMask> GetEnumerator();

		// Token: 0x06001409 RID: 5129
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x0600140A RID: 5130
		public extern SurfaceMaskCollection(Surface pSurface);

		// Token: 0x04001439 RID: 5177
		private int <SyntheticNonEmptyStructMarker>;
	}
}
