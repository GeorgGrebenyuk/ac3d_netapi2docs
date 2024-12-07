using System;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000EA9 RID: 3753
	public sealed class ProfileViewBandSet : GraphBandSet
	{
		// Token: 0x06001C89 RID: 7305
		public extern ProfileViewBandItemCollection GetTopBandItems();

		// Token: 0x06001C8A RID: 7306
		public extern void SetTopBandItems(ProfileViewBandItemCollection bandItems);

		// Token: 0x06001C8B RID: 7307
		public extern ProfileViewBandItemCollection GetBottomBandItems();

		// Token: 0x06001C8C RID: 7308
		public extern void SetBottomBandItems(ProfileViewBandItemCollection bandItems);
	}
}
