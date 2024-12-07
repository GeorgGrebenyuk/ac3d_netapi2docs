using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000B9E RID: 2974
	public sealed class FeatureLinePointCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<FeatureLinePoint>
	{
		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001649 RID: 5705
		public extern ObjectId CorridorId { get; }

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x0600164A RID: 5706
		public extern int Count { get; }

		// Token: 0x170009B2 RID: 2482
		public extern FeatureLinePoint this[int index]
		{
			get;
		}

		// Token: 0x0600164C RID: 5708
		public extern IEnumerator<FeatureLinePoint> GetEnumerator();

		// Token: 0x0600164D RID: 5709
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001523 RID: 5411
		private int <SyntheticNonEmptyStructMarker>;
	}
}
