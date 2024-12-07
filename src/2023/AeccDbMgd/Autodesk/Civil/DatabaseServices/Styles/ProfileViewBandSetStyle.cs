using System;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000097 RID: 151
	[Wrapper("AeccDbGraphProfileBandStyleSet")]
	public sealed class ProfileViewBandSetStyle : BandSetStyle
	{
		// Token: 0x0600069E RID: 1694
		public extern ProfileViewBandSetItemCollection GetTopBandSetItems();

		// Token: 0x0600069F RID: 1695
		public extern void SetTopBandSetItems(ProfileViewBandSetItemCollection bandSetItems);

		// Token: 0x060006A0 RID: 1696
		public extern ProfileViewBandSetItemCollection GetBottomBandSetItems();

		// Token: 0x060006A1 RID: 1697
		public extern void SetBottomBandSetItems(ProfileViewBandSetItemCollection bandSetItems);
	}
}
