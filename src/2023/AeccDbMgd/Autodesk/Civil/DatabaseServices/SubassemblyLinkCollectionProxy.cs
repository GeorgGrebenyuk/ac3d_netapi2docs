using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011B8 RID: 4536
	internal sealed class SubassemblyLinkCollectionProxy : ILinkCollectionProxy
	{
		// Token: 0x060025FA RID: 9722
		public unsafe extern SubassemblyLinkCollectionProxy(AeccDbSubassembly* pSubassembly);

		// Token: 0x060025FB RID: 9723
		public extern Link Add(IPoint[] points, string code, CorridorLinkDisplay displayMode);

		// Token: 0x060025FC RID: 9724
		public extern Link Item(int index);

		// Token: 0x060025FD RID: 9725
		public extern int Count();

		// Token: 0x060025FE RID: 9726
		public extern void Remove(int index);

		// Token: 0x04001B02 RID: 6914
		private int <SyntheticNonEmptyStructMarker>;
	}
}
