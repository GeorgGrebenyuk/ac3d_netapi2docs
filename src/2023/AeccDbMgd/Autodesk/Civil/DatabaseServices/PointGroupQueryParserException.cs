using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x0200085B RID: 2139
	public class PointGroupQueryParserException : ArgumentException
	{
		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600102C RID: 4140
		public extern string Query { get; }

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x0600102D RID: 4141
		public extern int Position { get; }

		// Token: 0x04001265 RID: 4709
		private int <SyntheticNonEmptyStructMarker>;
	}
}
