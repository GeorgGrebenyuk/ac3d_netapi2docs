using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200115B RID: 4443
	public sealed class FeatureLineCollectionMap : CivilWrapper<AeccDbCorridor>, IEnumerable<FeatureLineCollection>
	{
		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x060024CD RID: 9421
		public extern ObjectId CorridorId { get; }

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x060024CE RID: 9422
		public extern int Count { get; }

		// Token: 0x17001329 RID: 4905
		public extern FeatureLineCollection this[string codeName]
		{
			get;
		}

		// Token: 0x1700132A RID: 4906
		public extern FeatureLineCollection this[int index]
		{
			get;
		}

		// Token: 0x060024D1 RID: 9425
		public extern string[] CodeNames();

		// Token: 0x060024D2 RID: 9426
		public extern IEnumerator<FeatureLineCollection> GetEnumerator();

		// Token: 0x060024D3 RID: 9427
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001AAB RID: 6827
		private int <SyntheticNonEmptyStructMarker>;
	}
}
