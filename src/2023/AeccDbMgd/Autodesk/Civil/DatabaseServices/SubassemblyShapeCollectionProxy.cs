using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011C6 RID: 4550
	internal sealed class SubassemblyShapeCollectionProxy : IShapeCollectionProxy
	{
		// Token: 0x0600263B RID: 9787
		public unsafe extern SubassemblyShapeCollectionProxy(AeccDbSubassembly* pSubassembly);

		// Token: 0x0600263C RID: 9788
		public extern Shape Add(Link link1, Link link2, Link link3, Link link4, string code);

		// Token: 0x0600263D RID: 9789
		public extern Shape Add(Link[] links, string code);

		// Token: 0x0600263E RID: 9790
		public extern Shape Item(int index);

		// Token: 0x0600263F RID: 9791
		public extern int Count();

		// Token: 0x06002640 RID: 9792
		public extern void Remove(int index);

		// Token: 0x04001B0D RID: 6925
		private int <SyntheticNonEmptyStructMarker>;
	}
}
