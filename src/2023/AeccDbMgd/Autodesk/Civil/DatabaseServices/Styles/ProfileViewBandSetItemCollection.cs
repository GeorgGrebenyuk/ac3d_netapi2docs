using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000FB3 RID: 4019
	public sealed class ProfileViewBandSetItemCollection : BandSetItemCollection, IEnumerable<ProfileViewBandSetItem>
	{
		// Token: 0x17000FD8 RID: 4056
		public extern ProfileViewBandSetItem this[int index]
		{
			get;
		}

		// Token: 0x06001FBB RID: 8123
		[Obsolete("Use the combination of Autodesk.Civil.DatabaseServices.Styles.BandStyle.GetBandStyleId and Autodesk.Civil.DatabaseServices.Styles.BandSetItemCollection.Add instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public extern void Add(Database database, BandType bandType, string profileBandStyleName);

		// Token: 0x06001FBC RID: 8124
		public extern IEnumerator<ProfileViewBandSetItem> GetEnumerator();

		// Token: 0x06001FBD RID: 8125
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06001FBE RID: 8126
		[Obsolete("Use ProfileViewBandSetItemCollection(BandLocationType location, ObjectId profileViewBandSetStyleId) instead.", true)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public extern ProfileViewBandSetItemCollection(BandLocationType location);

		// Token: 0x06001FBF RID: 8127
		public extern ProfileViewBandSetItemCollection(BandLocationType location, ObjectId profileViewBandSetStyleId);

		// Token: 0x04001872 RID: 6258
		private int <SyntheticNonEmptyStructMarker>;
	}
}
