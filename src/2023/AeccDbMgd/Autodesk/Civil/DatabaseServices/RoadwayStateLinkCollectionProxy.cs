using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011B7 RID: 4535
	internal sealed class RoadwayStateLinkCollectionProxy : ILinkCollectionProxy
	{
		// Token: 0x060025F5 RID: 9717
		public unsafe extern RoadwayStateLinkCollectionProxy(AeccDbRoadwayState* pRwState);

		// Token: 0x060025F6 RID: 9718
		public extern Link Add(IPoint[] points, string code, CorridorLinkDisplay displayMode);

		// Token: 0x060025F7 RID: 9719
		public extern Link Item(int index);

		// Token: 0x060025F8 RID: 9720
		public extern int Count();

		// Token: 0x060025F9 RID: 9721
		public extern void Remove(int index);

		// Token: 0x04001B01 RID: 6913
		private int <SyntheticNonEmptyStructMarker>;
	}
}
