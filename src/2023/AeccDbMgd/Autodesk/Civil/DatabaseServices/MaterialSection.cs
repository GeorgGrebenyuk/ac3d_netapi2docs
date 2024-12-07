using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000060 RID: 96
	[Wrapper("AeccDbMaterialSection")]
	public sealed class MaterialSection : Section
	{
		// Token: 0x17000157 RID: 343
		// (set) Token: 0x06000433 RID: 1075
		public override extern ObjectId StyleId { set; }

		// Token: 0x17000156 RID: 342
		// (set) Token: 0x06000434 RID: 1076
		public override extern string StyleName { set; }
	}
}
