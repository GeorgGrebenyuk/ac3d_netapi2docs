using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011B6 RID: 4534
	internal interface ILinkCollectionProxy
	{
		// Token: 0x060025F1 RID: 9713
		Link Add(IPoint[] points, string code, CorridorLinkDisplay displayMode);

		// Token: 0x060025F2 RID: 9714
		Link Item(int index);

		// Token: 0x060025F3 RID: 9715
		int Count();

		// Token: 0x060025F4 RID: 9716
		void Remove(int index);
	}
}
