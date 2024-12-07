using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000089 RID: 137
	[Wrapper("AeccDbSectionProjection")]
	public sealed class SectionProjection : Section
	{
		// Token: 0x17000243 RID: 579
		// (set) Token: 0x06000625 RID: 1573
		public override extern ObjectId StyleId { set; }

		// Token: 0x17000242 RID: 578
		// (set) Token: 0x06000626 RID: 1574
		public override extern string StyleName { set; }
	}
}
