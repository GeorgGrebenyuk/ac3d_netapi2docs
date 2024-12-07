using System;

namespace Autodesk.Aec.Content
{
	// Token: 0x0200003B RID: 59
	public class CaMgdTermCaption
	{
		// Token: 0x0600000F RID: 15
		public extern CaMgdTermCaption(string name, string displayName);

		// Token: 0x06000010 RID: 16
		public extern CaMgdTermCaption(string name);

		// Token: 0x06000011 RID: 17
		public unsafe extern CaMgdTermCaption(CaTermCaption* termCaption);

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000012 RID: 18
		public extern string Name { get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19
		public extern string DisplayName { get; }

		// Token: 0x0400045C RID: 1116
		private int <SyntheticNonEmptyStructMarker>;
	}
}
