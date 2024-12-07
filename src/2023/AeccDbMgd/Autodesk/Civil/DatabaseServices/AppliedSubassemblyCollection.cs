using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200112D RID: 4397
	public sealed class AppliedSubassemblyCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<AppliedSubassembly>
	{
		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06002447 RID: 9287
		public extern ObjectId CorridorId { get; }

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06002448 RID: 9288
		public extern int Count { get; }

		// Token: 0x170012EE RID: 4846
		public extern AppliedSubassembly this[int index]
		{
			get;
		}

		// Token: 0x0600244A RID: 9290
		public extern ObjectId[] ObjectIds();

		// Token: 0x0600244B RID: 9291
		public extern IEnumerator<AppliedSubassembly> GetEnumerator();

		// Token: 0x0600244C RID: 9292
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001A84 RID: 6788
		private int <SyntheticNonEmptyStructMarker>;
	}
}
