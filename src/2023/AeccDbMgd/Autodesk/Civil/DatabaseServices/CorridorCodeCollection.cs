using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001159 RID: 4441
	public sealed class CorridorCodeCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<string>
	{
		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x060024C1 RID: 9409
		public extern ObjectId CorridorId { get; }

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x060024C2 RID: 9410
		public extern int Count { get; }

		// Token: 0x17001324 RID: 4900
		public extern string this[int index]
		{
			get;
		}

		// Token: 0x060024C4 RID: 9412
		public extern void Add(string code);

		// Token: 0x060024C5 RID: 9413
		public extern void Clear();

		// Token: 0x060024C6 RID: 9414
		public extern IEnumerator<string> GetEnumerator();

		// Token: 0x060024C7 RID: 9415
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001AA9 RID: 6825
		private int <SyntheticNonEmptyStructMarker>;
	}
}
