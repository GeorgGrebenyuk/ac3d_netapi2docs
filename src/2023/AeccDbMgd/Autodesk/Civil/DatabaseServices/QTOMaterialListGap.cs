using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200084E RID: 2126
	public sealed class QTOMaterialListGap : IDisposable
	{
		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001012 RID: 4114
		// (set) Token: 0x06001013 RID: 4115
		public extern double StartStation { get; set; }

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001014 RID: 4116
		// (set) Token: 0x06001015 RID: 4117
		public extern double EndStation { get; set; }

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001016 RID: 4118
		// (set) Token: 0x06001017 RID: 4119
		public extern string Description { get; set; }

		// Token: 0x06001018 RID: 4120
		public sealed extern void Dispose();

		// Token: 0x0400125A RID: 4698
		private int <SyntheticNonEmptyStructMarker>;
	}
}
