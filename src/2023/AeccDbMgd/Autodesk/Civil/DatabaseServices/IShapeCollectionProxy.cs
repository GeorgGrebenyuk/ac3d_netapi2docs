using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020011C4 RID: 4548
	internal interface IShapeCollectionProxy
	{
		// Token: 0x06002630 RID: 9776
		Shape Add(Link link1, Link link2, Link link3, Link link4, string code);

		// Token: 0x06002631 RID: 9777
		Shape Add(Link[] links, string code);

		// Token: 0x06002632 RID: 9778
		Shape Item(int index);

		// Token: 0x06002633 RID: 9779
		int Count();

		// Token: 0x06002634 RID: 9780
		void Remove(int index);
	}
}
