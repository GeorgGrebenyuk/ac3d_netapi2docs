using System;

namespace Autodesk.Aec.Content
{
	// Token: 0x02000028 RID: 40
	public class CaMgdException : Exception
	{
		// Token: 0x06000003 RID: 3
		public extern CaMgdException();

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4
		// (set) Token: 0x06000005 RID: 5
		public override extern string Message { get; protected set; }

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6
		// (set) Token: 0x06000007 RID: 7
		public extern CaMgdErrorStatus ErrorCode { get; protected set; }

		// Token: 0x040002FD RID: 765
		private int <SyntheticNonEmptyStructMarker>;
	}
}
