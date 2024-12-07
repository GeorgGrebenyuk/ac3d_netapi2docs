using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace Autodesk.Civil.DatabaseServices
{
	// Token: 0x02000010 RID: 16
	[Wrapper("AeccDbSectionPressurePipeNetwork")]
	public sealed class SectionPressurePipeNetwork : Section
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000103 RID: 259
		public override extern ObjectId SourceId { get; }
	}
}
