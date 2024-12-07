using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011CE RID: 4558
	internal sealed class SubassemblyPointCollectionProxy : IPointCollectionProxy
	{
		// Token: 0x06002670 RID: 9840
		public unsafe extern SubassemblyPointCollectionProxy(AeccDbSubassembly* pSubassembly);

		// Token: 0x06002671 RID: 9841
		public extern Point Add(double offset, double elevation, string code);

		// Token: 0x06002672 RID: 9842
		public extern Point Item(int index);

		// Token: 0x06002673 RID: 9843
		public extern int Count();

		// Token: 0x06002674 RID: 9844
		public extern void Remove(int index);

		// Token: 0x04001B12 RID: 6930
		private int <SyntheticNonEmptyStructMarker>;
	}
}
