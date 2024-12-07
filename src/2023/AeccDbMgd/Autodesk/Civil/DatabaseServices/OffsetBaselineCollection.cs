using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200114B RID: 4427
	public sealed class OffsetBaselineCollection : CivilWrapper<AeccDbCorridor>, IEnumerable<OffsetBaseline>
	{
		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x060024AD RID: 9389
		public extern ObjectId CorridorId { get; }

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x060024AE RID: 9390
		public extern int Count { get; }

		// Token: 0x1700131B RID: 4891
		public extern OffsetBaseline this[Guid offsetGUID]
		{
			get;
		}

		// Token: 0x1700131C RID: 4892
		public extern OffsetBaseline this[string baselineName]
		{
			get;
		}

		// Token: 0x1700131D RID: 4893
		public extern OffsetBaseline this[int index]
		{
			get;
		}

		// Token: 0x060024B2 RID: 9394
		public extern string[] OffsetBaselineNames();

		// Token: 0x060024B3 RID: 9395
		public extern IEnumerator<OffsetBaseline> GetEnumerator();

		// Token: 0x060024B4 RID: 9396
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x04001A9E RID: 6814
		private int <SyntheticNonEmptyStructMarker>;
	}
}
