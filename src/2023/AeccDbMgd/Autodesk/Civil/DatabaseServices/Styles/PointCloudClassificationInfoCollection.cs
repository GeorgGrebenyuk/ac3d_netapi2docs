using System;
using System.Collections;
using System.Collections.Generic;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000973 RID: 2419
	public class PointCloudClassificationInfoCollection : IEnumerable<PointCloudClassificationInfo>
	{
		// Token: 0x17000785 RID: 1925
		public extern PointCloudClassificationInfo this[int index]
		{
			get;
			set;
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x0600124E RID: 4686
		public extern int Count { get; }

		// Token: 0x0600124F RID: 4687
		public virtual extern IEnumerator<PointCloudClassificationInfo> GetEnumerator();

		// Token: 0x06001250 RID: 4688
		public virtual extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001377 RID: 4983
		private int <SyntheticNonEmptyStructMarker>;
	}
}
