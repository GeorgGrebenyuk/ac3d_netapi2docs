using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001136 RID: 4406
	public sealed class CalculatedShapeCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<CalculatedShape>
	{
		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06002474 RID: 9332
		public extern ObjectId CorridorId { get; }

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06002475 RID: 9333
		public extern int Count { get; }

		// Token: 0x170012F9 RID: 4857
		public extern CalculatedShape this[int index]
		{
			get;
		}

		// Token: 0x06002477 RID: 9335
		public extern IEnumerator<CalculatedShape> GetEnumerator();

		// Token: 0x06002478 RID: 9336
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001A8A RID: 6794
		private int <SyntheticNonEmptyStructMarker>;
	}
}
