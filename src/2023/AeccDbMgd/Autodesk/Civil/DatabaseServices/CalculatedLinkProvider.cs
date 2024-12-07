using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using std;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02001130 RID: 4400
	internal abstract class CalculatedLinkProvider : IDisposable
	{
		// Token: 0x0600245D RID: 9309
		public unsafe extern CalculatedLinkProvider(AeccDbCorridor* pCorridor, CalculatedLinksIdentity* pIdentity, RoadwayStateData roadwayStateData);

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x0600245E RID: 9310
		public extern int LinkCount { get; }

		// Token: 0x170012F7 RID: 4855
		public extern CalculatedLink this[int index]
		{
			get;
		}

		// Token: 0x06002460 RID: 9312
		protected abstract int calculateCount();

		// Token: 0x06002461 RID: 9313
		protected unsafe abstract pair<AcDbObjectId,long>* getSubassemblyAndEntityInfoAt(pair<AcDbObjectId,long>*, int index);

		// Token: 0x06002462 RID: 9314
		[HandleProcessCorruptedStateExceptions]
		protected virtual extern void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0);

		// Token: 0x06002463 RID: 9315
		public sealed extern void Dispose();

		// Token: 0x06002464 RID: 9316
		protected override extern void Finalize();

		// Token: 0x04001A87 RID: 6791
		protected unsafe AeccDbCorridor* m_pCorridor;

		// Token: 0x04001A88 RID: 6792
		protected unsafe CalculatedLinksIdentity* m_pIdentity;

		// Token: 0x04001A89 RID: 6793
		protected RoadwayStateData m_RoadwayStateData;
	}
}
