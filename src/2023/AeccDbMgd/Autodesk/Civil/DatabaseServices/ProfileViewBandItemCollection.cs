using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.Civil.DatabaseServices.Styles;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000ED0 RID: 3792
	public sealed class ProfileViewBandItemCollection : BandSetItemCollection, IEnumerable<ProfileViewBandItem>
	{
		// Token: 0x17000E5A RID: 3674
		public extern ProfileViewBandItem this[int index]
		{
			get;
		}

		// Token: 0x06001CA7 RID: 7335
		[Obsolete("Use the combination of Autodesk.Civil.DatabaseServices.Styles.BandSetItemCollection.GetBandStyleId and Autodesk.Civil.DatabaseServices.Styles.BandSetItemCollection.Add instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public extern void Add(BandType bandType, string profileBandStyleName);

		// Token: 0x06001CA8 RID: 7336
		public extern IEnumerator<ProfileViewBandItem> GetEnumerator();

		// Token: 0x06001CA9 RID: 7337
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06001CAA RID: 7338
		public extern ProfileViewBandItemCollection(ObjectId profileViewId, BandLocationType location);

		// Token: 0x040017A6 RID: 6054
		private int <SyntheticNonEmptyStructMarker>;
	}
}
