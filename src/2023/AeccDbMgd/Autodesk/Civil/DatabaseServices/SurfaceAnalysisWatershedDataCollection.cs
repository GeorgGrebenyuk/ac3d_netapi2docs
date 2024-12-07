using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000A0C RID: 2572
	public class SurfaceAnalysisWatershedDataCollection : IEnumerable<SurfaceAnalysisWatershedData>
	{
		// Token: 0x17000810 RID: 2064
		public extern SurfaceAnalysisWatershedData this[int index]
		{
			get;
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001366 RID: 4966
		public extern int Count { get; }

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001367 RID: 4967
		public extern ObjectId ParentSurfaceId { get; }

		// Token: 0x06001368 RID: 4968
		public virtual extern IEnumerator<SurfaceAnalysisWatershedData> GetEnumerator();

		// Token: 0x06001369 RID: 4969
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x040013F6 RID: 5110
		private int <SyntheticNonEmptyStructMarker>;
	}
}
