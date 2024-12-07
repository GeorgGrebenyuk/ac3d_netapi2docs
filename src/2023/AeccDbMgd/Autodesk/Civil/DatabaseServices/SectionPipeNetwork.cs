using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x020000CA RID: 202
	[Wrapper("AeccDbSectionPipeNetwork")]
	public sealed class SectionPipeNetwork : Section
	{
		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000973 RID: 2419
		// (set) Token: 0x06000974 RID: 2420
		public override extern ObjectId StyleId { get; set; }

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000975 RID: 2421
		// (set) Token: 0x06000976 RID: 2422
		public override extern string StyleName { get; set; }
	}
}
