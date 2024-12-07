using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011B9 RID: 4537
	internal sealed class ShapeLinkCollectionProxy : ILinkCollectionProxy
	{
		// Token: 0x060025FF RID: 9727
		public extern ShapeLinkCollectionProxy(Shape shape);

		// Token: 0x06002600 RID: 9728
		public extern Link Add(IPoint[] points, string code, CorridorLinkDisplay displayMode);

		// Token: 0x06002601 RID: 9729
		public extern Link Item(int index);

		// Token: 0x06002602 RID: 9730
		public extern int Count();

		// Token: 0x06002603 RID: 9731
		public extern void Remove(int index);

		// Token: 0x04001B03 RID: 6915
		private int <SyntheticNonEmptyStructMarker>;
	}
}
