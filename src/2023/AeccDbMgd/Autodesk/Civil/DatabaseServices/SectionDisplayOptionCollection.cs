using System;
using System.Collections.Generic;
using System.Reflection;
using Autodesk.AutoCAD.DatabaseServices;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000909 RID: 2313
	[DefaultMember("Item")]
	public sealed class SectionDisplayOptionCollection : GraphDisplayOptionCollection<SectionDisplayOption>, IDisposable
	{
		// Token: 0x060011B2 RID: 4530
		public extern SectionDisplayOptionCollection(ObjectId sampleLineGroupOid);

		// Token: 0x060011B3 RID: 4531
		public sealed override extern IEnumerator<SectionDisplayOption> GetEnumerator();

		// Token: 0x060011B4 RID: 4532
		public extern void SetLabelSet(ObjectId sectionLabelSetId);

		// Token: 0x060011B5 RID: 4533
		public sealed extern void Dispose();

		// Token: 0x04001311 RID: 4881
		private int <SyntheticNonEmptyStructMarker>;
	}
}
