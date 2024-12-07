using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001140 RID: 4416
	public sealed class BaselineFeatureLinesCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<BaselineFeatureLines>
	{
		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x0600249C RID: 9372
		public extern ObjectId CorridorId { get; }

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x0600249D RID: 9373
		public extern int Count { get; }

		// Token: 0x17001311 RID: 4881
		public extern BaselineFeatureLines this[int index]
		{
			get;
		}

		// Token: 0x0600249F RID: 9375
		public extern string[] CodeNames();

		// Token: 0x060024A0 RID: 9376
		public extern IEnumerator<BaselineFeatureLines> GetEnumerator();

		// Token: 0x060024A1 RID: 9377
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001A94 RID: 6804
		private int <SyntheticNonEmptyStructMarker>;
	}
}
