using System;
using System.Collections;
using System.Collections.Generic;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.Civil.DatabaseServices.Styles;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000937 RID: 2359
	public sealed class SectionViewBandItemCollection : BandSetItemCollection, IEnumerable<SectionViewBandItem>
	{
		// Token: 0x17000771 RID: 1905
		public extern SectionViewBandItem this[int index]
		{
			get;
		}

		// Token: 0x06001213 RID: 4627
		public extern IEnumerator<SectionViewBandItem> GetEnumerator();

		// Token: 0x06001214 RID: 4628
		public extern IEnumerator GetObjectEnumerator();

		// Token: 0x06001215 RID: 4629
		public extern SectionViewBandItemCollection(ObjectId sectionViewId, BandLocationType location);

		// Token: 0x04001336 RID: 4918
		private int <SyntheticNonEmptyStructMarker>;
	}
}
