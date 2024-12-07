using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011CD RID: 4557
	internal sealed class RoadwayStatePointCollectionProxy : IPointCollectionProxy
	{
		// Token: 0x0600266B RID: 9835
		public unsafe extern RoadwayStatePointCollectionProxy(AeccDbRoadwayState* pRwState);

		// Token: 0x0600266C RID: 9836
		public extern Point Add(double offset, double elevation, string code);

		// Token: 0x0600266D RID: 9837
		public extern Point Item(int index);

		// Token: 0x0600266E RID: 9838
		public extern int Count();

		// Token: 0x0600266F RID: 9839
		public extern void Remove(int index);

		// Token: 0x04001B11 RID: 6929
		private int <SyntheticNonEmptyStructMarker>;
	}
}
