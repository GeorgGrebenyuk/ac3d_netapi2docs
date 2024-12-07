using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001115 RID: 4373
	public sealed class FeatureLineCodeInfoCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<FeatureLineCodeInfo>
	{
		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x06002401 RID: 9217
		public extern ObjectId CorridorId { get; }

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06002402 RID: 9218
		public extern int Count { get; }

		// Token: 0x170012D1 RID: 4817
		public extern FeatureLineCodeInfo this[string codeName]
		{
			get;
		}

		// Token: 0x170012D2 RID: 4818
		public extern FeatureLineCodeInfo this[int index]
		{
			get;
		}

		// Token: 0x06002405 RID: 9221
		public extern string[] CodeNames();

		// Token: 0x06002406 RID: 9222
		public extern FeatureLineCodeInfo[] GetConnectedFeatureLineCodeInfos();

		// Token: 0x06002407 RID: 9223
		public extern IEnumerator<FeatureLineCodeInfo> GetEnumerator();

		// Token: 0x06002408 RID: 9224
		public extern IEnumerator GetObjectEnumerator();
	}
}
