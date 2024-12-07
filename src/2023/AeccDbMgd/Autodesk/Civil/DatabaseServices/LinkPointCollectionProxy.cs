using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011CF RID: 4559
	internal sealed class LinkPointCollectionProxy : IPointCollectionProxy
	{
		// Token: 0x06002675 RID: 9845
		public extern LinkPointCollectionProxy(Link link);

		// Token: 0x06002676 RID: 9846
		public extern Point Add(double offset, double elevation, string code);

		// Token: 0x06002677 RID: 9847
		public extern Point Item(int index);

		// Token: 0x06002678 RID: 9848
		public extern int Count();

		// Token: 0x06002679 RID: 9849
		public extern void Remove(int index);

		// Token: 0x04001B13 RID: 6931
		private int <SyntheticNonEmptyStructMarker>;
	}
}
