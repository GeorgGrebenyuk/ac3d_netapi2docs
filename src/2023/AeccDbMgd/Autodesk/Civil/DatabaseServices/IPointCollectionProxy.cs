using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011CC RID: 4556
	internal interface IPointCollectionProxy
	{
		// Token: 0x06002667 RID: 9831
		Point Add(double offset, double elevation, string code);

		// Token: 0x06002668 RID: 9832
		Point Item(int index);

		// Token: 0x06002669 RID: 9833
		int Count();

		// Token: 0x0600266A RID: 9834
		void Remove(int index);
	}
}
