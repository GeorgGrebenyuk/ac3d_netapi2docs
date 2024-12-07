using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011C5 RID: 4549
	internal sealed class RoadwayStateShapeCollectionProxy : IShapeCollectionProxy
	{
		// Token: 0x06002635 RID: 9781
		public unsafe extern RoadwayStateShapeCollectionProxy(AeccDbRoadwayState* pRwState);

		// Token: 0x06002636 RID: 9782
		public extern Shape Add(Link link1, Link link2, Link link3, Link link4, string code);

		// Token: 0x06002637 RID: 9783
		public extern Shape Add(Link[] links, string code);

		// Token: 0x06002638 RID: 9784
		public extern Shape Item(int index);

		// Token: 0x06002639 RID: 9785
		public extern int Count();

		// Token: 0x0600263A RID: 9786
		public extern void Remove(int index);

		// Token: 0x04001B0C RID: 6924
		private int <SyntheticNonEmptyStructMarker>;
	}
}
