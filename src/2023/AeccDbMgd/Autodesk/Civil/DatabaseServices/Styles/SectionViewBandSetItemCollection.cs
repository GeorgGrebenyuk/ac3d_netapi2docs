using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices.Styles
{
	// Token: 0x02000FB6 RID: 4022
	public sealed class SectionViewBandSetItemCollection : BandSetItemCollection, IEnumerable<SectionViewBandSetItem>
	{
		// Token: 0x17000FDB RID: 4059
		public extern SectionViewBandSetItem this[int index]
		{
			get;
		}

		// Token: 0x06001FC7 RID: 8135
		[Obsolete("Use the combination of Autodesk.Civil.DatabaseServices.Styles.BandStyle.GetBandStyleId and Autodesk.Civil.DatabaseServices.Styles.BandSetItemCollection.Add instead.", false)]
		[DeprecatedVersion(CivilVersion.Civil2013)]
		public extern void Add(Database database, BandType bandType, string sectionBandStyleName);

		// Token: 0x06001FC8 RID: 8136
		public extern IEnumerator<SectionViewBandSetItem> GetEnumerator();

		// Token: 0x06001FC9 RID: 8137
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06001FCA RID: 8138
		public extern SectionViewBandSetItemCollection(BandLocationType location, ObjectId sectionViewBandSetStyleId);

		// Token: 0x06001FCB RID: 8139
		[DeprecatedVersion(CivilVersion.Civil2013)]
		[Obsolete("Use SectionViewBandSetItemCollection(BandLocationType location, ObjectId sectionViewBandSetStyleId) instead.", true)]
		public extern SectionViewBandSetItemCollection(BandLocationType location);

		// Token: 0x04001874 RID: 6260
		private int <SyntheticNonEmptyStructMarker>;
	}
}
